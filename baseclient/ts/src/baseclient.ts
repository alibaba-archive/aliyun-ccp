import * as $tea from "@alicloud/tea-typescript";
import * as kitx from "kitx";

function filter(value: string) {
    return value.replace(/[\t\n\r\f]/g, ' ');
}

function getCanonicalizedHeaders(headers: { [key: string]: string }) {
    const prefix = 'x-acs-';
    const keys = Object.keys(headers);

    const canonicalizedKeys = [];
    for (let i = 0; i < keys.length; i++) {
        const key = keys[i];
        if (key.startsWith(prefix)) {
            canonicalizedKeys.push(key);
        }
    }

    canonicalizedKeys.sort();

    var result = '';
    for (let i = 0; i < canonicalizedKeys.length; i++) {
        const key = canonicalizedKeys[i];
        result += `${key}:${filter(headers[key]).trim()}\n`;
    }

    return result;
}

function getCanonicalizedResource(pathname: string, query: { [key: string]: string }) {
    const keys = Object.keys(query).sort();

    if (keys.length === 0) {
        return pathname;
    }

    var result = [];
    for (var i = 0; i < keys.length; i++) {
        const key = keys[i];
        result.push(`${key}=${query[key]}`);
    }

    return `${pathname}?${result.join('&')}`;
}

export default class BaseClient {
    _endpoint: string
    _domainId: string
    _protocol: string
    _accessToken: string
    _accessKeyId: string
    _accessKeySecret: string
    _userId: string

    constructor(config: { [key: string]: any }) {
        this._domainId = config['domainId'];
        this._protocol = config['protocol'];
        this._accessToken = config['accessToken'];
        this._accessKeyId = config['accessKeyId'];
        this._accessKeySecret = config['accessKeySecret'];
        this._userId = config['userId'];
    }

    async _getAccessKeyId(): Promise<string> {
        return this._accessKeyId;
    }

    async _getAccessKeySecret(): Promise<string> {
        return this._accessKeySecret;
    }

    async _getAccessToken(): Promise<string> {
        return this._accessToken;
    }

    _getHost(input: string, default_: string): string {
        return input || default_;
    }

    _getUserAgent(): string {
        return "";
    }

    _getProtocol(input: string, default_: string): string {
        return input || default_;
    }

    async _readAsJSON(response: $tea.Response): Promise<any> {
        let body = await response.readBytes();
        return JSON.parse(body.toString());
    }

    _isStatusCode(response: $tea.Response, status: number): boolean {
        return response.statusCode == status;
    }

    _toJSONString(body: any): string {
        return JSON.stringify(body);
    }

    _toQuery(query: { [key: string]: any }): { [key: string]: string } {
        if (!query) {
            return;
        }
        let ret: { [key: string]: string } = {};
        for (let [key, value] of Object.entries(query)) {
            ret[key] = value.toString();
        }
        return ret;
    }

    _notEmpty(input: string): boolean {
        return input && input.length > 0;
    }

    _getRFC2616Date(): string {
        let now = new Date();
        return now.toUTCString();
    }

    _default(input: string, default_: string): string {
        if (typeof input === 'undefined') {
            return default_;
        }
        return input;
    }

    _defaultNumber(input: number, default_: number): number {
        if (typeof input === 'undefined') {
            return default_;
        }
        return input;
    }
    
    _getPathname(nickName: string, path: string): string {
        if (!nickName) {
            return path;
        }
        return `/${nickName}${path}`;
    } 

    _getSignature(request: $tea.Request): string {
        const method = request.method;
        const pathname = request.pathname;
        const headers = request.headers;
        const query = request.query || {};
        const accept = headers['accept'];
        const contentMD5 = headers['content-md5'] || '';
        const contentType = headers['content-type'] || '';
        const date = headers['date'] || '';

        const header = `${method}\n${accept}\n${contentMD5}\n${contentType}\n${date}\n`;

        const canonicalizedHeaders = getCanonicalizedHeaders(headers);
        const canonicalizedResource = getCanonicalizedResource(pathname, query);

        const stringToSign = `${header}${canonicalizedHeaders}${canonicalizedResource}`;
        const utf8Buff = Buffer.from(stringToSign, 'utf8');

        return <string>kitx.sha1(utf8Buff, this._accessKeySecret, 'base64');
    }
}
