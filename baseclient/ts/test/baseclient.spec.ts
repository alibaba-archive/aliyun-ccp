'use strict';

import BaseClient from "../src/baseclient";
import * as $tea from "@alicloud/tea-typescript";
import { createServer, Server } from 'http';
import { request } from 'httpx';
import 'mocha';
import assert from 'assert';

describe('base client', function () {
    let server: Server;
    const returnData = { ok: true, data: { testId: 1, testName: 'test' } };
    before(() => {
        server = createServer((req, res) => {
            res.writeHead(200, { 'Content-Type': 'application/json' });
            res.end(JSON.stringify(returnData));
        }).listen(8848, () => {
            //
        });
    })



    it('new client should ok', async function () {
        const config = {
            domainId: 'em81',
            protocol: 'http',
            accessToken: 'accessToken',
            accessKeyId: 'accessKeyId',
            accessKeySecret: 'accessKeySecret',
            userId: '81',
        };
        const client = new BaseClient(config);
        assert.strictEqual(client._domainId, config.domainId);
        assert.strictEqual(client._protocol, config.protocol);
        assert.strictEqual(client._accessToken, config.accessToken);
        assert.strictEqual(client._accessKeyId, config.accessKeyId);
        assert.strictEqual(client._accessKeySecret, config.accessKeySecret);
        assert.strictEqual(client._userId, config.userId);
    });

    it('_getAccessKeyId should ok', async function () {
        const accessKeyId = Math.random().toString(16).slice(-12);
        const client = new BaseClient({ accessKeyId });
        assert.strictEqual(await client._getAccessKeyId(), accessKeyId);
    });

    it('_getAccessKeySecret should ok', async function () {
        const accessKeySecret = Math.random().toString(16).slice(-12);
        const client = new BaseClient({ accessKeySecret });
        assert.strictEqual(await client._getAccessKeySecret(), accessKeySecret);
    });


    it('_getAccessToken should ok', async function () {
        const accessToken = Math.random().toString(16).slice(-12);
        const client = new BaseClient({ accessToken });
        assert.strictEqual(await client._getAccessToken(), accessToken);
    });

    it('_getHost should ok', async function () {
        const client = new BaseClient({});
        assert.strictEqual(client._getHost(undefined, 'default.com'), 'default.com');
        assert.strictEqual(client._getHost('not.default.com', 'default.com'), 'not.default.com');
    });

    it('_getUserAgent should ok', async function () {
        const client = new BaseClient({});
        assert.strictEqual(client._getUserAgent(), '');
    });

    it('_getProtocol should ok', async function () {
        const client = new BaseClient({});
        assert.strictEqual(client._getProtocol(undefined, 'http'), 'http');
        assert.strictEqual(client._getProtocol('https', 'http'), 'https');
    });

    it('_readAsJSON should ok', async function () {
        const client = new BaseClient({});
        const res = await request('http://127.0.0.1:8848', { method: 'GET' });
        const teaRes = new $tea.Response(res);
        assert.deepStrictEqual(await client._readAsJSON(teaRes), returnData);
    });

    it('_isStatusCode should ok', async function () {
        const client = new BaseClient({});
        const res = await request('http://127.0.0.1:8848', { method: 'GET' });
        const teaRes = new $tea.Response(res);
        assert.ok(client._isStatusCode(teaRes, 200));
    });

    it('_toJSONString should ok', async function () {
        const client = new BaseClient({});
        assert.strictEqual(client._toJSONString({ test: true }), '{"test":true}');
    });

    it('_toQuery should ok', async function () {
        const client = new BaseClient({});
        assert.deepStrictEqual(
            client._toQuery({
                number: 1,
                boolean: true,
                string: '1234'
            }), {
            number: '1',
            boolean: 'true',
            string: '1234'
        });
        assert.equal(client._toQuery(undefined), undefined);
    });

    it('_notEmpty should ok', async function () {
        const client = new BaseClient({});
        assert.ok(client._notEmpty('test'));
        assert.equal(client._notEmpty(''), false);
        assert.equal(client._notEmpty(undefined), undefined);
    });

    it('_getRFC2616Date should ok', async function () {
        const client = new BaseClient({});
        const date = new Date();
        assert.strictEqual(client._getRFC2616Date(), date.toUTCString());
    });

    it('_default should ok', async function () {
        const client = new BaseClient({});
        assert.strictEqual(client._default(undefined, 'default'), 'default');
        assert.strictEqual(client._default('not_default', 'default'), 'not_default');
    });

    it('_defaultNumber should ok', async function () {
        const client = new BaseClient({});
        assert.strictEqual(client._defaultNumber(undefined, 2019), 2019);
        assert.strictEqual(client._defaultNumber(2020, 2019), 2020);
    });

    it('_getPathname should ok', async function () {
        const client = new BaseClient({});
        assert.strictEqual(client._getPathname(undefined, '/pathname'), '/pathname');
        assert.strictEqual(client._getPathname('', '/pathname'), '/pathname');
        assert.strictEqual(client._getPathname('nickName', '/pathname'), '/nickName/pathname');
    });

    it('_getSignature should ok', async function () {
        const client = new BaseClient({
            accessKeySecret: 'accessKeySecret'
        });
        const request = new $tea.Request();
        request.method = 'GET';
        request.pathname = '/test';
        request.headers = {
            accept: 'application/json'
        };
        request.query = {
            id: '9102'
        };
        assert.ok(client._getSignature(request));
    });

    it('empty query _getSignature should ok', async function () {
        const client = new BaseClient({
            accessKeySecret: 'accessKeySecret'
        });
        const request = new $tea.Request();
        request.method = 'GET';
        request.pathname = '/test';
        request.headers = {
            accept: 'application/json'
        };
        request.query = null;
        assert.ok(client._getSignature(request));
    });

    it('x-acs-* header _getSignature should ok', async function () {
        const client = new BaseClient({
            accessKeySecret: 'accessKeySecret'
        });
        const request = new $tea.Request();
        request.method = 'GET';
        request.pathname = '/test';
        request.headers = {
            accept: 'application/json',
            'x-acs-test': 'test1\r\n\r\ntest2'
        };
        request.query = {
            id: '9102'
        };
        assert.ok(client._getSignature(request));
    });

    after(() => {
        server.close();
    });
});
