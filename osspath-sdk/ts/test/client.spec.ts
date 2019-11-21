'use strict';

import Client, { Config, ListDriveRequest, RuntimeOptions } from "../src/client";
import 'mocha';
import assert from 'assert';

describe('client', function () {
  let client;
  before(async function () {
    var config = new Config({
        domainId: 'sz16',
        protocol: 'http',
        accessKeyId: process.env['ACCESS_KEY_ID'],
        accessKeySecret: process.env['ACCESS_KEY_SECRET']
    });
    client = new Client(config);
  });

  it('listDrives', async function () {
    let request = new ListDriveRequest({});
    let runtime = new RuntimeOptions({});
    let result = await client.listDrives(request, runtime);
    assert.strictEqual(2, result.items.length);
    assert.strictEqual("", result.nextMarker);
  });
});
