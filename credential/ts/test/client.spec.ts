import Client, { Config } from '../src/client';
import 'mocha';
import * as assert from 'assert';
import { Server, createServer } from 'http';

function timestamp(dateStr?: Date, timeChange?: number): string {
  let date = new Date(dateStr);
  if (!dateStr || isNaN(date.getTime())) {
    date = new Date();
  }
  if (timeChange) {
    date.setTime(date.getTime() + timeChange);
  }
  return date.toISOString();
}



describe('client', function () {
  let server: Server;
  before(function (done) {
    let result = {
      access_token: 'newAccessToken',
      secret_token: 'secretToken',
      expire_time: timestamp(new Date(), 1000 * 3600),
      refresh_token: 'newRefreshToken'
    };
    server = createServer((req, res) => {
      if (req.method == 'POST') {
        res.writeHead(200, { 'Content-Type': 'application/json' });
        res.end(JSON.stringify(result));
      } else {
        res.writeHead(200, { 'Content-Type': 'application/json' });
        res.end('test');
      }
    }).listen(8848, () => {
      done();
    });
  });
  it('getHost should ok', async function () {
    const client = new Client(new Config());
    assert.strictEqual("domain", client._getHost(null, "domain"));
    assert.strictEqual("endpoint", client._getHost("endpoint", null));
    assert.strictEqual("domain", client._getHost("", "domain"));
  });

  it('construct should ok', async function () {
    const config = new Config();
    config.refreshToken = "refreshToken";
    config.accessToken = "accessToken";
    config.expireTime = "4000-01-01T12:12:12Z";
    const client = new Client(config);
    assert.strictEqual("4000-01-01T12:12:12Z", client.getExpireTime());
    assert.strictEqual("refreshToken", client.getRefreshToken());
    const _accessToken = await client.getAccessToken();
    assert.strictEqual("accessToken", _accessToken);
  });

  it('set should ok', async function () {
    const client = new Client(new Config());
    try {
      await client.getAccessToken();
      assert.fail();
    } catch (e) {
      assert.strictEqual("accessToken is not exists", e.message);
    }

    client.setAccessToken("test");
    const _accessToken = await client.getAccessToken()
    assert.strictEqual("test", _accessToken);

    client.setExpireTime("1");
    assert.strictEqual("1", client.getExpireTime());

    client.setRefreshToken("token");
    assert.strictEqual("token", client.getRefreshToken());
  });

  it('refreshToken should ok', async function () {
    const client = new Client(new Config({
      endpoint: '127.0.0.1:8848'
    }));
    client.setRefreshToken('refreshToken');
    client.setAccessToken('accessToken');
    client.setExpireTime(timestamp(new Date(), 1000 * 300));
    const _token = await client.getAccessToken();
    assert.strictEqual(_token, 'accessToken')
    const _refresh_token = await client.getRefreshToken();
    assert.strictEqual(_refresh_token, 'refreshToken')

    client.setExpireTime(timestamp(new Date(), 1000 * 299))
    const new_token = await client.getAccessToken();
    assert.strictEqual(new_token, 'newAccessToken');
    const new_refresh_token = await client.getRefreshToken();
    assert.strictEqual(new_refresh_token, 'newRefreshToken');
  });
  after(() => {
    server.close();
  });
});

