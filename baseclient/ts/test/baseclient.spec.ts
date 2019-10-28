'use strict';

import BaseClient from "../src/baseclient";
import * as $tea from "@alicloud/tea-typescript";
import 'mocha';
import assert from 'assert';

describe('base client', function () {
    it('_default should ok', async function () {
        let client = new BaseClient({});
        assert.strictEqual(client._default(undefined, 'default'), 'default');
        assert.strictEqual(client._default('not_default', 'default'), 'not_default');
    });
});
