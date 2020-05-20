// This file is auto-generated, don't edit it
import { Readable } from 'stream';
import * as $tea from '@alicloud/tea-typescript';

export class Config extends $tea.Model {
  endpoint?: string;
  domainId: string;
  clientId?: string;
  refreshToken?: string;
  clientSecret?: string;
  accessToken?: string;
  expireTime?: string;
  static names(): { [key: string]: string } {
    return {
      endpoint: 'endpoint',
      domainId: 'domainId',
      clientId: 'clientId',
      refreshToken: 'refreshToken',
      clientSecret: 'clientSecret',
      accessToken: 'accessToken',
      expireTime: 'expireTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endpoint: 'string',
      domainId: 'string',
      clientId: 'string',
      refreshToken: 'string',
      clientSecret: 'string',
      accessToken: 'string',
      expireTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client {
  _endpoint: string;
  _domainId: string;
  _clientId: string;
  _refreshToken: string;
  _clientSecret: string;
  _accessToken: string;
  _expireTime: string;

  constructor(config: Config) {
    this._endpoint = config.endpoint;
    this._domainId = config.domainId;
    this._clientId = config.clientId;
    this._refreshToken = config.refreshToken;
    this._clientSecret = config.clientSecret;
    this._accessToken = config.accessToken;
    this._expireTime = config.expireTime;
  }


  setExpireTime(expireTime: string): void {
    this._expireTime = expireTime;
  }

  getExpireTime(): string {
    return this._expireTime;
  }

  getRefreshToken(): string {
    return this._refreshToken;
  }

  setRefreshToken(refreshToken: string): void {
    this._refreshToken = refreshToken;
  }

  setAccessToken(accessToken: string): void {
    this._accessToken = accessToken;
  }

  async getAccessToken(): Promise<string> {
    if (!this._accessToken) {
      throw new Error("accessToken is not exists")
    }
    if (this.needUpdateCredential()) {
      await this.refreshAccessToken()
    }
    return this._accessToken;
  }

  needUpdateCredential(): boolean {
    if (!this._refreshToken || !this._expireTime || !this._refreshToken.length) {
      return false;
    }
    return new Date(this._expireTime).getTime() - new Date().getTime() < 300 * 1000;
  }

  async refreshAccessToken(): Promise<void> {
    try {
      let request_ = new $tea.Request();
      request_.protocol = "http";
      request_.method = "POST";
      request_.pathname = "/v2/oauth/token";
      request_.headers = {
        host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
        'content-type': 'application/x-www-form-urlencoded; charset=utf-8',
        'date': this._getRFC2616Date(),
        'accept': 'application/json',
        'x-acs-signature-method': 'HMAC-SHA1',
        'x-acs-signature-version': '1.0',
      };
      let bodyString = `grant_type=refresh_token&refresh_token=${this._refreshToken}&client_id=${this._clientId}&client_secret=${this._clientSecret}`;
      request_.body = new $tea.BytesReadable(bodyString);
      let response_ = await $tea.doAction(request_);
      let respMap: { [key: string]: any } = null;
      if (response_.statusCode === 200) {
        respMap = await this._readAsJSON(response_);
        this.setExpireTime(respMap.expire_time);
        this.setAccessToken(respMap.access_token);
        this.setRefreshToken(respMap.refresh_token);
      }
    } catch (ex) {
      throw ex;
    }
  }

  _getRFC2616Date(): string {
    let now = new Date();
    return now.toUTCString();
  }

  _getHost(endpoint: string, domain: string): string {
    if (endpoint && endpoint.length) {
      return endpoint;
    }
    return domain;
  }
  async _readAsJSON(response: $tea.Response): Promise<any> {
    let body = await response.readBytes();
    return JSON.parse(body.toString());
  }

}
