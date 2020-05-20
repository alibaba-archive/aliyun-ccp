// This file is auto-generated, don't edit it
/**
 *
 */
import Util from '@alicloud/tea-util';
import ROAUtil from '@alicloud/roa-util';
import Credential, * as $Credential from '@alicloud/credentials';
import AccessTokenCredential, * as $AccessTokenCredential from '@alicloud/ccp-credentials';
import * as $tea from '@alicloud/tea-typescript';

export class RuntimeOptions extends $tea.Model {
  autoretry?: boolean;
  ignoreSSL?: boolean;
  maxAttempts?: number;
  backoffPolicy?: string;
  backoffPeriod?: number;
  readTimeout?: number;
  connectTimeout?: number;
  httpProxy?: string;
  httpsProxy?: string;
  noProxy?: string;
  maxIdleConns?: number;
  localAddr?: string;
  socks5Proxy?: string;
  socks5NetWork?: string;
  static names(): { [key: string]: string } {
    return {
      autoretry: 'autoretry',
      ignoreSSL: 'ignoreSSL',
      maxAttempts: 'maxAttempts',
      backoffPolicy: 'backoffPolicy',
      backoffPeriod: 'backoffPeriod',
      readTimeout: 'readTimeout',
      connectTimeout: 'connectTimeout',
      httpProxy: 'httpProxy',
      httpsProxy: 'httpsProxy',
      noProxy: 'noProxy',
      maxIdleConns: 'maxIdleConns',
      localAddr: 'localAddr',
      socks5Proxy: 'socks5Proxy',
      socks5NetWork: 'socks5NetWork',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoretry: 'boolean',
      ignoreSSL: 'boolean',
      maxAttempts: 'number',
      backoffPolicy: 'string',
      backoffPeriod: 'number',
      readTimeout: 'number',
      connectTimeout: 'number',
      httpProxy: 'string',
      httpsProxy: 'string',
      noProxy: 'string',
      maxIdleConns: 'number',
      localAddr: 'string',
      socks5Proxy: 'string',
      socks5NetWork: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class Config extends $tea.Model {
  endpoint?: string;
  domainId?: string;
  clientId?: string;
  refreshToken?: string;
  clientSecret?: string;
  accessToken?: string;
  expireTime?: string;
  protocol?: string;
  type?: string;
  securityToken?: string;
  accessKeyId?: string;
  accessKeySecret?: string;
  nickname?: string;
  userAgent?: string;
  static names(): { [key: string]: string } {
    return {
      endpoint: 'endpoint',
      domainId: 'domainId',
      clientId: 'clientId',
      refreshToken: 'refreshToken',
      clientSecret: 'clientSecret',
      accessToken: 'accessToken',
      expireTime: 'expireTime',
      protocol: 'protocol',
      type: 'type',
      securityToken: 'securityToken',
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      nickname: 'nickname',
      userAgent: 'userAgent',
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
      protocol: 'string',
      type: 'string',
      securityToken: 'string',
      accessKeyId: 'string',
      accessKeySecret: 'string',
      nickname: 'string',
      userAgent: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelLinkRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CancelLinkRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CancelLinkRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelLinkModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AccountAccessTokenResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AccountAccessTokenResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConfirmLinkRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ConfirmLinkRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ConfirmLinkRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConfirmLinkModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AccountAccessTokenResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AccountAccessTokenResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChangePasswordRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: DefaultChangePasswordRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DefaultChangePasswordRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChangePasswordModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AccountAccessTokenResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AccountAccessTokenResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetPasswordRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: DefaultSetPasswordRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DefaultSetPasswordRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetPasswordModel extends $tea.Model {
  headers?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class VerifyCodeRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: VerifyCodeRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: VerifyCodeRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class VerifyCodeModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: VerifyCodeResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: VerifyCodeResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccessTokenByLinkInfoRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetAccessTokenByLinkInfoRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAccessTokenByLinkInfoRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccessTokenByLinkInfoModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AccountAccessTokenResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AccountAccessTokenResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCaptchaRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetCaptchaRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCaptchaRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCaptchaModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: Captcha;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: Captcha,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLinkInfoRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetByLinkInfoRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetByLinkInfoRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLinkInfoModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: LinkInfoResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: LinkInfoResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLinkInfoByUserIdRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetLinkInfoByUserIDRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetLinkInfoByUserIDRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLinkInfoByUserIdModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: LinkInfoListResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: LinkInfoListResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPublicKeyRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetAppPublicKeyRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAppPublicKeyRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPublicKeyModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetAppPublicKeyResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAppPublicKeyResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LinkRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AccountLinkRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AccountLinkRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LinkModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AccountAccessTokenResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AccountAccessTokenResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckExistRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: MobileCheckExistRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MobileCheckExistRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckExistModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: MobileCheckExistResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MobileCheckExistResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: MobileLoginRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MobileLoginRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LoginModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AccountAccessTokenResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AccountAccessTokenResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: MobileRegisterRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MobileRegisterRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AccountAccessTokenResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AccountAccessTokenResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MobileSendSmsCodeRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: MobileSendSmsCodeRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MobileSendSmsCodeRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MobileSendSmsCodeModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: MobileSendSmsCodeResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: MobileSendSmsCodeResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AccountRevokeRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: RevokeRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RevokeRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AccountRevokeModel extends $tea.Model {
  headers?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AccountTokenRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: TokenRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: TokenRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AccountTokenModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AccountAccessTokenResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AccountAccessTokenResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class AccessTokenResponse extends $tea.Model {
  accessToken: string;
  defaultDriveId: string;
  expireTime: string;
  expiresIn: number;
  refreshToken: string;
  role: string;
  tokenType: string;
  userId: string;
  static names(): { [key: string]: string } {
    return {
      accessToken: 'access_token',
      defaultDriveId: 'default_drive_id',
      expireTime: 'expire_time',
      expiresIn: 'expires_in',
      refreshToken: 'refresh_token',
      role: 'role',
      tokenType: 'token_type',
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessToken: 'string',
      defaultDriveId: 'string',
      expireTime: 'string',
      expiresIn: 'number',
      refreshToken: 'string',
      role: 'string',
      tokenType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class AccountAccessTokenResponse extends $tea.Model {
  accessToken: string;
  avatar?: string;
  dataPinSaved?: boolean;
  dataPinSetup?: boolean;
  defaultDriveId?: string;
  existLink?: LinkInfo[];
  expireTime?: string;
  expiresIn?: number;
  isFirstLogin?: boolean;
  needLink: boolean;
  nickName?: string;
  refreshToken?: string;
  role?: string;
  state?: string;
  tokenType?: string;
  userData?: {[key: string]: any};
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      accessToken: 'access_token',
      avatar: 'avatar',
      dataPinSaved: 'data_pin_saved',
      dataPinSetup: 'data_pin_setup',
      defaultDriveId: 'default_drive_id',
      existLink: 'exist_link',
      expireTime: 'expire_time',
      expiresIn: 'expires_in',
      isFirstLogin: 'is_first_login',
      needLink: 'need_link',
      nickName: 'nick_name',
      refreshToken: 'refresh_token',
      role: 'role',
      state: 'state',
      tokenType: 'token_type',
      userData: 'user_data',
      userId: 'user_id',
      userName: 'user_name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessToken: 'string',
      avatar: 'string',
      dataPinSaved: 'boolean',
      dataPinSetup: 'boolean',
      defaultDriveId: 'string',
      existLink: { 'type': 'array', 'itemType': LinkInfo },
      expireTime: 'string',
      expiresIn: 'number',
      isFirstLogin: 'boolean',
      needLink: 'boolean',
      nickName: 'string',
      refreshToken: 'string',
      role: 'string',
      state: 'string',
      tokenType: 'string',
      userData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class AccountLinkRequest extends $tea.Model {
  detail?: string;
  extra?: string;
  identity: string;
  status?: string;
  type: string;
  userId: string;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
      extra: 'extra',
      identity: 'identity',
      status: 'status',
      type: 'type',
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: 'string',
      extra: 'string',
      identity: 'string',
      status: 'string',
      type: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class AuthorizeRequest extends $tea.Model {
  ClientID: string;
  LoginType?: string;
  RedirectUri: string;
  ResponseType: string;
  Scope?: string[];
  State?: string;
  static names(): { [key: string]: string } {
    return {
      ClientID: 'ClientID',
      LoginType: 'LoginType',
      RedirectUri: 'RedirectUri',
      ResponseType: 'ResponseType',
      Scope: 'Scope',
      State: 'State',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ClientID: 'string',
      LoginType: 'string',
      RedirectUri: 'string',
      ResponseType: 'string',
      Scope: { 'type': 'array', 'itemType': 'string' },
      State: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Base file response
 */
export class BaseCCPFileResponse extends $tea.Model {
  category?: string;
  contentHash?: string;
  contentHashName?: string;
  contentType?: string;
  crc64Hash?: string;
  createdAt?: string;
  description?: string;
  domainId?: string;
  downloadUrl?: string;
  driveId?: string;
  encryptMode?: string;
  fileExtension?: string;
  fileId?: string;
  hidden?: boolean;
  imageMediaMetadata?: ImageMediaResponse;
  labels?: string[];
  meta?: string;
  name: string;
  parentFileId?: string;
  size?: number;
  starred?: boolean;
  status?: string;
  streamsUrlInfo?: {[key: string]: any};
  thumbnail?: string;
  trashedAt?: string;
  type?: string;
  updatedAt?: string;
  uploadId?: string;
  url?: string;
  userMeta?: string;
  videoMediaMetadata?: VideoMediaResponse;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentType: 'content_type',
      crc64Hash: 'crc64_hash',
      createdAt: 'created_at',
      description: 'description',
      domainId: 'domain_id',
      downloadUrl: 'download_url',
      driveId: 'drive_id',
      encryptMode: 'encrypt_mode',
      fileExtension: 'file_extension',
      fileId: 'file_id',
      hidden: 'hidden',
      imageMediaMetadata: 'image_media_metadata',
      labels: 'labels',
      meta: 'meta',
      name: 'name',
      parentFileId: 'parent_file_id',
      size: 'size',
      starred: 'starred',
      status: 'status',
      streamsUrlInfo: 'streams_url_info',
      thumbnail: 'thumbnail',
      trashedAt: 'trashed_at',
      type: 'type',
      updatedAt: 'updated_at',
      uploadId: 'upload_id',
      url: 'url',
      userMeta: 'user_meta',
      videoMediaMetadata: 'video_media_metadata',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      contentHash: 'string',
      contentHashName: 'string',
      contentType: 'string',
      crc64Hash: 'string',
      createdAt: 'string',
      description: 'string',
      domainId: 'string',
      downloadUrl: 'string',
      driveId: 'string',
      encryptMode: 'string',
      fileExtension: 'string',
      fileId: 'string',
      hidden: 'boolean',
      imageMediaMetadata: ImageMediaResponse,
      labels: { 'type': 'array', 'itemType': 'string' },
      meta: 'string',
      name: 'string',
      parentFileId: 'string',
      size: 'number',
      starred: 'boolean',
      status: 'string',
      streamsUrlInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
      userMeta: 'string',
      videoMediaMetadata: VideoMediaResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Base drive response
 */
export class BaseDriveResponse extends $tea.Model {
  creator?: string;
  description?: string;
  domainId?: string;
  driveId?: string;
  driveName?: string;
  driveType?: string;
  encryptDataAccess?: boolean;
  encryptMode?: string;
  owner?: string;
  relativePath?: string;
  status?: string;
  storeId?: string;
  totalSize?: number;
  usedSize?: number;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      description: 'description',
      domainId: 'domain_id',
      driveId: 'drive_id',
      driveName: 'drive_name',
      driveType: 'drive_type',
      encryptDataAccess: 'encrypt_data_access',
      encryptMode: 'encrypt_mode',
      owner: 'owner',
      relativePath: 'relative_path',
      status: 'status',
      storeId: 'store_id',
      totalSize: 'total_size',
      usedSize: 'used_size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      description: 'string',
      domainId: 'string',
      driveId: 'string',
      driveName: 'string',
      driveType: 'string',
      encryptDataAccess: 'boolean',
      encryptMode: 'string',
      owner: 'string',
      relativePath: 'string',
      status: 'string',
      storeId: 'string',
      totalSize: 'number',
      usedSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Base file response
 */
export class BaseOSSFileResponse extends $tea.Model {
  contentHash?: string;
  contentHashName?: string;
  contentType?: string;
  crc64Hash?: string;
  createdAt?: string;
  description?: string;
  domainId?: string;
  downloadUrl?: string;
  driveId?: string;
  fileExtension?: string;
  filePath?: string;
  name: string;
  parentFilePath?: string;
  shareId?: string;
  size?: number;
  status?: string;
  thumbnail?: string;
  trashedAt?: string;
  type?: string;
  updatedAt?: string;
  uploadId?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentType: 'content_type',
      crc64Hash: 'crc64_hash',
      createdAt: 'created_at',
      description: 'description',
      domainId: 'domain_id',
      downloadUrl: 'download_url',
      driveId: 'drive_id',
      fileExtension: 'file_extension',
      filePath: 'file_path',
      name: 'name',
      parentFilePath: 'parent_file_path',
      shareId: 'share_id',
      size: 'size',
      status: 'status',
      thumbnail: 'thumbnail',
      trashedAt: 'trashed_at',
      type: 'type',
      updatedAt: 'updated_at',
      uploadId: 'upload_id',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentHash: 'string',
      contentHashName: 'string',
      contentType: 'string',
      crc64Hash: 'string',
      createdAt: 'string',
      description: 'string',
      domainId: 'string',
      downloadUrl: 'string',
      driveId: 'string',
      fileExtension: 'string',
      filePath: 'string',
      name: 'string',
      parentFilePath: 'string',
      shareId: 'string',
      size: 'number',
      status: 'string',
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List share response
 */
export class BaseShareResponse extends $tea.Model {
  createdAt?: string;
  creator?: string;
  description?: string;
  domainId?: string;
  driveId?: string;
  expiration?: string;
  expired?: boolean;
  owner?: string;
  permissions?: string[];
  shareFilePath?: string;
  shareId?: string;
  shareName?: string;
  sharePolicy?: SharePermissionPolicy[];
  status?: string;
  updatedAt?: string;
  static names(): { [key: string]: string } {
    return {
      createdAt: 'created_at',
      creator: 'creator',
      description: 'description',
      domainId: 'domain_id',
      driveId: 'drive_id',
      expiration: 'expiration',
      expired: 'expired',
      owner: 'owner',
      permissions: 'permissions',
      shareFilePath: 'share_file_path',
      shareId: 'share_id',
      shareName: 'share_name',
      sharePolicy: 'share_policy',
      status: 'status',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createdAt: 'string',
      creator: 'string',
      description: 'string',
      domainId: 'string',
      driveId: 'string',
      expiration: 'string',
      expired: 'boolean',
      owner: 'string',
      permissions: { 'type': 'array', 'itemType': 'string' },
      shareFilePath: 'string',
      shareId: 'string',
      shareName: 'string',
      sharePolicy: { 'type': 'array', 'itemType': SharePermissionPolicy },
      status: 'string',
      updatedAt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class BatchSubResponse extends $tea.Model {
  body?: {[key: string]: any};
  id?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      id: 'id',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      id: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * batch operation response
 */
export class CCPBatchResponse extends $tea.Model {
  responses?: BatchSubResponse[];
  static names(): { [key: string]: string } {
    return {
      responses: 'responses',
    };
  }

  static types(): { [key: string]: any } {
    return {
      responses: { 'type': 'array', 'itemType': BatchSubResponse },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * complete file response
 */
export class CCPCompleteFileResponse extends $tea.Model {
  category?: string;
  contentHash?: string;
  contentHashName?: string;
  contentType?: string;
  crc64Hash?: string;
  createdAt?: string;
  description?: string;
  domainId?: string;
  downloadUrl?: string;
  driveId?: string;
  encryptMode?: string;
  fileExtension?: string;
  fileId?: string;
  hidden?: boolean;
  imageMediaMetadata?: ImageMediaResponse;
  labels?: string[];
  meta?: string;
  name?: string;
  parentFileId?: string;
  size?: number;
  starred?: boolean;
  status?: string;
  streamsUrlInfo?: {[key: string]: any};
  thumbnail?: string;
  trashedAt?: string;
  type?: string;
  updatedAt?: string;
  uploadId?: string;
  url?: string;
  userMeta?: string;
  videoMediaMetadata?: VideoMediaResponse;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentType: 'content_type',
      crc64Hash: 'crc64_hash',
      createdAt: 'created_at',
      description: 'description',
      domainId: 'domain_id',
      downloadUrl: 'download_url',
      driveId: 'drive_id',
      encryptMode: 'encrypt_mode',
      fileExtension: 'file_extension',
      fileId: 'file_id',
      hidden: 'hidden',
      imageMediaMetadata: 'image_media_metadata',
      labels: 'labels',
      meta: 'meta',
      name: 'name',
      parentFileId: 'parent_file_id',
      size: 'size',
      starred: 'starred',
      status: 'status',
      streamsUrlInfo: 'streams_url_info',
      thumbnail: 'thumbnail',
      trashedAt: 'trashed_at',
      type: 'type',
      updatedAt: 'updated_at',
      uploadId: 'upload_id',
      url: 'url',
      userMeta: 'user_meta',
      videoMediaMetadata: 'video_media_metadata',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      contentHash: 'string',
      contentHashName: 'string',
      contentType: 'string',
      crc64Hash: 'string',
      createdAt: 'string',
      description: 'string',
      domainId: 'string',
      downloadUrl: 'string',
      driveId: 'string',
      encryptMode: 'string',
      fileExtension: 'string',
      fileId: 'string',
      hidden: 'boolean',
      imageMediaMetadata: ImageMediaResponse,
      labels: { 'type': 'array', 'itemType': 'string' },
      meta: 'string',
      name: 'string',
      parentFileId: 'string',
      size: 'number',
      starred: 'boolean',
      status: 'string',
      streamsUrlInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
      userMeta: 'string',
      videoMediaMetadata: VideoMediaResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 文件拷贝 response
 */
export class CCPCopyFileResponse extends $tea.Model {
  asyncTaskId?: string;
  domainId?: string;
  driveId?: string;
  fileId?: string;
  static names(): { [key: string]: string } {
    return {
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      fileId: 'file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      fileId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Create file response
 */
export class CCPCreateFileResponse extends $tea.Model {
  domainId?: string;
  driveId?: string;
  encryptMode?: string;
  exist?: boolean;
  fileId?: string;
  fileName?: string;
  parentFileId?: string;
  partInfoList?: UploadPartInfo[];
  rapidUpload?: boolean;
  status?: string;
  streamsUploadInfo?: {[key: string]: any};
  type?: string;
  uploadId?: string;
  static names(): { [key: string]: string } {
    return {
      domainId: 'domain_id',
      driveId: 'drive_id',
      encryptMode: 'encrypt_mode',
      exist: 'exist',
      fileId: 'file_id',
      fileName: 'file_name',
      parentFileId: 'parent_file_id',
      partInfoList: 'part_info_list',
      rapidUpload: 'rapid_upload',
      status: 'status',
      streamsUploadInfo: 'streams_upload_info',
      type: 'type',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domainId: 'string',
      driveId: 'string',
      encryptMode: 'string',
      exist: 'boolean',
      fileId: 'string',
      fileName: 'string',
      parentFileId: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      rapidUpload: 'boolean',
      status: 'string',
      streamsUploadInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 删除文件 response
 */
export class CCPDeleteFileResponse extends $tea.Model {
  asyncTaskId?: string;
  domainId?: string;
  driveId?: string;
  fileId?: string;
  static names(): { [key: string]: string } {
    return {
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      fileId: 'file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      fileId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 批量删除文件 response
 */
export class CCPDeleteFilesResponse extends $tea.Model {
  deletedFileIdList?: string[];
  domainId?: string;
  driveId?: string;
  static names(): { [key: string]: string } {
    return {
      deletedFileIdList: 'deleted_file_id_list',
      domainId: 'domain_id',
      driveId: 'drive_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deletedFileIdList: { 'type': 'array', 'itemType': 'string' },
      domainId: 'string',
      driveId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Get AsyncTask Response
 */
export class CCPGetAsyncTaskResponse extends $tea.Model {
  asyncTaskId?: string;
  message?: string;
  state?: string;
  static names(): { [key: string]: string } {
    return {
      asyncTaskId: 'async_task_id',
      message: 'message',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      asyncTaskId: 'string',
      message: 'string',
      state: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取download url response
 */
export class CCPGetDownloadUrlResponse extends $tea.Model {
  expiration?: string;
  method?: string;
  size?: number;
  streamsUrl?: {[key: string]: any};
  url?: string;
  static names(): { [key: string]: string } {
    return {
      expiration: 'expiration',
      method: 'method',
      size: 'size',
      streamsUrl: 'streams_url',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expiration: 'string',
      method: 'string',
      size: 'number',
      streamsUrl: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 根据路径获取文件元数据response
 */
export class CCPGetFileByPathResponse extends $tea.Model {
  category?: string;
  contentHash?: string;
  contentHashName?: string;
  contentType?: string;
  crc64Hash?: string;
  createdAt?: string;
  description?: string;
  domainId?: string;
  downloadUrl?: string;
  driveId?: string;
  encryptMode?: string;
  fileExtension?: string;
  fileId?: string;
  hidden?: boolean;
  imageMediaMetadata?: ImageMediaResponse;
  labels?: string[];
  meta?: string;
  name?: string;
  parentFileId?: string;
  size?: number;
  starred?: boolean;
  status?: string;
  streamsUrlInfo?: {[key: string]: any};
  thumbnail?: string;
  trashedAt?: string;
  type?: string;
  updatedAt?: string;
  uploadId?: string;
  url?: string;
  userMeta?: string;
  videoMediaMetadata?: VideoMediaResponse;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentType: 'content_type',
      crc64Hash: 'crc64_hash',
      createdAt: 'created_at',
      description: 'description',
      domainId: 'domain_id',
      downloadUrl: 'download_url',
      driveId: 'drive_id',
      encryptMode: 'encrypt_mode',
      fileExtension: 'file_extension',
      fileId: 'file_id',
      hidden: 'hidden',
      imageMediaMetadata: 'image_media_metadata',
      labels: 'labels',
      meta: 'meta',
      name: 'name',
      parentFileId: 'parent_file_id',
      size: 'size',
      starred: 'starred',
      status: 'status',
      streamsUrlInfo: 'streams_url_info',
      thumbnail: 'thumbnail',
      trashedAt: 'trashed_at',
      type: 'type',
      updatedAt: 'updated_at',
      uploadId: 'upload_id',
      url: 'url',
      userMeta: 'user_meta',
      videoMediaMetadata: 'video_media_metadata',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      contentHash: 'string',
      contentHashName: 'string',
      contentType: 'string',
      crc64Hash: 'string',
      createdAt: 'string',
      description: 'string',
      domainId: 'string',
      downloadUrl: 'string',
      driveId: 'string',
      encryptMode: 'string',
      fileExtension: 'string',
      fileId: 'string',
      hidden: 'boolean',
      imageMediaMetadata: ImageMediaResponse,
      labels: { 'type': 'array', 'itemType': 'string' },
      meta: 'string',
      name: 'string',
      parentFileId: 'string',
      size: 'number',
      starred: 'boolean',
      status: 'string',
      streamsUrlInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
      userMeta: 'string',
      videoMediaMetadata: VideoMediaResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件元数据response
 */
export class CCPGetFileResponse extends $tea.Model {
  category?: string;
  contentHash?: string;
  contentHashName?: string;
  contentType?: string;
  crc64Hash?: string;
  createdAt?: string;
  description?: string;
  domainId?: string;
  downloadUrl?: string;
  driveId?: string;
  encryptMode?: string;
  fileExtension?: string;
  fileId?: string;
  hidden?: boolean;
  imageMediaMetadata?: ImageMediaResponse;
  labels?: string[];
  meta?: string;
  name?: string;
  parentFileId?: string;
  size?: number;
  starred?: boolean;
  status?: string;
  streamsUrlInfo?: {[key: string]: any};
  thumbnail?: string;
  trashedAt?: string;
  type?: string;
  updatedAt?: string;
  uploadId?: string;
  url?: string;
  userMeta?: string;
  videoMediaMetadata?: VideoMediaResponse;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentType: 'content_type',
      crc64Hash: 'crc64_hash',
      createdAt: 'created_at',
      description: 'description',
      domainId: 'domain_id',
      downloadUrl: 'download_url',
      driveId: 'drive_id',
      encryptMode: 'encrypt_mode',
      fileExtension: 'file_extension',
      fileId: 'file_id',
      hidden: 'hidden',
      imageMediaMetadata: 'image_media_metadata',
      labels: 'labels',
      meta: 'meta',
      name: 'name',
      parentFileId: 'parent_file_id',
      size: 'size',
      starred: 'starred',
      status: 'status',
      streamsUrlInfo: 'streams_url_info',
      thumbnail: 'thumbnail',
      trashedAt: 'trashed_at',
      type: 'type',
      updatedAt: 'updated_at',
      uploadId: 'upload_id',
      url: 'url',
      userMeta: 'user_meta',
      videoMediaMetadata: 'video_media_metadata',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      contentHash: 'string',
      contentHashName: 'string',
      contentType: 'string',
      crc64Hash: 'string',
      createdAt: 'string',
      description: 'string',
      domainId: 'string',
      downloadUrl: 'string',
      driveId: 'string',
      encryptMode: 'string',
      fileExtension: 'string',
      fileId: 'string',
      hidden: 'boolean',
      imageMediaMetadata: ImageMediaResponse,
      labels: { 'type': 'array', 'itemType': 'string' },
      meta: 'string',
      name: 'string',
      parentFileId: 'string',
      size: 'number',
      starred: 'boolean',
      status: 'string',
      streamsUrlInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
      userMeta: 'string',
      videoMediaMetadata: VideoMediaResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Get UploadUrl Response
 */
export class CCPGetUploadUrlResponse extends $tea.Model {
  createAt?: string;
  domainId?: string;
  driveId?: string;
  fileId?: string;
  partInfoList?: UploadPartInfo[];
  uploadId?: string;
  static names(): { [key: string]: string } {
    return {
      createAt: 'create_at',
      domainId: 'domain_id',
      driveId: 'drive_id',
      fileId: 'file_id',
      partInfoList: 'part_info_list',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createAt: 'string',
      domainId: 'string',
      driveId: 'string',
      fileId: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List file response
 */
export class CCPListFileResponse extends $tea.Model {
  items?: BaseCCPFileResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': BaseCCPFileResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取签名 response
 */
export class CCPListUploadedPartResponse extends $tea.Model {
  fileId?: string;
  nextPartNumberMarker?: string;
  uploadId?: string;
  uploadedParts?: UploadPartInfo[];
  static names(): { [key: string]: string } {
    return {
      fileId: 'file_id',
      nextPartNumberMarker: 'next_part_number_marker',
      uploadId: 'upload_id',
      uploadedParts: 'uploaded_parts',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      nextPartNumberMarker: 'string',
      uploadId: 'string',
      uploadedParts: { 'type': 'array', 'itemType': UploadPartInfo },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 文件移动 response
 */
export class CCPMoveFileResponse extends $tea.Model {
  asyncTaskId?: string;
  domainId?: string;
  driveId?: string;
  fileId?: string;
  static names(): { [key: string]: string } {
    return {
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      fileId: 'file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      fileId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * scan file meta response
 */
export class CCPScanFileMetaResponse extends $tea.Model {
  items?: BaseCCPFileResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': BaseCCPFileResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * search file response
 */
export class CCPSearchFileResponse extends $tea.Model {
  items?: BaseCCPFileResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': BaseCCPFileResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 更新文件元数据 response
 */
export class CCPUpdateFileMetaResponse extends $tea.Model {
  category?: string;
  contentHash?: string;
  contentHashName?: string;
  contentType?: string;
  crc64Hash?: string;
  createdAt?: string;
  description?: string;
  domainId?: string;
  downloadUrl?: string;
  driveId?: string;
  encryptMode?: string;
  fileExtension?: string;
  fileId?: string;
  hidden?: boolean;
  imageMediaMetadata?: ImageMediaResponse;
  labels?: string[];
  meta?: string;
  name?: string;
  parentFileId?: string;
  size?: number;
  starred?: boolean;
  status?: string;
  streamsUrlInfo?: {[key: string]: any};
  thumbnail?: string;
  trashedAt?: string;
  type?: string;
  updatedAt?: string;
  uploadId?: string;
  url?: string;
  userMeta?: string;
  videoMediaMetadata?: VideoMediaResponse;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentType: 'content_type',
      crc64Hash: 'crc64_hash',
      createdAt: 'created_at',
      description: 'description',
      domainId: 'domain_id',
      downloadUrl: 'download_url',
      driveId: 'drive_id',
      encryptMode: 'encrypt_mode',
      fileExtension: 'file_extension',
      fileId: 'file_id',
      hidden: 'hidden',
      imageMediaMetadata: 'image_media_metadata',
      labels: 'labels',
      meta: 'meta',
      name: 'name',
      parentFileId: 'parent_file_id',
      size: 'size',
      starred: 'starred',
      status: 'status',
      streamsUrlInfo: 'streams_url_info',
      thumbnail: 'thumbnail',
      trashedAt: 'trashed_at',
      type: 'type',
      updatedAt: 'updated_at',
      uploadId: 'upload_id',
      url: 'url',
      userMeta: 'user_meta',
      videoMediaMetadata: 'video_media_metadata',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      contentHash: 'string',
      contentHashName: 'string',
      contentType: 'string',
      crc64Hash: 'string',
      createdAt: 'string',
      description: 'string',
      domainId: 'string',
      downloadUrl: 'string',
      driveId: 'string',
      encryptMode: 'string',
      fileExtension: 'string',
      fileId: 'string',
      hidden: 'boolean',
      imageMediaMetadata: ImageMediaResponse,
      labels: { 'type': 'array', 'itemType': 'string' },
      meta: 'string',
      name: 'string',
      parentFileId: 'string',
      size: 'number',
      starred: 'boolean',
      status: 'string',
      streamsUrlInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
      userMeta: 'string',
      videoMediaMetadata: VideoMediaResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class CancelLinkRequest extends $tea.Model {
  temporaryToken: string;
  static names(): { [key: string]: string } {
    return {
      temporaryToken: 'temporary_token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      temporaryToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class Captcha extends $tea.Model {
  captcha: string;
  captchaFormat: string;
  captchaId: string;
  static names(): { [key: string]: string } {
    return {
      captcha: 'captcha',
      captchaFormat: 'captcha_format',
      captchaId: 'captcha_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      captcha: 'string',
      captchaFormat: 'string',
      captchaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class ConfirmLinkRequest extends $tea.Model {
  temporaryToken: string;
  static names(): { [key: string]: string } {
    return {
      temporaryToken: 'temporary_token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      temporaryToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class CorsRule extends $tea.Model {
  allowedHeader?: string[];
  allowedMethod?: string[];
  allowedOrigin?: string[];
  exposeHeader?: string[];
  maxAgeSeconds?: number;
  static names(): { [key: string]: string } {
    return {
      allowedHeader: 'allowed_header',
      allowedMethod: 'allowed_method',
      allowedOrigin: 'allowed_origin',
      exposeHeader: 'expose_header',
      maxAgeSeconds: 'max_age_seconds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allowedHeader: { 'type': 'array', 'itemType': 'string' },
      allowedMethod: { 'type': 'array', 'itemType': 'string' },
      allowedOrigin: { 'type': 'array', 'itemType': 'string' },
      exposeHeader: { 'type': 'array', 'itemType': 'string' },
      maxAgeSeconds: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Create drive response
 */
export class CreateDriveResponse extends $tea.Model {
  domainId?: string;
  driveId?: string;
  static names(): { [key: string]: string } {
    return {
      domainId: 'domain_id',
      driveId: 'drive_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domainId: 'string',
      driveId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Create share response
 */
export class CreateShareResponse extends $tea.Model {
  domainId?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      domainId: 'domain_id',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domainId: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class DefaultChangePasswordRequest extends $tea.Model {
  appId: string;
  encryptedKey: string;
  newPassword: string;
  phoneNumber: string;
  phoneRegion?: string;
  state: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      encryptedKey: 'encrypted_key',
      newPassword: 'new_password',
      phoneNumber: 'phone_number',
      phoneRegion: 'phone_region',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      encryptedKey: 'string',
      newPassword: 'string',
      phoneNumber: 'string',
      phoneRegion: 'string',
      state: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class DefaultSetPasswordRequest extends $tea.Model {
  appId: string;
  encryptedKey: string;
  newPassword: string;
  state: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      encryptedKey: 'encrypted_key',
      newPassword: 'new_password',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      encryptedKey: 'string',
      newPassword: 'string',
      state: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * delete drive response
 */
export class DeleteDriveResponse extends $tea.Model {
  static names(): { [key: string]: string } {
    return {
    };
  }

  static types(): { [key: string]: any } {
    return {
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class DeviceAuthorizeRequest extends $tea.Model {
  ClientID: string;
  DeviceInfo?: string;
  DeviceName: string;
  LoginType?: string;
  Scope?: string[];
  static names(): { [key: string]: string } {
    return {
      ClientID: 'ClientID',
      DeviceInfo: 'DeviceInfo',
      DeviceName: 'DeviceName',
      LoginType: 'LoginType',
      Scope: 'Scope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ClientID: 'string',
      DeviceInfo: 'string',
      DeviceName: 'string',
      LoginType: 'string',
      Scope: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class GetAccessTokenByLinkInfoRequest extends $tea.Model {
  extra?: string;
  identity: string;
  type: string;
  static names(): { [key: string]: string } {
    return {
      extra: 'extra',
      identity: 'identity',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extra: 'string',
      identity: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class GetAppPublicKeyRequest extends $tea.Model {
  appId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class GetByLinkInfoRequest extends $tea.Model {
  extra?: string;
  identity: string;
  type: string;
  static names(): { [key: string]: string } {
    return {
      extra: 'extra',
      identity: 'identity',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extra: 'string',
      identity: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class GetCaptchaRequest extends $tea.Model {
  appId: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Get drive response
 */
export class GetDriveResponse extends $tea.Model {
  creator?: string;
  description?: string;
  domainId?: string;
  driveId?: string;
  driveName?: string;
  driveType?: string;
  encryptDataAccess?: boolean;
  encryptMode?: string;
  owner?: string;
  relativePath?: string;
  status?: string;
  storeId?: string;
  totalSize?: number;
  usedSize?: number;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      description: 'description',
      domainId: 'domain_id',
      driveId: 'drive_id',
      driveName: 'drive_name',
      driveType: 'drive_type',
      encryptDataAccess: 'encrypt_data_access',
      encryptMode: 'encrypt_mode',
      owner: 'owner',
      relativePath: 'relative_path',
      status: 'status',
      storeId: 'store_id',
      totalSize: 'total_size',
      usedSize: 'used_size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      description: 'string',
      domainId: 'string',
      driveId: 'string',
      driveName: 'string',
      driveType: 'string',
      encryptDataAccess: 'boolean',
      encryptMode: 'string',
      owner: 'string',
      relativePath: 'string',
      status: 'string',
      storeId: 'string',
      totalSize: 'number',
      usedSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class GetLinkInfoByUserIDRequest extends $tea.Model {
  userId: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class GetPublicKeyResponse extends $tea.Model {
  appId: string;
  keyPairId?: string;
  publicKey: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      keyPairId: 'key_pair_id',
      publicKey: 'public_key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      keyPairId: 'string',
      publicKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Get share response
 */
export class GetShareResponse extends $tea.Model {
  createdAt?: string;
  creator?: string;
  description?: string;
  domainId?: string;
  driveId?: string;
  expiration?: string;
  expired?: boolean;
  owner?: string;
  permissions?: string[];
  shareFilePath?: string;
  shareId?: string;
  shareName?: string;
  sharePolicy?: SharePermissionPolicy[];
  status?: string;
  updatedAt?: string;
  static names(): { [key: string]: string } {
    return {
      createdAt: 'created_at',
      creator: 'creator',
      description: 'description',
      domainId: 'domain_id',
      driveId: 'drive_id',
      expiration: 'expiration',
      expired: 'expired',
      owner: 'owner',
      permissions: 'permissions',
      shareFilePath: 'share_file_path',
      shareId: 'share_id',
      shareName: 'share_name',
      sharePolicy: 'share_policy',
      status: 'status',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createdAt: 'string',
      creator: 'string',
      description: 'string',
      domainId: 'string',
      driveId: 'string',
      expiration: 'string',
      expired: 'boolean',
      owner: 'string',
      permissions: { 'type': 'array', 'itemType': 'string' },
      shareFilePath: 'string',
      shareId: 'string',
      shareName: 'string',
      sharePolicy: { 'type': 'array', 'itemType': SharePermissionPolicy },
      status: 'string',
      updatedAt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class ImageMediaResponse extends $tea.Model {
  addressLine?: string;
  city?: string;
  country?: string;
  district?: string;
  exif?: string;
  faces?: string;
  height?: number;
  location?: string;
  province?: string;
  time?: string;
  township?: string;
  width?: number;
  static names(): { [key: string]: string } {
    return {
      addressLine: 'address_line',
      city: 'city',
      country: 'country',
      district: 'district',
      exif: 'exif',
      faces: 'faces',
      height: 'height',
      location: 'location',
      province: 'province',
      time: 'time',
      township: 'township',
      width: 'width',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addressLine: 'string',
      city: 'string',
      country: 'string',
      district: 'string',
      exif: 'string',
      faces: 'string',
      height: 'number',
      location: 'string',
      province: 'string',
      time: 'string',
      township: 'string',
      width: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class InnerConsentRequest extends $tea.Model {
  UserCode?: string;
  static names(): { [key: string]: string } {
    return {
      UserCode: 'UserCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      UserCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class InnerSignInRequest extends $tea.Model {
  keyPairId?: string;
  password?: string;
  phoneNumber?: string;
  phoneRegion?: string;
  signInType?: string;
  smsCode?: string;
  smsCodeId?: string;
  static names(): { [key: string]: string } {
    return {
      keyPairId: 'key_pair_id',
      password: 'password',
      phoneNumber: 'phone_number',
      phoneRegion: 'phone_region',
      signInType: 'sign_in_type',
      smsCode: 'sms_code',
      smsCodeId: 'sms_code_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyPairId: 'string',
      password: 'string',
      phoneNumber: 'string',
      phoneRegion: 'string',
      signInType: 'string',
      smsCode: 'string',
      smsCodeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class InnerSignInResponse extends $tea.Model {
  goto?: string;
  static names(): { [key: string]: string } {
    return {
      goto: 'goto',
    };
  }

  static types(): { [key: string]: any } {
    return {
      goto: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class InnerUserCodeAuthorizeRequest extends $tea.Model {
  UserCode?: string;
  static names(): { [key: string]: string } {
    return {
      UserCode: 'UserCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      UserCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class LinkInfo extends $tea.Model {
  extra?: string;
  identity?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      extra: 'extra',
      identity: 'identity',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extra: 'string',
      identity: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class LinkInfoListResponse extends $tea.Model {
  items: LinkInfoResponse[];
  static names(): { [key: string]: string } {
    return {
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': LinkInfoResponse },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class LinkInfoResponse extends $tea.Model {
  authenticationType: string;
  createdAt: number;
  domainId: string;
  extra?: string;
  identity: string;
  lastLoginTime: number;
  status: string;
  userId: string;
  static names(): { [key: string]: string } {
    return {
      authenticationType: 'authentication_type',
      createdAt: 'created_at',
      domainId: 'domain_id',
      extra: 'extra',
      identity: 'identity',
      lastLoginTime: 'last_login_time',
      status: 'status',
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authenticationType: 'string',
      createdAt: 'number',
      domainId: 'string',
      extra: 'string',
      identity: 'string',
      lastLoginTime: 'number',
      status: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * list drive response
 */
export class ListDriveResponse extends $tea.Model {
  items?: BaseDriveResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': BaseDriveResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List share response
 */
export class ListShareResponse extends $tea.Model {
  items?: BaseShareResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': BaseShareResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List storage file
 */
export class ListStoreFileResponse extends $tea.Model {
  items?: StoreFile[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': StoreFile },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List storage
 */
export class ListStoreResponse extends $tea.Model {
  items?: StoreItemResponse[];
  static names(): { [key: string]: string } {
    return {
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': StoreItemResponse },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class LoginByCodeRequest extends $tea.Model {
  accessToken?: string;
  appId: string;
  authCode?: string;
  type: string;
  static names(): { [key: string]: string } {
    return {
      accessToken: 'access_token',
      appId: 'app_id',
      authCode: 'auth_code',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessToken: 'string',
      appId: 'string',
      authCode: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class MobileCheckExistRequest extends $tea.Model {
  appId: string;
  phoneNumber: string;
  phoneRegion?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      phoneNumber: 'phone_number',
      phoneRegion: 'phone_region',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      phoneNumber: 'string',
      phoneRegion: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class MobileCheckExistResponse extends $tea.Model {
  isExist: boolean;
  phoneNumber: string;
  phoneRegion?: string;
  static names(): { [key: string]: string } {
    return {
      isExist: 'is_exist',
      phoneNumber: 'phone_number',
      phoneRegion: 'phone_region',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isExist: 'boolean',
      phoneNumber: 'string',
      phoneRegion: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class MobileLoginRequest extends $tea.Model {
  appId: string;
  autoRegister?: boolean;
  captchaId?: string;
  captchaText?: string;
  encryptedKey?: string;
  password?: string;
  phoneNumber: string;
  phoneRegion?: string;
  smsCode?: string;
  smsCodeId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      autoRegister: 'auto_register',
      captchaId: 'captcha_id',
      captchaText: 'captcha_text',
      encryptedKey: 'encrypted_key',
      password: 'password',
      phoneNumber: 'phone_number',
      phoneRegion: 'phone_region',
      smsCode: 'sms_code',
      smsCodeId: 'sms_code_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      autoRegister: 'boolean',
      captchaId: 'string',
      captchaText: 'string',
      encryptedKey: 'string',
      password: 'string',
      phoneNumber: 'string',
      phoneRegion: 'string',
      smsCode: 'string',
      smsCodeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class MobileRegisterRequest extends $tea.Model {
  appId: string;
  phoneNumber: string;
  phoneRegion?: string;
  smsCode: string;
  smsCodeId: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      phoneNumber: 'phone_number',
      phoneRegion: 'phone_region',
      smsCode: 'sms_code',
      smsCodeId: 'sms_code_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      phoneNumber: 'string',
      phoneRegion: 'string',
      smsCode: 'string',
      smsCodeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class MobileSendSmsCodeRequest extends $tea.Model {
  appId: string;
  captchaId?: string;
  captchaText?: string;
  phoneNumber: string;
  phoneRegion?: string;
  type: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      captchaId: 'captcha_id',
      captchaText: 'captcha_text',
      phoneNumber: 'phone_number',
      phoneRegion: 'phone_region',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      captchaId: 'string',
      captchaText: 'string',
      phoneNumber: 'string',
      phoneRegion: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class MobileSendSmsCodeResponse extends $tea.Model {
  smsCodeId: string;
  static names(): { [key: string]: string } {
    return {
      smsCodeId: 'sms_code_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      smsCodeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * complete file response
 */
export class OSSCompleteFileResponse extends $tea.Model {
  contentHash?: string;
  contentHashName?: string;
  contentType?: string;
  crc64Hash?: string;
  createdAt?: string;
  description?: string;
  domainId?: string;
  downloadUrl?: string;
  driveId?: string;
  fileExtension?: string;
  filePath?: string;
  name?: string;
  parentFilePath?: string;
  shareId?: string;
  size?: number;
  status?: string;
  thumbnail?: string;
  trashedAt?: string;
  type?: string;
  updatedAt?: string;
  uploadId?: string;
  url?: string;
  crc?: string;
  static names(): { [key: string]: string } {
    return {
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentType: 'content_type',
      crc64Hash: 'crc64_hash',
      createdAt: 'created_at',
      description: 'description',
      domainId: 'domain_id',
      downloadUrl: 'download_url',
      driveId: 'drive_id',
      fileExtension: 'file_extension',
      filePath: 'file_path',
      name: 'name',
      parentFilePath: 'parent_file_path',
      shareId: 'share_id',
      size: 'size',
      status: 'status',
      thumbnail: 'thumbnail',
      trashedAt: 'trashed_at',
      type: 'type',
      updatedAt: 'updated_at',
      uploadId: 'upload_id',
      url: 'url',
      crc: 'crc',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentHash: 'string',
      contentHashName: 'string',
      contentType: 'string',
      crc64Hash: 'string',
      createdAt: 'string',
      description: 'string',
      domainId: 'string',
      downloadUrl: 'string',
      driveId: 'string',
      fileExtension: 'string',
      filePath: 'string',
      name: 'string',
      parentFilePath: 'string',
      shareId: 'string',
      size: 'number',
      status: 'string',
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
      crc: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 文件拷贝 response
 */
export class OSSCopyFileResponse extends $tea.Model {
  asyncTaskId?: string;
  domainId?: string;
  driveId?: string;
  filePath?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Create file response
 */
export class OSSCreateFileResponse extends $tea.Model {
  domainId?: string;
  driveId?: string;
  filePath?: string;
  partInfoList?: UploadPartInfo[];
  shareId?: string;
  type?: string;
  uploadId?: string;
  static names(): { [key: string]: string } {
    return {
      domainId: 'domain_id',
      driveId: 'drive_id',
      filePath: 'file_path',
      partInfoList: 'part_info_list',
      shareId: 'share_id',
      type: 'type',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domainId: 'string',
      driveId: 'string',
      filePath: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      shareId: 'string',
      type: 'string',
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 删除文件 response
 */
export class OSSDeleteFileResponse extends $tea.Model {
  asyncTaskId?: string;
  domainId?: string;
  driveId?: string;
  filePath?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 批量删除文件 response
 */
export class OSSDeleteFilesResponse extends $tea.Model {
  deletedFileIdList?: string[];
  domainId?: string;
  driveId?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      deletedFileIdList: 'deleted_file_id_list',
      domainId: 'domain_id',
      driveId: 'drive_id',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deletedFileIdList: { 'type': 'array', 'itemType': 'string' },
      domainId: 'string',
      driveId: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取download url response
 */
export class OSSGetDownloadUrlResponse extends $tea.Model {
  expiration?: string;
  method?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      expiration: 'expiration',
      method: 'method',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expiration: 'string',
      method: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件元数据response
 */
export class OSSGetFileResponse extends $tea.Model {
  contentHash?: string;
  contentHashName?: string;
  contentType?: string;
  crc64Hash?: string;
  createdAt?: string;
  description?: string;
  domainId?: string;
  downloadUrl?: string;
  driveId?: string;
  fileExtension?: string;
  filePath?: string;
  name?: string;
  parentFilePath?: string;
  shareId?: string;
  size?: number;
  status?: string;
  thumbnail?: string;
  trashedAt?: string;
  type?: string;
  updatedAt?: string;
  uploadId?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentType: 'content_type',
      crc64Hash: 'crc64_hash',
      createdAt: 'created_at',
      description: 'description',
      domainId: 'domain_id',
      downloadUrl: 'download_url',
      driveId: 'drive_id',
      fileExtension: 'file_extension',
      filePath: 'file_path',
      name: 'name',
      parentFilePath: 'parent_file_path',
      shareId: 'share_id',
      size: 'size',
      status: 'status',
      thumbnail: 'thumbnail',
      trashedAt: 'trashed_at',
      type: 'type',
      updatedAt: 'updated_at',
      uploadId: 'upload_id',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentHash: 'string',
      contentHashName: 'string',
      contentType: 'string',
      crc64Hash: 'string',
      createdAt: 'string',
      description: 'string',
      domainId: 'string',
      downloadUrl: 'string',
      driveId: 'string',
      fileExtension: 'string',
      filePath: 'string',
      name: 'string',
      parentFilePath: 'string',
      shareId: 'string',
      size: 'number',
      status: 'string',
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取secure url response
 */
export class OSSGetSecureUrlResponse extends $tea.Model {
  expiration?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      expiration: 'expiration',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expiration: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Get UploadUrl Response
 */
export class OSSGetUploadUrlResponse extends $tea.Model {
  createAt?: string;
  domainId?: string;
  driveId?: string;
  filePath?: string;
  partInfoList?: UploadPartInfo[];
  uploadId?: string;
  static names(): { [key: string]: string } {
    return {
      createAt: 'create_at',
      domainId: 'domain_id',
      driveId: 'drive_id',
      filePath: 'file_path',
      partInfoList: 'part_info_list',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createAt: 'string',
      domainId: 'string',
      driveId: 'string',
      filePath: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List file response
 */
export class OSSListFileResponse extends $tea.Model {
  items?: BaseOSSFileResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': BaseOSSFileResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取签名 response
 */
export class OSSListUploadedPartResponse extends $tea.Model {
  filePath?: string;
  nextPartNumberMarker?: string;
  uploadId?: string;
  uploadedParts?: UploadPartInfo[];
  static names(): { [key: string]: string } {
    return {
      filePath: 'file_path',
      nextPartNumberMarker: 'next_part_number_marker',
      uploadId: 'upload_id',
      uploadedParts: 'uploaded_parts',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filePath: 'string',
      nextPartNumberMarker: 'string',
      uploadId: 'string',
      uploadedParts: { 'type': 'array', 'itemType': UploadPartInfo },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 文件移动 response
 */
export class OSSMoveFileResponse extends $tea.Model {
  asyncTaskId?: string;
  domainId?: string;
  driveId?: string;
  filePath?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * search file response
 */
export class OSSSearchFileResponse extends $tea.Model {
  items?: BaseOSSFileResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': BaseOSSFileResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 更新文件元数据 response
 */
export class OSSUpdateFileMetaResponse extends $tea.Model {
  contentHash?: string;
  contentHashName?: string;
  contentType?: string;
  crc64Hash?: string;
  createdAt?: string;
  description?: string;
  domainId?: string;
  downloadUrl?: string;
  driveId?: string;
  fileExtension?: string;
  filePath?: string;
  name?: string;
  parentFilePath?: string;
  shareId?: string;
  size?: number;
  status?: string;
  thumbnail?: string;
  trashedAt?: string;
  type?: string;
  updatedAt?: string;
  uploadId?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentType: 'content_type',
      crc64Hash: 'crc64_hash',
      createdAt: 'created_at',
      description: 'description',
      domainId: 'domain_id',
      downloadUrl: 'download_url',
      driveId: 'drive_id',
      fileExtension: 'file_extension',
      filePath: 'file_path',
      name: 'name',
      parentFilePath: 'parent_file_path',
      shareId: 'share_id',
      size: 'size',
      status: 'status',
      thumbnail: 'thumbnail',
      trashedAt: 'trashed_at',
      type: 'type',
      updatedAt: 'updated_at',
      uploadId: 'upload_id',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentHash: 'string',
      contentHashName: 'string',
      contentType: 'string',
      crc64Hash: 'string',
      createdAt: 'string',
      description: 'string',
      domainId: 'string',
      downloadUrl: 'string',
      driveId: 'string',
      fileExtension: 'string',
      filePath: 'string',
      name: 'string',
      parentFilePath: 'string',
      shareId: 'string',
      size: 'number',
      status: 'string',
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 转码接口response
 */
export class OSSVideoDefinitionResponse extends $tea.Model {
  definitionList?: string[];
  static names(): { [key: string]: string } {
    return {
      definitionList: 'definition_list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      definitionList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 转码接口response
 */
export class OSSVideoTranscodeResponse extends $tea.Model {
  definitionList?: string[];
  duration?: number;
  hlsTime?: number;
  static names(): { [key: string]: string } {
    return {
      definitionList: 'definition_list',
      duration: 'duration',
      hlsTime: 'hls_time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      definitionList: { 'type': 'array', 'itemType': 'string' },
      duration: 'number',
      hlsTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Pre hash check Response
 */
export class PreHashCheckSuccessResponse extends $tea.Model {
  code?: string;
  fileName?: string;
  message?: string;
  parentFileId: string;
  preHash?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      fileName: 'file_name',
      message: 'message',
      parentFileId: 'parent_file_id',
      preHash: 'pre_hash',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      fileName: 'string',
      message: 'string',
      parentFileId: 'string',
      preHash: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class RevokeRequest extends $tea.Model {
  appId: string;
  refreshToken: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      refreshToken: 'refresh_token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      refreshToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class SharePermissionPolicy extends $tea.Model {
  filePath?: string;
  permissionInheritable?: boolean;
  permissionList?: string[];
  permissionType?: string;
  static names(): { [key: string]: string } {
    return {
      filePath: 'file_path',
      permissionInheritable: 'permission_inheritable',
      permissionList: 'permission_list',
      permissionType: 'permission_type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      filePath: 'string',
      permissionInheritable: 'boolean',
      permissionList: { 'type': 'array', 'itemType': 'string' },
      permissionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class StoreFile extends $tea.Model {
  domainId?: string;
  name?: string;
  parentFilePath?: string;
  storeId?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      domainId: 'domain_id',
      name: 'name',
      parentFilePath: 'parent_file_path',
      storeId: 'store_id',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domainId: 'string',
      name: 'string',
      parentFilePath: 'string',
      storeId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class StoreItemResponse extends $tea.Model {
  accelerateEndpoint?: string;
  basePath?: string;
  bucket: string;
  customizedEndpoint?: string;
  domainId?: string;
  endpoint: string;
  internalEndpoint?: string;
  ownership: string;
  policy: string;
  roleArn?: string;
  storeId: string;
  type: string;
  static names(): { [key: string]: string } {
    return {
      accelerateEndpoint: 'accelerate_endpoint',
      basePath: 'base_path',
      bucket: 'bucket',
      customizedEndpoint: 'customized_endpoint',
      domainId: 'domain_id',
      endpoint: 'endpoint',
      internalEndpoint: 'internal_endpoint',
      ownership: 'ownership',
      policy: 'policy',
      roleArn: 'role_arn',
      storeId: 'store_id',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accelerateEndpoint: 'string',
      basePath: 'string',
      bucket: 'string',
      customizedEndpoint: 'string',
      domainId: 'string',
      endpoint: 'string',
      internalEndpoint: 'string',
      ownership: 'string',
      policy: 'string',
      roleArn: 'string',
      storeId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class StreamUploadInfo extends $tea.Model {
  partInfoList?: UploadPartInfo[];
  preRapidUpload?: boolean;
  rapidUpload?: boolean;
  uploadId?: string;
  static names(): { [key: string]: string } {
    return {
      partInfoList: 'part_info_list',
      preRapidUpload: 'pre_rapid_upload',
      rapidUpload: 'rapid_upload',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      preRapidUpload: 'boolean',
      rapidUpload: 'boolean',
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class TokenRequest extends $tea.Model {
  appId: string;
  grantType: string;
  refreshToken: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      grantType: 'grant_type',
      refreshToken: 'refresh_token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      grantType: 'string',
      refreshToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Update drive response
 */
export class UpdateDriveResponse extends $tea.Model {
  creator?: string;
  description?: string;
  domainId?: string;
  driveId?: string;
  driveName?: string;
  driveType?: string;
  encryptDataAccess?: boolean;
  encryptMode?: string;
  owner?: string;
  relativePath?: string;
  status?: string;
  storeId?: string;
  totalSize?: number;
  usedSize?: number;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      description: 'description',
      domainId: 'domain_id',
      driveId: 'drive_id',
      driveName: 'drive_name',
      driveType: 'drive_type',
      encryptDataAccess: 'encrypt_data_access',
      encryptMode: 'encrypt_mode',
      owner: 'owner',
      relativePath: 'relative_path',
      status: 'status',
      storeId: 'store_id',
      totalSize: 'total_size',
      usedSize: 'used_size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      description: 'string',
      domainId: 'string',
      driveId: 'string',
      driveName: 'string',
      driveType: 'string',
      encryptDataAccess: 'boolean',
      encryptMode: 'string',
      owner: 'string',
      relativePath: 'string',
      status: 'string',
      storeId: 'string',
      totalSize: 'number',
      usedSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Update share response
 */
export class UpdateShareResponse extends $tea.Model {
  createdAt?: string;
  creator?: string;
  description?: string;
  domainId?: string;
  driveId?: string;
  expiration?: string;
  expired?: boolean;
  owner?: string;
  permissions?: string[];
  shareFilePath?: string;
  shareId?: string;
  shareName?: string;
  sharePolicy?: SharePermissionPolicy[];
  status?: string;
  updatedAt?: string;
  static names(): { [key: string]: string } {
    return {
      createdAt: 'created_at',
      creator: 'creator',
      description: 'description',
      domainId: 'domain_id',
      driveId: 'drive_id',
      expiration: 'expiration',
      expired: 'expired',
      owner: 'owner',
      permissions: 'permissions',
      shareFilePath: 'share_file_path',
      shareId: 'share_id',
      shareName: 'share_name',
      sharePolicy: 'share_policy',
      status: 'status',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createdAt: 'string',
      creator: 'string',
      description: 'string',
      domainId: 'string',
      driveId: 'string',
      expiration: 'string',
      expired: 'boolean',
      owner: 'string',
      permissions: { 'type': 'array', 'itemType': 'string' },
      shareFilePath: 'string',
      shareId: 'string',
      shareName: 'string',
      sharePolicy: { 'type': 'array', 'itemType': SharePermissionPolicy },
      status: 'string',
      updatedAt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class UploadPartInfo extends $tea.Model {
  etag?: string;
  partNumber?: number;
  partSize?: number;
  uploadUrl?: string;
  static names(): { [key: string]: string } {
    return {
      etag: 'etag',
      partNumber: 'part_number',
      partSize: 'part_size',
      uploadUrl: 'upload_url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      etag: 'string',
      partNumber: 'number',
      partSize: 'number',
      uploadUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class UrlInfo extends $tea.Model {
  downloadUrl?: string;
  thumbnail?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      downloadUrl: 'download_url',
      thumbnail: 'thumbnail',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadUrl: 'string',
      thumbnail: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class UserAuthentication extends $tea.Model {
  AuthenticationType: string;
  CreatedAt: number;
  Detail: string;
  DomainID: string;
  Identity: string;
  LastLoginTime: number;
  Status: string;
  UserID: string;
  extra?: string;
  static names(): { [key: string]: string } {
    return {
      AuthenticationType: 'AuthenticationType',
      CreatedAt: 'CreatedAt',
      Detail: 'Detail',
      DomainID: 'DomainID',
      Identity: 'Identity',
      LastLoginTime: 'LastLoginTime',
      Status: 'Status',
      UserID: 'UserID',
      extra: 'extra',
    };
  }

  static types(): { [key: string]: any } {
    return {
      AuthenticationType: 'string',
      CreatedAt: 'number',
      Detail: 'string',
      DomainID: 'string',
      Identity: 'string',
      LastLoginTime: 'number',
      Status: 'string',
      UserID: 'string',
      extra: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class VerifyCodeRequest extends $tea.Model {
  appId: string;
  phoneNumber: string;
  phoneRegion?: string;
  smsCode: string;
  smsCodeId: string;
  verifyType?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      phoneNumber: 'phone_number',
      phoneRegion: 'phone_region',
      smsCode: 'sms_code',
      smsCodeId: 'sms_code_id',
      verifyType: 'verify_type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      phoneNumber: 'string',
      phoneRegion: 'string',
      smsCode: 'string',
      smsCodeId: 'string',
      verifyType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class VerifyCodeResponse extends $tea.Model {
  state: string;
  static names(): { [key: string]: string } {
    return {
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      state: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class VideoMediaResponse extends $tea.Model {
  addressLine?: string;
  city?: string;
  country?: string;
  district?: string;
  duration?: string;
  location?: string;
  province?: string;
  time?: string;
  township?: string;
  static names(): { [key: string]: string } {
    return {
      addressLine: 'address_line',
      city: 'city',
      country: 'country',
      district: 'district',
      duration: 'duration',
      location: 'location',
      province: 'province',
      time: 'time',
      township: 'township',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addressLine: 'string',
      city: 'string',
      country: 'string',
      district: 'string',
      duration: 'string',
      location: 'string',
      province: 'string',
      time: 'string',
      township: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AdminListStoresRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AdminListStoresRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AdminListStoresRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AdminListStoresModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListStoresResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListStoresResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAccessTokenRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetUserAccessTokenRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserAccessTokenRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAccessTokenModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: AccessTokenResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AccessTokenResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class AddStoreResponse extends $tea.Model {
  accelerateEndpoint?: string;
  basePath?: string;
  bucket: string;
  customizedEndpoint?: string;
  domainId: string;
  endpoint: string;
  internalEndpoint?: string;
  ownership: string;
  policy: string;
  roleArn?: string;
  storeId: string;
  type: string;
  static names(): { [key: string]: string } {
    return {
      accelerateEndpoint: 'accelerate_endpoint',
      basePath: 'base_path',
      bucket: 'bucket',
      customizedEndpoint: 'customized_endpoint',
      domainId: 'domain_id',
      endpoint: 'endpoint',
      internalEndpoint: 'internal_endpoint',
      ownership: 'ownership',
      policy: 'policy',
      roleArn: 'role_arn',
      storeId: 'store_id',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accelerateEndpoint: 'string',
      basePath: 'string',
      bucket: 'string',
      customizedEndpoint: 'string',
      domainId: 'string',
      endpoint: 'string',
      internalEndpoint: 'string',
      ownership: 'string',
      policy: 'string',
      roleArn: 'string',
      storeId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class AdminListStoresRequest extends $tea.Model {
  static names(): { [key: string]: string } {
    return {
    };
  }

  static types(): { [key: string]: any } {
    return {
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class AppAccessStrategy extends $tea.Model {
  effect?: string;
  exceptAppIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      effect: 'effect',
      exceptAppIdList: 'except_app_id_list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      effect: 'string',
      exceptAppIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class AuthConfig extends $tea.Model {
  appId?: string;
  appSecret?: string;
  callbackSecurity?: boolean;
  enable?: boolean;
  endpoint?: string;
  enterpriseId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      appSecret: 'app_secret',
      callbackSecurity: 'callback_security',
      enable: 'enable',
      endpoint: 'endpoint',
      enterpriseId: 'enterprise_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      appSecret: 'string',
      callbackSecurity: 'boolean',
      enable: 'boolean',
      endpoint: 'string',
      enterpriseId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * base domain response
 */
export class BaseDomainResponse extends $tea.Model {
  authAlipayAppId?: string;
  authAlipayEnable?: boolean;
  authAlipayPrivateKey?: string;
  authConfig?: {[key: string]: any};
  authDingdingAppId?: string;
  authDingdingAppSecret?: string;
  authDingdingEnable?: boolean;
  authEndpointEnable?: boolean;
  authRamAppId?: string;
  authRamAppSecret?: string;
  authRamEnable?: boolean;
  createdAt?: string;
  dataHashName?: string;
  description?: string;
  domainId?: string;
  domainName?: string;
  eventFilenameMatches?: string;
  eventMnsEndpoint?: string;
  eventMnsTopic?: string;
  eventNames?: string[];
  eventRoleArn?: string;
  initDriveEnable?: boolean;
  initDriveSize?: number;
  initDriveStoreId?: string;
  pathType?: string;
  publishedAppAccessStrategy?: AppAccessStrategy;
  sharable?: boolean;
  storeLevel?: string;
  storeRegionList?: string[];
  updatedAt?: string;
  static names(): { [key: string]: string } {
    return {
      authAlipayAppId: 'auth_alipay_app_id',
      authAlipayEnable: 'auth_alipay_enable',
      authAlipayPrivateKey: 'auth_alipay_private_key',
      authConfig: 'auth_config',
      authDingdingAppId: 'auth_dingding_app_id',
      authDingdingAppSecret: 'auth_dingding_app_secret',
      authDingdingEnable: 'auth_dingding_enable',
      authEndpointEnable: 'auth_endpoint_enable',
      authRamAppId: 'auth_ram_app_id',
      authRamAppSecret: 'auth_ram_app_secret',
      authRamEnable: 'auth_ram_enable',
      createdAt: 'created_at',
      dataHashName: 'data_hash_name',
      description: 'description',
      domainId: 'domain_id',
      domainName: 'domain_name',
      eventFilenameMatches: 'event_filename_matches',
      eventMnsEndpoint: 'event_mns_endpoint',
      eventMnsTopic: 'event_mns_topic',
      eventNames: 'event_names',
      eventRoleArn: 'event_role_arn',
      initDriveEnable: 'init_drive_enable',
      initDriveSize: 'init_drive_size',
      initDriveStoreId: 'init_drive_store_id',
      pathType: 'path_type',
      publishedAppAccessStrategy: 'published_app_access_strategy',
      sharable: 'sharable',
      storeLevel: 'store_level',
      storeRegionList: 'store_region_list',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authAlipayAppId: 'string',
      authAlipayEnable: 'boolean',
      authAlipayPrivateKey: 'string',
      authConfig: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      authDingdingAppId: 'string',
      authDingdingAppSecret: 'string',
      authDingdingEnable: 'boolean',
      authEndpointEnable: 'boolean',
      authRamAppId: 'string',
      authRamAppSecret: 'string',
      authRamEnable: 'boolean',
      createdAt: 'string',
      dataHashName: 'string',
      description: 'string',
      domainId: 'string',
      domainName: 'string',
      eventFilenameMatches: 'string',
      eventMnsEndpoint: 'string',
      eventMnsTopic: 'string',
      eventNames: { 'type': 'array', 'itemType': 'string' },
      eventRoleArn: 'string',
      initDriveEnable: 'boolean',
      initDriveSize: 'number',
      initDriveStoreId: 'string',
      pathType: 'string',
      publishedAppAccessStrategy: AppAccessStrategy,
      sharable: 'boolean',
      storeLevel: 'string',
      storeRegionList: { 'type': 'array', 'itemType': 'string' },
      updatedAt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class BaseMediaResponse extends $tea.Model {
  addressLine?: string;
  city?: string;
  country?: string;
  district?: string;
  location?: string;
  province?: string;
  time?: string;
  township?: string;
  static names(): { [key: string]: string } {
    return {
      addressLine: 'address_line',
      city: 'city',
      country: 'country',
      district: 'district',
      location: 'location',
      province: 'province',
      time: 'time',
      township: 'township',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addressLine: 'string',
      city: 'string',
      country: 'string',
      district: 'string',
      location: 'string',
      province: 'string',
      time: 'string',
      township: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * create domain response
 */
export class CreateDomainResponse extends $tea.Model {
  authAlipayAppId?: string;
  authAlipayEnable?: boolean;
  authAlipayPrivateKey?: string;
  authConfig?: {[key: string]: any};
  authDingdingAppId?: string;
  authDingdingAppSecret?: string;
  authDingdingEnable?: boolean;
  authEndpointEnable?: boolean;
  authRamAppId?: string;
  authRamAppSecret?: string;
  authRamEnable?: boolean;
  createdAt?: string;
  dataHashName?: string;
  description?: string;
  domainId?: string;
  domainName?: string;
  eventFilenameMatches?: string;
  eventMnsEndpoint?: string;
  eventMnsTopic?: string;
  eventNames?: string[];
  eventRoleArn?: string;
  initDriveEnable?: boolean;
  initDriveSize?: number;
  initDriveStoreId?: string;
  pathType?: string;
  publishedAppAccessStrategy?: AppAccessStrategy;
  sharable?: boolean;
  storeLevel?: string;
  storeRegionList?: string[];
  updatedAt?: string;
  static names(): { [key: string]: string } {
    return {
      authAlipayAppId: 'auth_alipay_app_id',
      authAlipayEnable: 'auth_alipay_enable',
      authAlipayPrivateKey: 'auth_alipay_private_key',
      authConfig: 'auth_config',
      authDingdingAppId: 'auth_dingding_app_id',
      authDingdingAppSecret: 'auth_dingding_app_secret',
      authDingdingEnable: 'auth_dingding_enable',
      authEndpointEnable: 'auth_endpoint_enable',
      authRamAppId: 'auth_ram_app_id',
      authRamAppSecret: 'auth_ram_app_secret',
      authRamEnable: 'auth_ram_enable',
      createdAt: 'created_at',
      dataHashName: 'data_hash_name',
      description: 'description',
      domainId: 'domain_id',
      domainName: 'domain_name',
      eventFilenameMatches: 'event_filename_matches',
      eventMnsEndpoint: 'event_mns_endpoint',
      eventMnsTopic: 'event_mns_topic',
      eventNames: 'event_names',
      eventRoleArn: 'event_role_arn',
      initDriveEnable: 'init_drive_enable',
      initDriveSize: 'init_drive_size',
      initDriveStoreId: 'init_drive_store_id',
      pathType: 'path_type',
      publishedAppAccessStrategy: 'published_app_access_strategy',
      sharable: 'sharable',
      storeLevel: 'store_level',
      storeRegionList: 'store_region_list',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authAlipayAppId: 'string',
      authAlipayEnable: 'boolean',
      authAlipayPrivateKey: 'string',
      authConfig: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      authDingdingAppId: 'string',
      authDingdingAppSecret: 'string',
      authDingdingEnable: 'boolean',
      authEndpointEnable: 'boolean',
      authRamAppId: 'string',
      authRamAppSecret: 'string',
      authRamEnable: 'boolean',
      createdAt: 'string',
      dataHashName: 'string',
      description: 'string',
      domainId: 'string',
      domainName: 'string',
      eventFilenameMatches: 'string',
      eventMnsEndpoint: 'string',
      eventMnsTopic: 'string',
      eventNames: { 'type': 'array', 'itemType': 'string' },
      eventRoleArn: 'string',
      initDriveEnable: 'boolean',
      initDriveSize: 'number',
      initDriveStoreId: 'string',
      pathType: 'string',
      publishedAppAccessStrategy: AppAccessStrategy,
      sharable: 'boolean',
      storeLevel: 'string',
      storeRegionList: { 'type': 'array', 'itemType': 'string' },
      updatedAt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class GetAppPublicKeyResponse extends $tea.Model {
  appId: string;
  publicKey: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      publicKey: 'public_key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      publicKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class GetAppResponse extends $tea.Model {
  aliOwnerId: string;
  appId: string;
  appName: string;
  appSecret: string;
  createdAt: string;
  description: string;
  logo: string;
  provider: string;
  redirectUri: string;
  scope: string[];
  screenshots: string[];
  stage: string;
  type: string;
  updatedAt: string;
  static names(): { [key: string]: string } {
    return {
      aliOwnerId: 'ali_owner_id',
      appId: 'app_id',
      appName: 'app_name',
      appSecret: 'app_secret',
      createdAt: 'created_at',
      description: 'description',
      logo: 'logo',
      provider: 'provider',
      redirectUri: 'redirect_uri',
      scope: 'scope',
      screenshots: 'screenshots',
      stage: 'stage',
      type: 'type',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      aliOwnerId: 'string',
      appId: 'string',
      appName: 'string',
      appSecret: 'string',
      createdAt: 'string',
      description: 'string',
      logo: 'string',
      provider: 'string',
      redirectUri: 'string',
      scope: { 'type': 'array', 'itemType': 'string' },
      screenshots: { 'type': 'array', 'itemType': 'string' },
      stage: 'string',
      type: 'string',
      updatedAt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * get domain response
 */
export class GetDomainResponse extends $tea.Model {
  authAlipayAppId?: string;
  authAlipayEnable?: boolean;
  authAlipayPrivateKey?: string;
  authConfig?: {[key: string]: any};
  authDingdingAppId?: string;
  authDingdingAppSecret?: string;
  authDingdingEnable?: boolean;
  authEndpointEnable?: boolean;
  authRamAppId?: string;
  authRamAppSecret?: string;
  authRamEnable?: boolean;
  createdAt?: string;
  dataHashName?: string;
  description?: string;
  domainId?: string;
  domainName?: string;
  eventFilenameMatches?: string;
  eventMnsEndpoint?: string;
  eventMnsTopic?: string;
  eventNames?: string[];
  eventRoleArn?: string;
  initDriveEnable?: boolean;
  initDriveSize?: number;
  initDriveStoreId?: string;
  pathType?: string;
  publishedAppAccessStrategy?: AppAccessStrategy;
  sharable?: boolean;
  storeLevel?: string;
  storeRegionList?: string[];
  updatedAt?: string;
  static names(): { [key: string]: string } {
    return {
      authAlipayAppId: 'auth_alipay_app_id',
      authAlipayEnable: 'auth_alipay_enable',
      authAlipayPrivateKey: 'auth_alipay_private_key',
      authConfig: 'auth_config',
      authDingdingAppId: 'auth_dingding_app_id',
      authDingdingAppSecret: 'auth_dingding_app_secret',
      authDingdingEnable: 'auth_dingding_enable',
      authEndpointEnable: 'auth_endpoint_enable',
      authRamAppId: 'auth_ram_app_id',
      authRamAppSecret: 'auth_ram_app_secret',
      authRamEnable: 'auth_ram_enable',
      createdAt: 'created_at',
      dataHashName: 'data_hash_name',
      description: 'description',
      domainId: 'domain_id',
      domainName: 'domain_name',
      eventFilenameMatches: 'event_filename_matches',
      eventMnsEndpoint: 'event_mns_endpoint',
      eventMnsTopic: 'event_mns_topic',
      eventNames: 'event_names',
      eventRoleArn: 'event_role_arn',
      initDriveEnable: 'init_drive_enable',
      initDriveSize: 'init_drive_size',
      initDriveStoreId: 'init_drive_store_id',
      pathType: 'path_type',
      publishedAppAccessStrategy: 'published_app_access_strategy',
      sharable: 'sharable',
      storeLevel: 'store_level',
      storeRegionList: 'store_region_list',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authAlipayAppId: 'string',
      authAlipayEnable: 'boolean',
      authAlipayPrivateKey: 'string',
      authConfig: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      authDingdingAppId: 'string',
      authDingdingAppSecret: 'string',
      authDingdingEnable: 'boolean',
      authEndpointEnable: 'boolean',
      authRamAppId: 'string',
      authRamAppSecret: 'string',
      authRamEnable: 'boolean',
      createdAt: 'string',
      dataHashName: 'string',
      description: 'string',
      domainId: 'string',
      domainName: 'string',
      eventFilenameMatches: 'string',
      eventMnsEndpoint: 'string',
      eventMnsTopic: 'string',
      eventNames: { 'type': 'array', 'itemType': 'string' },
      eventRoleArn: 'string',
      initDriveEnable: 'boolean',
      initDriveSize: 'number',
      initDriveStoreId: 'string',
      pathType: 'string',
      publishedAppAccessStrategy: AppAccessStrategy,
      sharable: 'boolean',
      storeLevel: 'string',
      storeRegionList: { 'type': 'array', 'itemType': 'string' },
      updatedAt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class GetUserAccessTokenRequest extends $tea.Model {
  role?: string;
  userId: string;
  static names(): { [key: string]: string } {
    return {
      role: 'role',
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      role: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class ListAppsResponse extends $tea.Model {
  items: GetAppResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': GetAppResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * list domain cors response
 */
export class ListDomainCORSRuleResponse extends $tea.Model {
  corsRuleList?: CorsRule[];
  domainId?: string;
  static names(): { [key: string]: string } {
    return {
      corsRuleList: 'cors_rule_list',
      domainId: 'domain_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corsRuleList: { 'type': 'array', 'itemType': CorsRule },
      domainId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * list domain response
 */
export class ListDomainsResponse extends $tea.Model {
  items?: BaseDomainResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': BaseDomainResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class ListStoresResponse extends $tea.Model {
  items: Store[];
  static names(): { [key: string]: string } {
    return {
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': Store },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class Store extends $tea.Model {
  accelerateEndpoint?: string;
  basePath?: string;
  bucket: string;
  customizedEndpoint?: string;
  endpoint: string;
  internalEndpoint?: string;
  ownership: string;
  policy: string;
  roleArn?: string;
  storeId: string;
  type: string;
  static names(): { [key: string]: string } {
    return {
      accelerateEndpoint: 'accelerate_endpoint',
      basePath: 'base_path',
      bucket: 'bucket',
      customizedEndpoint: 'customized_endpoint',
      endpoint: 'endpoint',
      internalEndpoint: 'internal_endpoint',
      ownership: 'ownership',
      policy: 'policy',
      roleArn: 'role_arn',
      storeId: 'store_id',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accelerateEndpoint: 'string',
      basePath: 'string',
      bucket: 'string',
      customizedEndpoint: 'string',
      endpoint: 'string',
      internalEndpoint: 'string',
      ownership: 'string',
      policy: 'string',
      roleArn: 'string',
      storeId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * create domain response
 */
export class UpdateDomainResponse extends $tea.Model {
  authAlipayAppId?: string;
  authAlipayEnable?: boolean;
  authAlipayPrivateKey?: string;
  authConfig?: {[key: string]: any};
  authDingdingAppId?: string;
  authDingdingAppSecret?: string;
  authDingdingEnable?: boolean;
  authEndpointEnable?: boolean;
  authRamAppId?: string;
  authRamAppSecret?: string;
  authRamEnable?: boolean;
  createdAt?: string;
  dataHashName?: string;
  description?: string;
  domainId?: string;
  domainName?: string;
  eventFilenameMatches?: string;
  eventMnsEndpoint?: string;
  eventMnsTopic?: string;
  eventNames?: string[];
  eventRoleArn?: string;
  initDriveEnable?: boolean;
  initDriveSize?: number;
  initDriveStoreId?: string;
  pathType?: string;
  publishedAppAccessStrategy?: AppAccessStrategy;
  sharable?: boolean;
  storeLevel?: string;
  storeRegionList?: string[];
  updatedAt?: string;
  static names(): { [key: string]: string } {
    return {
      authAlipayAppId: 'auth_alipay_app_id',
      authAlipayEnable: 'auth_alipay_enable',
      authAlipayPrivateKey: 'auth_alipay_private_key',
      authConfig: 'auth_config',
      authDingdingAppId: 'auth_dingding_app_id',
      authDingdingAppSecret: 'auth_dingding_app_secret',
      authDingdingEnable: 'auth_dingding_enable',
      authEndpointEnable: 'auth_endpoint_enable',
      authRamAppId: 'auth_ram_app_id',
      authRamAppSecret: 'auth_ram_app_secret',
      authRamEnable: 'auth_ram_enable',
      createdAt: 'created_at',
      dataHashName: 'data_hash_name',
      description: 'description',
      domainId: 'domain_id',
      domainName: 'domain_name',
      eventFilenameMatches: 'event_filename_matches',
      eventMnsEndpoint: 'event_mns_endpoint',
      eventMnsTopic: 'event_mns_topic',
      eventNames: 'event_names',
      eventRoleArn: 'event_role_arn',
      initDriveEnable: 'init_drive_enable',
      initDriveSize: 'init_drive_size',
      initDriveStoreId: 'init_drive_store_id',
      pathType: 'path_type',
      publishedAppAccessStrategy: 'published_app_access_strategy',
      sharable: 'sharable',
      storeLevel: 'store_level',
      storeRegionList: 'store_region_list',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authAlipayAppId: 'string',
      authAlipayEnable: 'boolean',
      authAlipayPrivateKey: 'string',
      authConfig: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      authDingdingAppId: 'string',
      authDingdingAppSecret: 'string',
      authDingdingEnable: 'boolean',
      authEndpointEnable: 'boolean',
      authRamAppId: 'string',
      authRamAppSecret: 'string',
      authRamEnable: 'boolean',
      createdAt: 'string',
      dataHashName: 'string',
      description: 'string',
      domainId: 'string',
      domainName: 'string',
      eventFilenameMatches: 'string',
      eventMnsEndpoint: 'string',
      eventMnsTopic: 'string',
      eventNames: { 'type': 'array', 'itemType': 'string' },
      eventRoleArn: 'string',
      initDriveEnable: 'boolean',
      initDriveSize: 'number',
      initDriveStoreId: 'string',
      pathType: 'string',
      publishedAppAccessStrategy: AppAccessStrategy,
      sharable: 'boolean',
      storeLevel: 'string',
      storeRegionList: { 'type': 'array', 'itemType': 'string' },
      updatedAt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAsyncTaskInfoRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetAsyncTaskRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetAsyncTaskRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAsyncTaskInfoModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetAsyncTaskResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetAsyncTaskResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOperationRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPBatchRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPBatchRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOperationModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPBatchResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPBatchResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDriveRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CreateDriveRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateDriveRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDriveModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CreateDriveResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateDriveResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDriveRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: DeleteDriveRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteDriveRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDriveModel extends $tea.Model {
  headers?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDriveRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetDriveRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDriveRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDriveModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetDriveResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDriveResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultDriveRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetDefaultDriveRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDefaultDriveRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultDriveModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetDriveResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDriveResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDrivesRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListDriveRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListDriveRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDrivesModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListDriveResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListDriveResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMyDrivesRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListMyDriveRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListMyDriveRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListMyDrivesModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListDriveResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListDriveResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDriveRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: UpdateDriveRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateDriveRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDriveModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: UpdateDriveResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateDriveResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CompleteFileRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPCompleteFileRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPCompleteFileRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CompleteFileModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPCompleteFileResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPCompleteFileResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyFileRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPCopyFileRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPCopyFileRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyFileModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPCopyFileResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPCopyFileResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFileRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPCreateFileRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPCreateFileRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFileModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPCreateFileResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPCreateFileResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFileRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPDeleteFileRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPDeleteFileRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFileModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPDeleteFileResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPDeleteFileResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DownloadFileQuery extends $tea.Model {
  DriveID: string;
  FileID: string;
  ImageThumbnailProcess?: string;
  VideoThumbnailProcess?: string;
  static names(): { [key: string]: string } {
    return {
      DriveID: 'DriveID',
      FileID: 'FileID',
      ImageThumbnailProcess: 'ImageThumbnailProcess',
      VideoThumbnailProcess: 'VideoThumbnailProcess',
    };
  }

  static types(): { [key: string]: any } {
    return {
      DriveID: 'string',
      FileID: 'string',
      ImageThumbnailProcess: 'string',
      VideoThumbnailProcess: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DownloadFileRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  query: DownloadFileQuery;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      query: 'query',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      query: DownloadFileQuery,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DownloadFileModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetDownloadUrlRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetDownloadUrlRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetFileRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetFileRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetFileResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetFileResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileByPathRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetFileByPathRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetFileByPathRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileByPathModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetFileByPathResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetFileByPathResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadUrlRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetDownloadUrlRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetDownloadUrlRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadUrlModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetDownloadUrlResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetDownloadUrlResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLastCursorRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetLastCursorRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetLastCursorRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLastCursorModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetLastCursorResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetLastCursorResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetUploadUrlRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetUploadUrlRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPGetUploadUrlResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPGetUploadUrlResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFileRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPListFileRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPListFileRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFileModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPListFileResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPListFileResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFileByCustomIndexKeyRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPListFileByCustomIndexKeyRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPListFileByCustomIndexKeyRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFileByCustomIndexKeyModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPListFileResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPListFileResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFileDeltaRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListFileDeltaRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListFileDeltaRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFileDeltaModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListFileDeltaResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListFileDeltaResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUploadedPartsRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPListUploadedPartRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPListUploadedPartRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUploadedPartsModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPListUploadedPartResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPListUploadedPartResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFileRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPMoveFileRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPMoveFileRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MoveFileModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPMoveFileResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPMoveFileResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ScanFileMetaRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPScanFileMetaRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPScanFileMetaRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ScanFileMetaModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPScanFileMetaResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPScanFileMetaResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFileRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPSearchFileRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPSearchFileRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchFileModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPSearchFileResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPSearchFileResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFileRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPUpdateFileMetaRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPUpdateFileMetaRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFileModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CCPUpdateFileMetaResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CCPUpdateFileMetaResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * complete file request
 */
export class BaseCompleteFileRequest extends $tea.Model {
  driveId?: string;
  partInfoList?: UploadPartInfo[];
  uploadId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      partInfoList: 'part_info_list',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * create file request
 */
export class BaseCreateFileRequest extends $tea.Model {
  contentMd5: string;
  contentType: string;
  name: string;
  partInfoList?: UploadPartInfo[];
  size: number;
  type: string;
  static names(): { [key: string]: string } {
    return {
      contentMd5: 'content_md5',
      contentType: 'content_type',
      name: 'name',
      partInfoList: 'part_info_list',
      size: 'size',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentMd5: 'string',
      contentType: 'string',
      name: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      size: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件上传URL
 */
export class BaseGetUploadUrlRequest extends $tea.Model {
  contentMd5?: string;
  driveId?: string;
  partInfoList?: UploadPartInfo[];
  uploadId: string;
  static names(): { [key: string]: string } {
    return {
      contentMd5: 'content_md5',
      driveId: 'drive_id',
      partInfoList: 'part_info_list',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentMd5: 'string',
      driveId: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * list file request
 */
export class BaseListFileRequest extends $tea.Model {
  driveId?: string;
  imageThumbnailProcess?: string;
  imageUrlProcess?: string;
  limit?: number;
  marker?: string;
  videoThumbnailProcess?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      limit: 'limit',
      marker: 'marker',
      videoThumbnailProcess: 'video_thumbnail_process',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      limit: 'number',
      marker: 'string',
      videoThumbnailProcess: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 文件移动请求
 */
export class BaseMoveFileRequest extends $tea.Model {
  driveId: string;
  newName?: string;
  overwrite?: boolean;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      newName: 'new_name',
      overwrite: 'overwrite',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      newName: 'string',
      overwrite: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class BatchSubRequest extends $tea.Model {
  body?: {[key: string]: any};
  headers?: {[key: string]: any};
  id: string;
  method: string;
  url: string;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      headers: 'headers',
      id: 'id',
      method: 'method',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      id: 'string',
      method: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 批处理
 */
export class CCPBatchRequest extends $tea.Model {
  requests: BatchSubRequest[];
  resource: string;
  static names(): { [key: string]: string } {
    return {
      requests: 'requests',
      resource: 'resource',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requests: { 'type': 'array', 'itemType': BatchSubRequest },
      resource: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 合并文件上传任务
 */
export class CCPCompleteFileRequest extends $tea.Model {
  driveId?: string;
  partInfoList?: UploadPartInfo[];
  uploadId?: string;
  fileId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      partInfoList: 'part_info_list',
      uploadId: 'upload_id',
      fileId: 'file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      uploadId: 'string',
      fileId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 文件拷贝
 */
export class CCPCopyFileRequest extends $tea.Model {
  autoRename?: boolean;
  driveId: string;
  fileId: string;
  newName?: string;
  toDriveId?: string;
  toParentFileId: string;
  static names(): { [key: string]: string } {
    return {
      autoRename: 'auto_rename',
      driveId: 'drive_id',
      fileId: 'file_id',
      newName: 'new_name',
      toDriveId: 'to_drive_id',
      toParentFileId: 'to_parent_file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoRename: 'boolean',
      driveId: 'string',
      fileId: 'string',
      newName: 'string',
      toDriveId: 'string',
      toParentFileId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 创建文件
 */
export class CCPCreateFileRequest extends $tea.Model {
  contentMd5?: string;
  contentType?: string;
  name?: string;
  partInfoList?: UploadPartInfo[];
  size?: number;
  type?: string;
  autoRename?: boolean;
  checkNameMode?: string;
  contentHash?: string;
  contentHashName?: string;
  description?: string;
  driveId?: string;
  encryptMode?: string;
  fileId?: string;
  hidden?: boolean;
  labels?: string[];
  lastUpdatedAt?: string;
  meta?: string;
  parentFileId?: string;
  preHash?: string;
  streamsInfo?: {[key: string]: any};
  userMeta?: string;
  static names(): { [key: string]: string } {
    return {
      contentMd5: 'content_md5',
      contentType: 'content_type',
      name: 'name',
      partInfoList: 'part_info_list',
      size: 'size',
      type: 'type',
      autoRename: 'auto_rename',
      checkNameMode: 'check_name_mode',
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      description: 'description',
      driveId: 'drive_id',
      encryptMode: 'encrypt_mode',
      fileId: 'file_id',
      hidden: 'hidden',
      labels: 'labels',
      lastUpdatedAt: 'last_updated_at',
      meta: 'meta',
      parentFileId: 'parent_file_id',
      preHash: 'pre_hash',
      streamsInfo: 'streams_info',
      userMeta: 'user_meta',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentMd5: 'string',
      contentType: 'string',
      name: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      size: 'number',
      type: 'string',
      autoRename: 'boolean',
      checkNameMode: 'string',
      contentHash: 'string',
      contentHashName: 'string',
      description: 'string',
      driveId: 'string',
      encryptMode: 'string',
      fileId: 'string',
      hidden: 'boolean',
      labels: { 'type': 'array', 'itemType': 'string' },
      lastUpdatedAt: 'string',
      meta: 'string',
      parentFileId: 'string',
      preHash: 'string',
      streamsInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      userMeta: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 删除文件请求
 */
export class CCPDeleteFileRequest extends $tea.Model {
  driveId: string;
  fileId: string;
  permanently?: boolean;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fileId: 'file_id',
      permanently: 'permanently',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fileId: 'string',
      permanently: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 批量删除文件请求
 */
export class CCPDeleteFilesRequest extends $tea.Model {
  driveId: string;
  fileIdList: string[];
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fileIdList: 'file_id_list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fileIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取异步人去信息
 */
export class CCPGetAsyncTaskRequest extends $tea.Model {
  asyncTaskId?: string;
  static names(): { [key: string]: string } {
    return {
      asyncTaskId: 'async_task_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      asyncTaskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件下载地址的请求body
 */
export class CCPGetDownloadUrlRequest extends $tea.Model {
  driveId: string;
  expireSec?: number;
  fileId: string;
  fileName?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      expireSec: 'expire_sec',
      fileId: 'file_id',
      fileName: 'file_name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      expireSec: 'number',
      fileId: 'string',
      fileName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 根据路径获取 File 接口 body
 */
export class CCPGetFileByPathRequest extends $tea.Model {
  driveId: string;
  fields?: string;
  fileId: string;
  filePath?: string;
  imageThumbnailProcess?: string;
  imageUrlProcess?: string;
  urlExpireSec?: number;
  videoThumbnailProcess?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fields: 'fields',
      fileId: 'file_id',
      filePath: 'file_path',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      urlExpireSec: 'url_expire_sec',
      videoThumbnailProcess: 'video_thumbnail_process',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fields: 'string',
      fileId: 'string',
      filePath: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      urlExpireSec: 'number',
      videoThumbnailProcess: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件元数据
 */
export class CCPGetFileRequest extends $tea.Model {
  driveId: string;
  fields?: string;
  fileId: string;
  imageThumbnailProcess?: string;
  imageUrlProcess?: string;
  urlExpireSec?: number;
  videoThumbnailProcess?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fields: 'fields',
      fileId: 'file_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      urlExpireSec: 'url_expire_sec',
      videoThumbnailProcess: 'video_thumbnail_process',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fields: 'string',
      fileId: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      urlExpireSec: 'number',
      videoThumbnailProcess: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件上传URL
 */
export class CCPGetUploadUrlRequest extends $tea.Model {
  contentMd5?: string;
  driveId?: string;
  partInfoList?: UploadPartInfo[];
  uploadId?: string;
  fileId?: string;
  static names(): { [key: string]: string } {
    return {
      contentMd5: 'content_md5',
      driveId: 'drive_id',
      partInfoList: 'part_info_list',
      uploadId: 'upload_id',
      fileId: 'file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentMd5: 'string',
      driveId: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      uploadId: 'string',
      fileId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 列举文件
 */
export class CCPListFileByCustomIndexKeyRequest extends $tea.Model {
  driveId?: string;
  imageThumbnailProcess?: string;
  imageUrlProcess?: string;
  limit?: number;
  marker?: string;
  videoThumbnailProcess?: string;
  Starred?: boolean;
  category?: string;
  customIndexKey?: string;
  encryptMode?: string;
  fields?: string;
  orderDirection?: string;
  status?: string;
  type?: string;
  urlExpireSec?: number;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      limit: 'limit',
      marker: 'marker',
      videoThumbnailProcess: 'video_thumbnail_process',
      Starred: 'Starred',
      category: 'category',
      customIndexKey: 'custom_index_key',
      encryptMode: 'encrypt_mode',
      fields: 'fields',
      orderDirection: 'order_direction',
      status: 'status',
      type: 'type',
      urlExpireSec: 'url_expire_sec',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      limit: 'number',
      marker: 'string',
      videoThumbnailProcess: 'string',
      Starred: 'boolean',
      category: 'string',
      customIndexKey: 'string',
      encryptMode: 'string',
      fields: 'string',
      orderDirection: 'string',
      status: 'string',
      type: 'string',
      urlExpireSec: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 列举文件
 */
export class CCPListFileRequest extends $tea.Model {
  driveId?: string;
  imageThumbnailProcess?: string;
  imageUrlProcess?: string;
  limit?: number;
  marker?: string;
  videoThumbnailProcess?: string;
  Starred?: boolean;
  all?: boolean;
  category?: string;
  fields?: string;
  orderBy?: string;
  orderDirection?: string;
  parentFileId?: string;
  status?: string;
  type?: string;
  urlExpireSec?: number;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      limit: 'limit',
      marker: 'marker',
      videoThumbnailProcess: 'video_thumbnail_process',
      Starred: 'Starred',
      all: 'all',
      category: 'category',
      fields: 'fields',
      orderBy: 'order_by',
      orderDirection: 'order_direction',
      parentFileId: 'parent_file_id',
      status: 'status',
      type: 'type',
      urlExpireSec: 'url_expire_sec',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      limit: 'number',
      marker: 'string',
      videoThumbnailProcess: 'string',
      Starred: 'boolean',
      all: 'boolean',
      category: 'string',
      fields: 'string',
      orderBy: 'string',
      orderDirection: 'string',
      parentFileId: 'string',
      status: 'string',
      type: 'string',
      urlExpireSec: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 列举uploadID对应的已上传分片
 */
export class CCPListUploadedPartRequest extends $tea.Model {
  driveId: string;
  fileId: string;
  limit: number;
  partNumberMarker?: number;
  uploadId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fileId: 'file_id',
      limit: 'limit',
      partNumberMarker: 'part_number_marker',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fileId: 'string',
      limit: 'number',
      partNumberMarker: 'number',
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 文件移动请求
 */
export class CCPMoveFileRequest extends $tea.Model {
  driveId?: string;
  newName?: string;
  overwrite?: boolean;
  fileId?: string;
  toParentFileId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      newName: 'new_name',
      overwrite: 'overwrite',
      fileId: 'file_id',
      toParentFileId: 'to_parent_file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      newName: 'string',
      overwrite: 'boolean',
      fileId: 'string',
      toParentFileId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 全量获取file元信息的请求body
 */
export class CCPScanFileMetaRequest extends $tea.Model {
  category?: string;
  driveId: string;
  limit?: number;
  marker?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      driveId: 'drive_id',
      limit: 'limit',
      marker: 'marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      driveId: 'string',
      limit: 'number',
      marker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 搜索文件元数据
 */
export class CCPSearchFileRequest extends $tea.Model {
  driveId: string;
  imageThumbnailProcess?: string;
  imageUrlProcess?: string;
  limit?: number;
  marker?: string;
  orderBy?: string;
  query?: string;
  urlExpireSec?: number;
  videoThumbnailProcess?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      limit: 'limit',
      marker: 'marker',
      orderBy: 'order_by',
      query: 'query',
      urlExpireSec: 'url_expire_sec',
      videoThumbnailProcess: 'video_thumbnail_process',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      limit: 'number',
      marker: 'string',
      orderBy: 'string',
      query: 'string',
      urlExpireSec: 'number',
      videoThumbnailProcess: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 更新文件元数据
 */
export class CCPUpdateFileMetaRequest extends $tea.Model {
  customIndexKey?: string;
  description?: string;
  driveId: string;
  encryptMode?: string;
  fileId: string;
  hidden?: boolean;
  labels?: string[];
  meta?: string;
  name?: string;
  starred?: boolean;
  userMeta?: string;
  static names(): { [key: string]: string } {
    return {
      customIndexKey: 'custom_index_key',
      description: 'description',
      driveId: 'drive_id',
      encryptMode: 'encrypt_mode',
      fileId: 'file_id',
      hidden: 'hidden',
      labels: 'labels',
      meta: 'meta',
      name: 'name',
      starred: 'starred',
      userMeta: 'user_meta',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customIndexKey: 'string',
      description: 'string',
      driveId: 'string',
      encryptMode: 'string',
      fileId: 'string',
      hidden: 'boolean',
      labels: { 'type': 'array', 'itemType': 'string' },
      meta: 'string',
      name: 'string',
      starred: 'boolean',
      userMeta: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * complete file request
 */
export class CompleteFileRequest extends $tea.Model {
  driveId: string;
  fileId: string;
  filePath?: string;
  partInfoList?: UploadPartInfo[];
  shareId?: string;
  uploadId: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fileId: 'file_id',
      filePath: 'file_path',
      partInfoList: 'part_info_list',
      shareId: 'share_id',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fileId: 'string',
      filePath: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      shareId: 'string',
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * copy file request
 */
export class CopyFileRequest extends $tea.Model {
  driveId: string;
  fileId: string;
  filePath?: string;
  newName: string;
  overwrite?: boolean;
  shareId?: string;
  toDriveId: string;
  toParentFileId: string;
  toParentFilePath?: string;
  toShareId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fileId: 'file_id',
      filePath: 'file_path',
      newName: 'new_name',
      overwrite: 'overwrite',
      shareId: 'share_id',
      toDriveId: 'to_drive_id',
      toParentFileId: 'to_parent_file_id',
      toParentFilePath: 'to_parent_file_path',
      toShareId: 'to_share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fileId: 'string',
      filePath: 'string',
      newName: 'string',
      overwrite: 'boolean',
      shareId: 'string',
      toDriveId: 'string',
      toParentFileId: 'string',
      toParentFilePath: 'string',
      toShareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * create drive request
 */
export class CreateDriveRequest extends $tea.Model {
  default?: boolean;
  description?: string;
  driveName: string;
  driveType?: string;
  encryptMode?: string;
  owner: string;
  relativePath?: string;
  status?: string;
  storeId?: string;
  totalSize?: number;
  static names(): { [key: string]: string } {
    return {
      default: 'default',
      description: 'description',
      driveName: 'drive_name',
      driveType: 'drive_type',
      encryptMode: 'encrypt_mode',
      owner: 'owner',
      relativePath: 'relative_path',
      status: 'status',
      storeId: 'store_id',
      totalSize: 'total_size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      default: 'boolean',
      description: 'string',
      driveName: 'string',
      driveType: 'string',
      encryptMode: 'string',
      owner: 'string',
      relativePath: 'string',
      status: 'string',
      storeId: 'string',
      totalSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * create file request
 */
export class CreateFileRequest extends $tea.Model {
  contentHash?: string;
  contentHashName?: string;
  contentMd5?: string;
  contentType: string;
  description?: string;
  driveId: string;
  hidden?: boolean;
  meta?: string;
  name: string;
  parentFileId: string;
  parentFilePath?: string;
  partInfoList?: UploadPartInfo[];
  preHash?: string;
  shareId?: string;
  size: number;
  tags?: {[key: string]: any};
  type: string;
  static names(): { [key: string]: string } {
    return {
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentMd5: 'content_md5',
      contentType: 'content_type',
      description: 'description',
      driveId: 'drive_id',
      hidden: 'hidden',
      meta: 'meta',
      name: 'name',
      parentFileId: 'parent_file_id',
      parentFilePath: 'parent_file_path',
      partInfoList: 'part_info_list',
      preHash: 'pre_hash',
      shareId: 'share_id',
      size: 'size',
      tags: 'tags',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentHash: 'string',
      contentHashName: 'string',
      contentMd5: 'string',
      contentType: 'string',
      description: 'string',
      driveId: 'string',
      hidden: 'boolean',
      meta: 'string',
      name: 'string',
      parentFileId: 'string',
      parentFilePath: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      preHash: 'string',
      shareId: 'string',
      size: 'number',
      tags: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * create share request
 */
export class CreateShareRequest extends $tea.Model {
  description?: string;
  driveId: string;
  expiration?: string;
  owner: string;
  permissions?: string[];
  shareFilePath: string;
  shareName?: string;
  sharePolicy?: SharePermissionPolicy[];
  status?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      driveId: 'drive_id',
      expiration: 'expiration',
      owner: 'owner',
      permissions: 'permissions',
      shareFilePath: 'share_file_path',
      shareName: 'share_name',
      sharePolicy: 'share_policy',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      driveId: 'string',
      expiration: 'string',
      owner: 'string',
      permissions: { 'type': 'array', 'itemType': 'string' },
      shareFilePath: 'string',
      shareName: 'string',
      sharePolicy: { 'type': 'array', 'itemType': SharePermissionPolicy },
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Delete drive request
 */
export class DeleteDriveRequest extends $tea.Model {
  driveId: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 删除文件请求
 */
export class DeleteFileRequest extends $tea.Model {
  driveId: string;
  fileId: string;
  filePath?: string;
  permanently?: boolean;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fileId: 'file_id',
      filePath: 'file_path',
      permanently: 'permanently',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fileId: 'string',
      filePath: 'string',
      permanently: 'boolean',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * delete share request
 */
export class DeleteShareRequest extends $tea.Model {
  shareId: string;
  static names(): { [key: string]: string } {
    return {
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 下载文件请求body
 */
export class DownloadRequest extends $tea.Model {
  DriveID: string;
  FileID: string;
  ImageProcess?: string;
  ShareID?: string;
  static names(): { [key: string]: string } {
    return {
      DriveID: 'DriveID',
      FileID: 'FileID',
      ImageProcess: 'ImageProcess',
      ShareID: 'ShareID',
    };
  }

  static types(): { [key: string]: any } {
    return {
      DriveID: 'string',
      FileID: 'string',
      ImageProcess: 'string',
      ShareID: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * the file op info
 */
export class FileDeltaResponse extends $tea.Model {
  currentCategory?: string;
  file?: BaseCCPFileResponse;
  fileId?: string;
  op?: string;
  static names(): { [key: string]: string } {
    return {
      currentCategory: 'current_category',
      file: 'file',
      fileId: 'file_id',
      op: 'op',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentCategory: 'string',
      file: BaseCCPFileResponse,
      fileId: 'string',
      op: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取异步人去信息
 */
export class GetAsyncTaskRequest extends $tea.Model {
  asyncTaskId?: string;
  static names(): { [key: string]: string } {
    return {
      asyncTaskId: 'async_task_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      asyncTaskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Get default drive request
 */
export class GetDefaultDriveRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件下载地址的请求body
 */
export class GetDownloadUrlRequest extends $tea.Model {
  driveId: string;
  expireSec?: number;
  fileId: string;
  fileName?: string;
  filePath?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      expireSec: 'expire_sec',
      fileId: 'file_id',
      fileName: 'file_name',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      expireSec: 'number',
      fileId: 'string',
      fileName: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Get drive request
 */
export class GetDriveRequest extends $tea.Model {
  driveId: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件元数据
 */
export class GetFileRequest extends $tea.Model {
  driveId: string;
  fileId: string;
  filePath?: string;
  imageThumbnailProcess?: string;
  imageUrlProcess?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fileId: 'file_id',
      filePath: 'file_path',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fileId: 'string',
      filePath: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取最新游标
 */
export class GetLastCursorRequest extends $tea.Model {
  driveId: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * get last file op cursor response
 */
export class GetLastCursorResponse extends $tea.Model {
  cursor?: string;
  static names(): { [key: string]: string } {
    return {
      cursor: 'cursor',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cursor: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * get share request
 */
export class GetShareRequest extends $tea.Model {
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件上传URL
 */
export class GetUploadUrlRequest extends $tea.Model {
  contentMd5?: string;
  driveId: string;
  fileId: string;
  filePath?: string;
  partInfoList?: UploadPartInfo[];
  shareId?: string;
  uploadId: string;
  static names(): { [key: string]: string } {
    return {
      contentMd5: 'content_md5',
      driveId: 'drive_id',
      fileId: 'file_id',
      filePath: 'file_path',
      partInfoList: 'part_info_list',
      shareId: 'share_id',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentMd5: 'string',
      driveId: 'string',
      fileId: 'string',
      filePath: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      shareId: 'string',
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List drive request
 */
export class ListDriveRequest extends $tea.Model {
  limit?: number;
  marker?: string;
  owner?: string;
  static names(): { [key: string]: string } {
    return {
      limit: 'limit',
      marker: 'marker',
      owner: 'owner',
    };
  }

  static types(): { [key: string]: any } {
    return {
      limit: 'number',
      marker: 'string',
      owner: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取增量文件操作记录
 */
export class ListFileDeltaRequest extends $tea.Model {
  cursor?: string;
  driveId: string;
  limit?: number;
  static names(): { [key: string]: string } {
    return {
      cursor: 'cursor',
      driveId: 'drive_id',
      limit: 'limit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cursor: 'string',
      driveId: 'string',
      limit: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * list file op response
 */
export class ListFileDeltaResponse extends $tea.Model {
  cursor?: string;
  hasMore?: boolean;
  items?: FileDeltaResponse[];
  static names(): { [key: string]: string } {
    return {
      cursor: 'cursor',
      hasMore: 'has_more',
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cursor: 'string',
      hasMore: 'boolean',
      items: { 'type': 'array', 'itemType': FileDeltaResponse },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * list file request
 */
export class ListFileRequest extends $tea.Model {
  all?: boolean;
  driveId: string;
  imageThumbnailProcess?: string;
  imageUrlProcess?: string;
  limit?: number;
  marker?: string;
  parentFileId: string;
  parentFilePath?: string;
  shareId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      all: 'all',
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      limit: 'limit',
      marker: 'marker',
      parentFileId: 'parent_file_id',
      parentFilePath: 'parent_file_path',
      shareId: 'share_id',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      all: 'boolean',
      driveId: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      limit: 'number',
      marker: 'string',
      parentFileId: 'string',
      parentFilePath: 'string',
      shareId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List my drive request
 */
export class ListMyDriveRequest extends $tea.Model {
  limit?: number;
  marker?: string;
  static names(): { [key: string]: string } {
    return {
      limit: 'limit',
      marker: 'marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      limit: 'number',
      marker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * list share request
 */
export class ListShareRequest extends $tea.Model {
  creator?: string;
  driveId?: string;
  limit: number;
  marker?: string;
  owner?: string;
  shareFilePath?: string;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      driveId: 'drive_id',
      limit: 'limit',
      marker: 'marker',
      owner: 'owner',
      shareFilePath: 'share_file_path',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      driveId: 'string',
      limit: 'number',
      marker: 'string',
      owner: 'string',
      shareFilePath: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * list store file
 */
export class ListStoreFileRequest extends $tea.Model {
  limit?: number;
  marker?: string;
  parentFilePath?: string;
  storeId?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      limit: 'limit',
      marker: 'marker',
      parentFilePath: 'parent_file_path',
      storeId: 'store_id',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      limit: 'number',
      marker: 'string',
      parentFilePath: 'string',
      storeId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * list storage file
 */
export class ListStoreRequest extends $tea.Model {
  domainId?: string;
  static names(): { [key: string]: string } {
    return {
      domainId: 'domain_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domainId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * complete file request
 */
export class OSSCompleteFileRequest extends $tea.Model {
  driveId?: string;
  partInfoList?: UploadPartInfo[];
  uploadId?: string;
  filePath?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      partInfoList: 'part_info_list',
      uploadId: 'upload_id',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      uploadId: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * copy file request
 */
export class OSSCopyFileRequest extends $tea.Model {
  driveId?: string;
  filePath?: string;
  newName?: string;
  overwrite?: boolean;
  shareId?: string;
  toDriveId: string;
  toParentFilePath: string;
  toShareId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      filePath: 'file_path',
      newName: 'new_name',
      overwrite: 'overwrite',
      shareId: 'share_id',
      toDriveId: 'to_drive_id',
      toParentFilePath: 'to_parent_file_path',
      toShareId: 'to_share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      filePath: 'string',
      newName: 'string',
      overwrite: 'boolean',
      shareId: 'string',
      toDriveId: 'string',
      toParentFilePath: 'string',
      toShareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * create file request
 */
export class OSSCreateFileRequest extends $tea.Model {
  contentMd5?: string;
  contentType?: string;
  name?: string;
  partInfoList?: UploadPartInfo[];
  size?: number;
  type?: string;
  driveId?: string;
  parentFilePath?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      contentMd5: 'content_md5',
      contentType: 'content_type',
      name: 'name',
      partInfoList: 'part_info_list',
      size: 'size',
      type: 'type',
      driveId: 'drive_id',
      parentFilePath: 'parent_file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentMd5: 'string',
      contentType: 'string',
      name: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      size: 'number',
      type: 'string',
      driveId: 'string',
      parentFilePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 删除文件请求
 */
export class OSSDeleteFileRequest extends $tea.Model {
  driveId?: string;
  filePath: string;
  permanently?: boolean;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      filePath: 'file_path',
      permanently: 'permanently',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      filePath: 'string',
      permanently: 'boolean',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件下载地址的请求body
 */
export class OSSGetDownloadUrlRequest extends $tea.Model {
  driveId?: string;
  expireSec?: number;
  fileName?: string;
  filePath: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      expireSec: 'expire_sec',
      fileName: 'file_name',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      expireSec: 'number',
      fileName: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件元数据
 */
export class OSSGetFileRequest extends $tea.Model {
  driveId?: string;
  filePath: string;
  imageThumbnailProcess?: string;
  imageUrlProcess?: string;
  shareId?: string;
  urlExpireSec?: number;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      filePath: 'file_path',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      shareId: 'share_id',
      urlExpireSec: 'url_expire_sec',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      filePath: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      shareId: 'string',
      urlExpireSec: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件安全地址的请求body
 */
export class OSSGetSecureUrlRequest extends $tea.Model {
  driveId?: string;
  expireSec?: number;
  filePath: string;
  secureIp?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      expireSec: 'expire_sec',
      filePath: 'file_path',
      secureIp: 'secure_ip',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      expireSec: 'number',
      filePath: 'string',
      secureIp: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取文件上传URL
 */
export class OSSGetUploadUrlRequest extends $tea.Model {
  contentMd5?: string;
  driveId?: string;
  partInfoList?: UploadPartInfo[];
  uploadId?: string;
  filePath?: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      contentMd5: 'content_md5',
      driveId: 'drive_id',
      partInfoList: 'part_info_list',
      uploadId: 'upload_id',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentMd5: 'string',
      driveId: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      uploadId: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * list file request
 */
export class OSSListFileRequest extends $tea.Model {
  driveId?: string;
  imageThumbnailProcess?: string;
  imageUrlProcess?: string;
  limit?: number;
  marker?: string;
  parentFilePath: string;
  shareId?: string;
  urlExpireSec?: number;
  videoThumbnailProcess?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      limit: 'limit',
      marker: 'marker',
      parentFilePath: 'parent_file_path',
      shareId: 'share_id',
      urlExpireSec: 'url_expire_sec',
      videoThumbnailProcess: 'video_thumbnail_process',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      limit: 'number',
      marker: 'string',
      parentFilePath: 'string',
      shareId: 'string',
      urlExpireSec: 'number',
      videoThumbnailProcess: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 列举uploadID对应的已上传分片
 */
export class OSSListUploadedPartRequest extends $tea.Model {
  driveId?: string;
  filePath: string;
  limit: number;
  partNumberMarker?: number;
  shareId?: string;
  uploadId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      filePath: 'file_path',
      limit: 'limit',
      partNumberMarker: 'part_number_marker',
      shareId: 'share_id',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      filePath: 'string',
      limit: 'number',
      partNumberMarker: 'number',
      shareId: 'string',
      uploadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 文件移动请求
 */
export class OSSMoveFileRequest extends $tea.Model {
  driveId?: string;
  filePath?: string;
  newName: string;
  overwrite?: boolean;
  shareId?: string;
  toParentFilePath?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      filePath: 'file_path',
      newName: 'new_name',
      overwrite: 'overwrite',
      shareId: 'share_id',
      toParentFilePath: 'to_parent_file_path',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      filePath: 'string',
      newName: 'string',
      overwrite: 'boolean',
      shareId: 'string',
      toParentFilePath: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取视频分辨率列表
 */
export class OSSVideoDefinitionRequest extends $tea.Model {
  driveId?: string;
  filePath: string;
  shareId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取视频的m3u8文件
 */
export class OSSVideoM3U8Request extends $tea.Model {
  definition?: string;
  driveId?: string;
  expireSec?: number;
  filePath: string;
  shareId?: string;
  signToken: string;
  static names(): { [key: string]: string } {
    return {
      definition: 'definition',
      driveId: 'drive_id',
      expireSec: 'expire_sec',
      filePath: 'file_path',
      shareId: 'share_id',
      signToken: 'sign_token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      definition: 'string',
      driveId: 'string',
      expireSec: 'number',
      filePath: 'string',
      shareId: 'string',
      signToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 启动视频转码请求
 */
export class OSSVideoTranscodeRequest extends $tea.Model {
  driveId?: string;
  filePath: string;
  hlsTime?: number;
  remarks?: string;
  shareId?: string;
  transcode?: boolean;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      filePath: 'file_path',
      hlsTime: 'hls_time',
      remarks: 'remarks',
      shareId: 'share_id',
      transcode: 'transcode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      filePath: 'string',
      hlsTime: 'number',
      remarks: 'string',
      shareId: 'string',
      transcode: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class StreamInfo extends $tea.Model {
  contentHash?: string;
  contentHashName?: string;
  contentMd5: string;
  partInfoList?: UploadPartInfo[];
  preHash?: string;
  size: number;
  static names(): { [key: string]: string } {
    return {
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      contentMd5: 'content_md5',
      partInfoList: 'part_info_list',
      preHash: 'pre_hash',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentHash: 'string',
      contentHashName: 'string',
      contentMd5: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      preHash: 'string',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * UCGetObjectInfoByObjectKeyRequest
 */
export class UCGetObjectInfoByObjectKeyRequest extends $tea.Model {
  objectKey?: string;
  static names(): { [key: string]: string } {
    return {
      objectKey: 'object_key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objectKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * UCGetObjectInfoBySha1Request
 */
export class UCGetObjectInfoBySha1Request extends $tea.Model {
  sha1?: string;
  static names(): { [key: string]: string } {
    return {
      sha1: 'sha1',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sha1: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Update drive request
 */
export class UpdateDriveRequest extends $tea.Model {
  description?: string;
  driveId: string;
  driveName?: string;
  encryptDataAccess?: boolean;
  encryptMode?: string;
  status?: string;
  totalSize?: number;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      driveId: 'drive_id',
      driveName: 'drive_name',
      encryptDataAccess: 'encrypt_data_access',
      encryptMode: 'encrypt_mode',
      status: 'status',
      totalSize: 'total_size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      driveId: 'string',
      driveName: 'string',
      encryptDataAccess: 'boolean',
      encryptMode: 'string',
      status: 'string',
      totalSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 更新文件元数据
 */
export class UpdateFileMetaRequest extends $tea.Model {
  description?: string;
  driveId: string;
  fileId: string;
  hidden?: boolean;
  meta?: string;
  name: string;
  shareId?: string;
  starred?: boolean;
  tags?: {[key: string]: any};
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      driveId: 'drive_id',
      fileId: 'file_id',
      hidden: 'hidden',
      meta: 'meta',
      name: 'name',
      shareId: 'share_id',
      starred: 'starred',
      tags: 'tags',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      driveId: 'string',
      fileId: 'string',
      hidden: 'boolean',
      meta: 'string',
      name: 'string',
      shareId: 'string',
      starred: 'boolean',
      tags: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * update share request
 */
export class UpdateShareRequest extends $tea.Model {
  description?: string;
  expiration?: string;
  permissions?: string[];
  shareId: string;
  shareName?: string;
  sharePolicy?: SharePermissionPolicy[];
  status?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      expiration: 'expiration',
      permissions: 'permissions',
      shareId: 'share_id',
      shareName: 'share_name',
      sharePolicy: 'share_policy',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      expiration: 'string',
      permissions: { 'type': 'array', 'itemType': 'string' },
      shareId: 'string',
      shareName: 'string',
      sharePolicy: { 'type': 'array', 'itemType': SharePermissionPolicy },
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CreateUserRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateUserRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: CreateUserResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateUserResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUserRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: DeleteUserRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteUserRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUserModel extends $tea.Model {
  headers?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetUserRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetUserResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUsersRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListUserRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListUserRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUsersModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListUserResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListUserResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: SearchUserRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchUserRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListUserResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListUserResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: UpdateUserRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateUserRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: UpdateUserResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateUserResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Base user response
 */
export class BaseUserResponse extends $tea.Model {
  avatar?: string;
  createdAt?: number;
  defaultDriveId?: string;
  description?: string;
  domainId?: string;
  email?: string;
  nickName?: string;
  phone?: string;
  role?: string;
  status?: string;
  updatedAt?: number;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      createdAt: 'created_at',
      defaultDriveId: 'default_drive_id',
      description: 'description',
      domainId: 'domain_id',
      email: 'email',
      nickName: 'nick_name',
      phone: 'phone',
      role: 'role',
      status: 'status',
      updatedAt: 'updated_at',
      userId: 'user_id',
      userName: 'user_name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      createdAt: 'number',
      defaultDriveId: 'string',
      description: 'string',
      domainId: 'string',
      email: 'string',
      nickName: 'string',
      phone: 'string',
      role: 'string',
      status: 'string',
      updatedAt: 'number',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Create user request
 */
export class CreateUserRequest extends $tea.Model {
  avatar?: string;
  description?: string;
  email?: string;
  nickName?: string;
  phone?: string;
  role?: string;
  status?: string;
  userId: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      description: 'description',
      email: 'email',
      nickName: 'nick_name',
      phone: 'phone',
      role: 'role',
      status: 'status',
      userId: 'user_id',
      userName: 'user_name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      description: 'string',
      email: 'string',
      nickName: 'string',
      phone: 'string',
      role: 'string',
      status: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Create user response
 */
export class CreateUserResponse extends $tea.Model {
  avatar?: string;
  createdAt?: number;
  defaultDriveId?: string;
  description?: string;
  domainId?: string;
  email?: string;
  nickName?: string;
  phone?: string;
  role?: string;
  status?: string;
  updatedAt?: number;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      createdAt: 'created_at',
      defaultDriveId: 'default_drive_id',
      description: 'description',
      domainId: 'domain_id',
      email: 'email',
      nickName: 'nick_name',
      phone: 'phone',
      role: 'role',
      status: 'status',
      updatedAt: 'updated_at',
      userId: 'user_id',
      userName: 'user_name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      createdAt: 'number',
      defaultDriveId: 'string',
      description: 'string',
      domainId: 'string',
      email: 'string',
      nickName: 'string',
      phone: 'string',
      role: 'string',
      status: 'string',
      updatedAt: 'number',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Delete user request
 */
export class DeleteUserRequest extends $tea.Model {
  userId: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Delete user response
 */
export class DeleteUserResponse extends $tea.Model {
  static names(): { [key: string]: string } {
    return {
    };
  }

  static types(): { [key: string]: any } {
    return {
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Get user request
 */
export class GetUserRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Get user response
 */
export class GetUserResponse extends $tea.Model {
  avatar?: string;
  createdAt?: number;
  defaultDriveId?: string;
  description?: string;
  domainId?: string;
  email?: string;
  nickName?: string;
  phone?: string;
  role?: string;
  status?: string;
  updatedAt?: number;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      createdAt: 'created_at',
      defaultDriveId: 'default_drive_id',
      description: 'description',
      domainId: 'domain_id',
      email: 'email',
      nickName: 'nick_name',
      phone: 'phone',
      role: 'role',
      status: 'status',
      updatedAt: 'updated_at',
      userId: 'user_id',
      userName: 'user_name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      createdAt: 'number',
      defaultDriveId: 'string',
      description: 'string',
      domainId: 'string',
      email: 'string',
      nickName: 'string',
      phone: 'string',
      role: 'string',
      status: 'string',
      updatedAt: 'number',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List user request
 */
export class ListUserRequest extends $tea.Model {
  limit?: number;
  marker?: string;
  static names(): { [key: string]: string } {
    return {
      limit: 'limit',
      marker: 'marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      limit: 'number',
      marker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List user response
 */
export class ListUserResponse extends $tea.Model {
  items?: BaseUserResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': BaseUserResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Search user request
 */
export class SearchUserRequest extends $tea.Model {
  email?: string;
  limit?: number;
  marker?: string;
  nickName?: string;
  phone?: string;
  role?: string;
  status?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      email: 'email',
      limit: 'limit',
      marker: 'marker',
      nickName: 'nick_name',
      phone: 'phone',
      role: 'role',
      status: 'status',
      userName: 'user_name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      email: 'string',
      limit: 'number',
      marker: 'string',
      nickName: 'string',
      phone: 'string',
      role: 'string',
      status: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Update user request
 */
export class UpdateUserRequest extends $tea.Model {
  avatar?: string;
  description?: string;
  email?: string;
  nickName?: string;
  phone?: string;
  role?: string;
  status?: string;
  userId: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      description: 'description',
      email: 'email',
      nickName: 'nick_name',
      phone: 'phone',
      role: 'role',
      status: 'status',
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      description: 'string',
      email: 'string',
      nickName: 'string',
      phone: 'string',
      role: 'string',
      status: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Update user response
 */
export class UpdateUserResponse extends $tea.Model {
  avatar?: string;
  createdAt?: number;
  defaultDriveId?: string;
  description?: string;
  domainId?: string;
  email?: string;
  nickName?: string;
  phone?: string;
  role?: string;
  status?: string;
  updatedAt?: number;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      createdAt: 'created_at',
      defaultDriveId: 'default_drive_id',
      description: 'description',
      domainId: 'domain_id',
      email: 'email',
      nickName: 'nick_name',
      phone: 'phone',
      role: 'role',
      status: 'status',
      updatedAt: 'updated_at',
      userId: 'user_id',
      userName: 'user_name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      createdAt: 'number',
      defaultDriveId: 'string',
      description: 'string',
      domainId: 'string',
      email: 'string',
      nickName: 'string',
      phone: 'string',
      role: 'string',
      status: 'string',
      updatedAt: 'number',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPhotoCountRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetImageCountRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetImageCountRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPhotoCountModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: GetImageCountResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetImageCountResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAddressGroupsRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListImageAddressGroupsRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListImageAddressGroupsRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAddressGroupsModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListImageAddressGroupsResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListImageAddressGroupsResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFaceGroupsRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListImageFaceGroupsRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListImageFaceGroupsRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFaceGroupsModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListImageFaceGroupsResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListImageFaceGroupsResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTagsRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListImageTagsRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListImageTagsRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTagsModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: ListImageTagsResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListImageTagsResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchAddressGroupsRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: SearchImageAddressGroupsRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchImageAddressGroupsRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchAddressGroupsModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: SearchImageAddressGroupsResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchImageAddressGroupsResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFacegroupInfoRequestModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: UpdateFaceGroupInfoRequest;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateFaceGroupInfoRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFacegroupInfoModel extends $tea.Model {
  headers?: { [key: string]: string };
  body: UpdateFaceGroupInfoResponse;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateFaceGroupInfoResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class Address extends $tea.Model {
  city?: string;
  country?: string;
  district?: string;
  province?: string;
  township?: string;
  static names(): { [key: string]: string } {
    return {
      city: 'city',
      country: 'country',
      district: 'district',
      province: 'province',
      township: 'township',
    };
  }

  static types(): { [key: string]: any } {
    return {
      city: 'string',
      country: 'string',
      district: 'string',
      province: 'string',
      township: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Get photo count request
 */
export class GetImageCountRequest extends $tea.Model {
  driveId: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 获取云照片个数结果
 */
export class GetImageCountResponse extends $tea.Model {
  imageCount?: number;
  static names(): { [key: string]: string } {
    return {
      imageCount: 'image_count',
    };
  }

  static types(): { [key: string]: any } {
    return {
      imageCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class ImageAddressResponse extends $tea.Model {
  addressDetail?: Address;
  count?: number;
  coverUrl?: string;
  location?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      addressDetail: 'address_detail',
      count: 'count',
      coverUrl: 'cover_url',
      location: 'location',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addressDetail: Address,
      count: 'number',
      coverUrl: 'string',
      location: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class ImageFaceGroupResponse extends $tea.Model {
  createdAt?: string;
  faceCount?: number;
  groupCoverUrl?: string;
  groupId?: string;
  groupName?: string;
  imageCount?: number;
  updatedAt?: string;
  static names(): { [key: string]: string } {
    return {
      createdAt: 'created_at',
      faceCount: 'face_count',
      groupCoverUrl: 'group_cover_url',
      groupId: 'group_id',
      groupName: 'group_name',
      imageCount: 'image_count',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createdAt: 'string',
      faceCount: 'number',
      groupCoverUrl: 'string',
      groupId: 'string',
      groupName: 'string',
      imageCount: 'number',
      updatedAt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 
 */
export class ImageTagResponse extends $tea.Model {
  count?: number;
  coverUrl?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      coverUrl: 'cover_url',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      coverUrl: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List image address groups request
 */
export class ListImageAddressGroupsRequest extends $tea.Model {
  driveId: string;
  imageThumbnailProcess?: string;
  limit?: number;
  marker?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      limit: 'limit',
      marker: 'marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      imageThumbnailProcess: 'string',
      limit: 'number',
      marker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 展示地点分组集合
 */
export class ListImageAddressGroupsResponse extends $tea.Model {
  items?: ImageAddressResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': ImageAddressResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List image face groups request
 */
export class ListImageFaceGroupsRequest extends $tea.Model {
  driveId: string;
  limit?: number;
  marker?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      limit: 'limit',
      marker: 'marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      limit: 'number',
      marker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 展示人脸分组集合
 */
export class ListImageFaceGroupsResponse extends $tea.Model {
  items?: ImageFaceGroupResponse[];
  nextMarker?: string;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': ImageFaceGroupResponse },
      nextMarker: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * List image tags request
 */
export class ListImageTagsRequest extends $tea.Model {
  driveId: string;
  imageThumbnailProcess?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      imageThumbnailProcess: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 展示标签集合
 */
export class ListImageTagsResponse extends $tea.Model {
  tags?: ImageTagResponse[];
  static names(): { [key: string]: string } {
    return {
      tags: 'tags',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tags: { 'type': 'array', 'itemType': ImageTagResponse },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Search image address groups request
 */
export class SearchImageAddressGroupsRequest extends $tea.Model {
  addressLevel?: string;
  addressNames?: string[];
  brGeoPoint?: string;
  driveId: string;
  imageThumbnailProcess?: string;
  tlGeoPoint?: string;
  static names(): { [key: string]: string } {
    return {
      addressLevel: 'address_level',
      addressNames: 'address_names',
      brGeoPoint: 'br_geo_point',
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      tlGeoPoint: 'tl_geo_point',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addressLevel: 'string',
      addressNames: { 'type': 'array', 'itemType': 'string' },
      brGeoPoint: 'string',
      driveId: 'string',
      imageThumbnailProcess: 'string',
      tlGeoPoint: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 展示地点分组列表
 */
export class SearchImageAddressGroupsResponse extends $tea.Model {
  items?: ImageAddressResponse[];
  static names(): { [key: string]: string } {
    return {
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': ImageAddressResponse },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * Update face group info request
 */
export class UpdateFaceGroupInfoRequest extends $tea.Model {
  driveId: string;
  groupId: string;
  groupName?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      groupId: 'group_id',
      groupName: 'group_name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      groupId: 'string',
      groupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

/**
 * 更新人脸分组信息结果
 */
export class UpdateFaceGroupInfoResponse extends $tea.Model {
  driveId?: string;
  groupId?: string;
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      groupId: 'group_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      groupId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client {
  _domainId: string;
  _accessTokenCredential: AccessTokenCredential;
  _endpoint: string;
  _protocol: string;
  _nickname: string;
  _userAgent: string;
  _credential: Credential;

  constructor(config: Config) {
    if (Util.isUnset($tea.toMap(config))) {
      throw $tea.newError({
        name: "ParameterMissing",
        message: "'config' can not be unset",
      });
    }

    if (!Util.empty(config.accessToken) || !Util.empty(config.refreshToken)) {
      let accessConfig = new $AccessTokenCredential.Config({
        accessToken: config.accessToken,
        endpoint: config.endpoint,
        domainId: config.domainId,
        clientId: config.clientId,
        refreshToken: config.refreshToken,
        clientSecret: config.clientSecret,
        expireTime: config.expireTime,
      });
      this._accessTokenCredential = new AccessTokenCredential(accessConfig);
    }

    if (!Util.empty(config.accessKeyId)) {
      if (Util.empty(config.type)) {
        config.type = "access_key";
      }

      let credentialConfig = new $Credential.Config({
        accessKeyId: config.accessKeyId,
        type: config.type,
        accessKeySecret: config.accessKeySecret,
        securityToken: config.securityToken,
      });
      this._credential = new Credential(credentialConfig);
    }

    this._endpoint = config.endpoint;
    this._protocol = config.protocol;
    this._userAgent = config.userAgent;
    this._nickname = config.nickname;
    this._domainId = config.domainId;
  }

  /**
   * 取消绑定关系，生成新用户，返回访问令牌
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async cancelLink(request: CancelLinkRequestModel, runtime: RuntimeOptions): Promise<CancelLinkModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/cancel_link`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<CancelLinkModel>({
            body: respMap,
            headers: response_.headers,
          }, new CancelLinkModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 确认绑定关系, 成功后返回访问令牌
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async confirmLink(request: ConfirmLinkRequestModel, runtime: RuntimeOptions): Promise<ConfirmLinkModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/confirm_link`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ConfirmLinkModel>({
            body: respMap,
            headers: response_.headers,
          }, new ConfirmLinkModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 修改手机登录密码，密码必须包含数字和字母，长度8-20个字符
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async changePassword(request: ChangePasswordRequestModel, runtime: RuntimeOptions): Promise<ChangePasswordModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/default/change_password`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ChangePasswordModel>({
            body: respMap,
            headers: response_.headers,
          }, new ChangePasswordModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 设置手机登录密码，密码必须包含数字和字母，长度8-20个字符
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async setPassword(request: SetPasswordRequestModel, runtime: RuntimeOptions): Promise<SetPasswordModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/default/set_password`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 204)) {
          return $tea.cast<SetPasswordModel>({
            headers: response_.headers,
          }, new SetPasswordModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 校验手机短信验证码，用于重置密码时校验手机，通过校验后返回state，可通过state重新设置密码
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async verifyCode(request: VerifyCodeRequestModel, runtime: RuntimeOptions): Promise<VerifyCodeModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/default/verify_code`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<VerifyCodeModel>({
            body: respMap,
            headers: response_.headers,
          }, new VerifyCodeModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 管理员通过账号信息直接获取用户的访问令牌
   * @tags account
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async getAccessTokenByLinkInfo(request: GetAccessTokenByLinkInfoRequestModel, runtime: RuntimeOptions): Promise<GetAccessTokenByLinkInfoModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/get_access_token_by_link_info`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetAccessTokenByLinkInfoModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetAccessTokenByLinkInfoModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 获取图片验证码，用于人机校验，默认不需要
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async getCaptcha(request: GetCaptchaRequestModel, runtime: RuntimeOptions): Promise<GetCaptchaModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/get_captcha`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetCaptchaModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetCaptchaModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 获取用户认证方式详情
   * @tags account
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async getLinkInfo(request: GetLinkInfoRequestModel, runtime: RuntimeOptions): Promise<GetLinkInfoModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/get_link_info`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetLinkInfoModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetLinkInfoModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 获取用户的所有绑定信息
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async getLinkInfoByUserId(request: GetLinkInfoByUserIdRequestModel, runtime: RuntimeOptions): Promise<GetLinkInfoByUserIdModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/get_link_info_by_user_id`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetLinkInfoByUserIdModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetLinkInfoByUserIdModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 获取公钥，用于加密对称密钥
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async getPublicKey(request: GetPublicKeyRequestModel, runtime: RuntimeOptions): Promise<GetPublicKeyModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/get_public_key`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetPublicKeyModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetPublicKeyModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 绑定用户认证方式
   * @tags account
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error AlreadyExist {resource} has already exists. {extra_msg}
   * @error InternalError The request has been failed due to some unknown error.
   */
  async link(request: LinkRequestModel, runtime: RuntimeOptions): Promise<LinkModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/link`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<LinkModel>({
            body: respMap,
            headers: response_.headers,
          }, new LinkModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 查询手机号是否已被注册
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async checkExist(request: CheckExistRequestModel, runtime: RuntimeOptions): Promise<CheckExistModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/mobile/check_exist`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<CheckExistModel>({
            body: respMap,
            headers: response_.headers,
          }, new CheckExistModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 通过手机号+短信或密码登录，返回刷新令牌和访问令牌
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async login(request: LoginRequestModel, runtime: RuntimeOptions): Promise<LoginModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/mobile/login`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<LoginModel>({
            body: respMap,
            headers: response_.headers,
          }, new LoginModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 通过手机号+短信验证码注册账号
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error AlreadyExist {resource} has already exists. {extra_msg}
   * @error InternalError The request has been failed due to some unknown error.
   */
  async register(request: RegisterRequestModel, runtime: RuntimeOptions): Promise<RegisterModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/mobile/register`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<RegisterModel>({
            body: respMap,
            headers: response_.headers,
          }, new RegisterModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 发送短信验证码，用于登录、注册、修改密码、绑定等
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async mobileSendSmsCode(request: MobileSendSmsCodeRequestModel, runtime: RuntimeOptions): Promise<MobileSendSmsCodeModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/mobile/send_sms_code`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<MobileSendSmsCodeModel>({
            body: respMap,
            headers: response_.headers,
          }, new MobileSendSmsCodeModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 用户退出登录
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async accountRevoke(request: AccountRevokeRequestModel, runtime: RuntimeOptions): Promise<AccountRevokeModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/revoke`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 204)) {
          return $tea.cast<AccountRevokeModel>({
            headers: response_.headers,
          }, new AccountRevokeModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 用户通过刷新令牌（refresh_token）获取访问令牌（access_token）
   * @tags account
   * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async accountToken(request: AccountTokenRequestModel, runtime: RuntimeOptions): Promise<AccountTokenModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/account/token`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<AccountTokenModel>({
            body: respMap,
            headers: response_.headers,
          }, new AccountTokenModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 列举Store列表
   * @tags admin
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error Forbidden User not authorized to operate on the specified APIs.
   * @error InternalError The request has been failed due to some unknown error.
   */
  async adminListStores(request: AdminListStoresRequestModel, runtime: RuntimeOptions): Promise<AdminListStoresModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/domain/list_stores`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<AdminListStoresModel>({
            body: respMap,
            headers: response_.headers,
          }, new AdminListStoresModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 获取用户的accessToken
   * @tags admin
   * @error undefined undefined
   * @error undefined undefined
   * @error undefined undefined
   * @error undefined undefined
   * @error undefined undefined
   */
  async getUserAccessToken(request: GetUserAccessTokenRequestModel, runtime: RuntimeOptions): Promise<GetUserAccessTokenModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/user/get_access_token`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetUserAccessTokenModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetUserAccessTokenModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 如果目录拷贝、目录删除不能在限定时间内完成，将访问一个异步任务id，
  通过此接口获取异步任务的信息，以确定任务是否执行成功。
   * @tags async_task
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async getAsyncTaskInfo(request: GetAsyncTaskInfoRequestModel, runtime: RuntimeOptions): Promise<GetAsyncTaskInfoModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/async_task/get`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetAsyncTaskInfoModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetAsyncTaskInfoModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 对多个原子操作封装成一个批处理请求，服务端并行处理并打包返回每个操作的执行结果。
  支持对文件和文件夹的移动、删除、修改，每个批处理请求最多包含100个原则操作。
   * @tags batch
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async batchOperation(request: BatchOperationRequestModel, runtime: RuntimeOptions): Promise<BatchOperationModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/batch`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<BatchOperationModel>({
            body: respMap,
            headers: response_.headers,
          }, new BatchOperationModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 支持normal和large两种drive，
  large类型的drive用于文件数多的场景，不支持list操作，
  当drive的文件数量大于1亿时，建议使用large类型。
   * @tags drive
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async createDrive(request: CreateDriveRequestModel, runtime: RuntimeOptions): Promise<CreateDriveModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/drive/create`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 201)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<CreateDriveModel>({
            body: respMap,
            headers: response_.headers,
          }, new CreateDriveModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 删除指定drive_id对应的Drive
   * @tags drive
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async deleteDrive(request: DeleteDriveRequestModel, runtime: RuntimeOptions): Promise<DeleteDriveModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/drive/delete`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 204)) {
          return $tea.cast<DeleteDriveModel>({
            headers: response_.headers,
          }, new DeleteDriveModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 获取指定drive_id对应的Drive详细信息。
   * @tags drive
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async getDrive(request: GetDriveRequestModel, runtime: RuntimeOptions): Promise<GetDriveModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/drive/get`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetDriveModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetDriveModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 一个用户可拥有多个drive，在创建drive时通过参数指定是否为这个用户的默认drive，
  每个用户只能设置一个默认drive。
   * @tags drive
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async getDefaultDrive(request: GetDefaultDriveRequestModel, runtime: RuntimeOptions): Promise<GetDefaultDriveModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/drive/get_default_drive`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetDefaultDriveModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetDefaultDriveModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 管理员列举指定用户的Drive
   * @tags drive
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async listDrives(request: ListDrivesRequestModel, runtime: RuntimeOptions): Promise<ListDrivesModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/drive/list`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ListDrivesModel>({
            body: respMap,
            headers: response_.headers,
          }, new ListDrivesModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 列举当前用户（访问令牌）的Drive
   * @tags drive
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async listMyDrives(request: ListMyDrivesRequestModel, runtime: RuntimeOptions): Promise<ListMyDrivesModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/drive/list_my_drives`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ListMyDrivesModel>({
            body: respMap,
            headers: response_.headers,
          }, new ListMyDrivesModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 更新指定drive_id的Drive信息
   * @tags drive
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async updateDrive(request: UpdateDriveRequestModel, runtime: RuntimeOptions): Promise<UpdateDriveModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/drive/update`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<UpdateDriveModel>({
            body: respMap,
            headers: response_.headers,
          }, new UpdateDriveModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 完成文件上传。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async completeFile(request: CompleteFileRequestModel, runtime: RuntimeOptions): Promise<CompleteFileModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/complete`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<CompleteFileModel>({
            body: respMap,
            headers: response_.headers,
          }, new CompleteFileModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 指定源文件或文件夹，拷贝到指定的文件夹。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async copyFile(request: CopyFileRequestModel, runtime: RuntimeOptions): Promise<CopyFileModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/copy`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 201)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<CopyFileModel>({
            body: respMap,
            headers: response_.headers,
          }, new CopyFileModel({}));
        }

        if (Util.equalNumber(response_.statusCode, 202)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<CopyFileModel>({
            body: respMap,
            headers: response_.headers,
          }, new CopyFileModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 在指定文件夹下创建文件或者文件夹，
  根文件夹用root表示，其他文件夹使用创建文件夹时返回的file_id。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error AlreadyExist {resource} has already exists. {extra_msg}
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async createFile(request: CreateFileRequestModel, runtime: RuntimeOptions): Promise<CreateFileModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/create`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 201)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<CreateFileModel>({
            body: respMap,
            headers: response_.headers,
          }, new CreateFileModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 指定文件或文件夹ID，删除文件或者文件夹。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async deleteFile(request: DeleteFileRequestModel, runtime: RuntimeOptions): Promise<DeleteFileModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/delete`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 202)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<DeleteFileModel>({
            body: respMap,
            headers: response_.headers,
          }, new DeleteFileModel({}));
        }

        if (Util.equalNumber(response_.statusCode, 204)) {
          return $tea.cast<DeleteFileModel>({
            headers: response_.headers,
          }, new DeleteFileModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 指定文件ID，下载文件。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async downloadFile(request: DownloadFileRequestModel, runtime: RuntimeOptions): Promise<DownloadFileModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "GET";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/download`);
        request_.query = Util.stringifyMapValue($tea.toMap(request.query));
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 获取指定文件或文件夹ID的信息。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async getFile(request: GetFileRequestModel, runtime: RuntimeOptions): Promise<GetFileModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/get`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetFileModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetFileModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 根据路径获取指定文件或文件夹的信息。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async getFileByPath(request: GetFileByPathRequestModel, runtime: RuntimeOptions): Promise<GetFileByPathModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/get_by_path`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetFileByPathModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetFileByPathModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 获取文件的下载地址，调用者可自己设置range头并发下载。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async getDownloadUrl(request: GetDownloadUrlRequestModel, runtime: RuntimeOptions): Promise<GetDownloadUrlModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/get_download_url`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetDownloadUrlModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetDownloadUrlModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 获取drive内，增量数据最新的游标
   * @tags file_delta
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async getLastCursor(request: GetLastCursorRequestModel, runtime: RuntimeOptions): Promise<GetLastCursorModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/get_last_cursor`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetLastCursorModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetLastCursorModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 可指定分片信息，一次获取多个分片的上传地址。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async getUploadUrl(request: GetUploadUrlRequestModel, runtime: RuntimeOptions): Promise<GetUploadUrlModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/get_upload_url`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetUploadUrlModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetUploadUrlModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 列举指定目录下的文件或文件夹。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async listFile(request: ListFileRequestModel, runtime: RuntimeOptions): Promise<ListFileModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/list`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ListFileModel>({
            body: respMap,
            headers: response_.headers,
          }, new ListFileModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 根据自定义同步索引键列举文件或文件夹。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async listFileByCustomIndexKey(request: ListFileByCustomIndexKeyRequestModel, runtime: RuntimeOptions): Promise<ListFileByCustomIndexKeyModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/list_by_custom_index_key`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ListFileByCustomIndexKeyModel>({
            body: respMap,
            headers: response_.headers,
          }, new ListFileByCustomIndexKeyModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 获取drive内，增量数据列表
   * @tags file_delta
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async listFileDelta(request: ListFileDeltaRequestModel, runtime: RuntimeOptions): Promise<ListFileDeltaModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/list_delta`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ListFileDeltaModel>({
            body: respMap,
            headers: response_.headers,
          }, new ListFileDeltaModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 列举upload_id对应的已上传分片。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async listUploadedParts(request: ListUploadedPartsRequestModel, runtime: RuntimeOptions): Promise<ListUploadedPartsModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/list_uploaded_parts`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ListUploadedPartsModel>({
            body: respMap,
            headers: response_.headers,
          }, new ListUploadedPartsModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 指定源文件或文件夹，移动到指定的文件夹。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async moveFile(request: MoveFileRequestModel, runtime: RuntimeOptions): Promise<MoveFileModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/move`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<MoveFileModel>({
            body: respMap,
            headers: response_.headers,
          }, new MoveFileModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 在指定drive下全量获取文件元信息。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async scanFileMeta(request: ScanFileMetaRequestModel, runtime: RuntimeOptions): Promise<ScanFileMetaModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/scan`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ScanFileMetaModel>({
            body: respMap,
            headers: response_.headers,
          }, new ScanFileMetaModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 根据筛选条件，在指定drive下搜索文件。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async searchFile(request: SearchFileRequestModel, runtime: RuntimeOptions): Promise<SearchFileModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/search`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<SearchFileModel>({
            body: respMap,
            headers: response_.headers,
          }, new SearchFileModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 对指定的文件或文件夹更新信息。
   * @tags file
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error AlreadyExist {resource} has already exists. {extra_msg}
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async updateFile(request: UpdateFileRequestModel, runtime: RuntimeOptions): Promise<UpdateFileModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/file/update`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<UpdateFileModel>({
            body: respMap,
            headers: response_.headers,
          }, new UpdateFileModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会创建用户， 只有管理员可以调用
   * @tags user
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async createUser(request: CreateUserRequestModel, runtime: RuntimeOptions): Promise<CreateUserModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/user/create`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 201)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<CreateUserModel>({
            body: respMap,
            headers: response_.headers,
          }, new CreateUserModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会删除用户
   * @tags user
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async deleteUser(request: DeleteUserRequestModel, runtime: RuntimeOptions): Promise<DeleteUserModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/user/delete`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 204)) {
          return $tea.cast<DeleteUserModel>({
            headers: response_.headers,
          }, new DeleteUserModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会查看用户详细信息
   * @tags user
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async getUser(request: GetUserRequestModel, runtime: RuntimeOptions): Promise<GetUserModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/user/get`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetUserModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetUserModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会展示用户列表
   * @tags user
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async listUsers(request: ListUsersRequestModel, runtime: RuntimeOptions): Promise<ListUsersModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/user/list`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ListUsersModel>({
            body: respMap,
            headers: response_.headers,
          }, new ListUsersModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会根据条件查询用户
   * @tags user
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async searchUser(request: SearchUserRequestModel, runtime: RuntimeOptions): Promise<SearchUserModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/user/search`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<SearchUserModel>({
            body: respMap,
            headers: response_.headers,
          }, new SearchUserModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会更新用户信息
   * @tags user
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async updateUser(request: UpdateUserRequestModel, runtime: RuntimeOptions): Promise<UpdateUserModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/user/update`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<UpdateUserModel>({
            body: respMap,
            headers: response_.headers,
          }, new UpdateUserModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将返回用户Drive下的云照片个数
   * @tags image
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async getPhotoCount(request: GetPhotoCountRequestModel, runtime: RuntimeOptions): Promise<GetPhotoCountModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/image/get_photo_count`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<GetPhotoCountModel>({
            body: respMap,
            headers: response_.headers,
          }, new GetPhotoCountModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会展示用户图片的地点分组
   * @tags image
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async listAddressGroups(request: ListAddressGroupsRequestModel, runtime: RuntimeOptions): Promise<ListAddressGroupsModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/image/list_address_groups`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ListAddressGroupsModel>({
            body: respMap,
            headers: response_.headers,
          }, new ListAddressGroupsModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会列举人脸分组
   * @tags image
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async listFaceGroups(request: ListFaceGroupsRequestModel, runtime: RuntimeOptions): Promise<ListFaceGroupsModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/image/list_face_groups`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ListFaceGroupsModel>({
            body: respMap,
            headers: response_.headers,
          }, new ListFaceGroupsModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会展示场景标记
   * @tags image
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async listTags(request: ListTagsRequestModel, runtime: RuntimeOptions): Promise<ListTagsModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/image/list_tags`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<ListTagsModel>({
            body: respMap,
            headers: response_.headers,
          }, new ListTagsModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会展示用户图片的地点分组
   * @tags image
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async searchAddressGroups(request: SearchAddressGroupsRequestModel, runtime: RuntimeOptions): Promise<SearchAddressGroupsModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/image/search_address_groups`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<SearchAddressGroupsModel>({
            body: respMap,
            headers: response_.headers,
          }, new SearchAddressGroupsModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  /**
   * 该接口将会更新人脸分组信息
   * @tags image
   * @error InvalidParameter The input parameter {parameter_name} is not valid.
   * @error AccessTokenInvalid AccessToken is invalid. {message}
   * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
   * @error NotFound The resource {resource_name} cannot be found. Please check.
   * @error InternalError The request has been failed due to some unknown error.
   * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
   */
  async updateFacegroupInfo(request: UpdateFacegroupInfoRequestModel, runtime: RuntimeOptions): Promise<UpdateFacegroupInfoModel> {
    let _runtime: { [key: string]: any } = {
      timeouted: "retry",
      readTimeout: runtime.readTimeout,
      connectTimeout: runtime.connectTimeout,
      localAddr: runtime.localAddr,
      httpProxy: runtime.httpProxy,
      httpsProxy: runtime.httpsProxy,
      noProxy: runtime.noProxy,
      maxIdleConns: runtime.maxIdleConns,
      socks5Proxy: runtime.socks5Proxy,
      socks5NetWork: runtime.socks5NetWork,
      retry: {
        retryable: runtime.autoretry,
        maxAttempts: Util.defaultNumber(runtime.maxAttempts, 3),
      },
      backoff: {
        policy: Util.defaultString(runtime.backoffPolicy, "no"),
        period: Util.defaultNumber(runtime.backoffPeriod, 1),
      },
      ignoreSSL: runtime.ignoreSSL,
    }

    let _lastRequest = null;
    let _now = Date.now();
    let _retryTimes = 0;
    while ($tea.allowRetry(_runtime['retry'], _retryTimes, _now)) {
      if (_retryTimes > 0) {
        let _backoffTime = $tea.getBackoffTime(_runtime['backoff'], _retryTimes);
        if (_backoffTime > 0) {
          await $tea.sleep(_backoffTime);
        }
      }

      _retryTimes = _retryTimes + 1;
      try {
        let request_ = new $tea.Request();
        let accesskeyId = await this.getAccessKeyId();
        let accessKeySecret = await this.getAccessKeySecret();
        let securityToken = await this.getSecurityToken();
        let accessToken = await this.getAccessToken();
        request_.protocol = Util.defaultString(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = this.getPathname(this._nickname, `/v2/image/update_facegroup_info`);
        request_.headers = {
          'user-agent': this.getUserAgent(),
          host: Util.defaultString(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
          ...request.headers,
        };
        if (!Util.empty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (!Util.empty(accesskeyId) && !Util.empty(accessKeySecret)) {
          if (!Util.empty(securityToken)) {
            request_.headers["x-acs-security-token"] = securityToken;
          }

          request_.headers["date"] = Util.getDateUTCString();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          let stringToSign = ROAUtil.getStringToSign(request_);
          request_.headers["authorization"] = `acs ${accesskeyId}:${ROAUtil.getSignature(stringToSign, accessKeySecret)}`;
        }

        request_.body = new $tea.BytesReadable(Util.toJSONString($tea.toMap(request.body)));
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        let respMap : {[key: string]: any} = null;
        let obj : any = null;
        if (Util.equalNumber(response_.statusCode, 200)) {
          obj = await Util.readAsJSON(response_.body);
          respMap = Util.assertAsMap(obj);
          return $tea.cast<UpdateFacegroupInfoModel>({
            body: respMap,
            headers: response_.headers,
          }, new UpdateFacegroupInfoModel({}));
        }

        if (!Util.empty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        obj = await Util.readAsJSON(response_.body);
        respMap = Util.assertAsMap(obj);
        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...respMap,
        });
      } catch (ex) {
        if ($tea.isRetryable(ex)) {
          continue;
        }
        throw ex;
      }
    }

    throw $tea.newUnretryableError(_lastRequest);
  }

  getPathname(nickname: string, path: string): string {
    if (Util.empty(nickname)) {
      return path;
    }

    return `/${nickname}${path}`;
  }

  async setExpireTime(expireTime: string): Promise<void> {
    if (Util.isUnset(this._accessTokenCredential)) {
      return ;
    }

    this._accessTokenCredential.setExpireTime(expireTime);
  }

  getExpireTime(): string {
    if (Util.isUnset(this._accessTokenCredential)) {
      return "";
    }

    let expireTime = this._accessTokenCredential.getExpireTime();
    return expireTime;
  }

  setRefreshToken(token: string): void {
    if (Util.isUnset(this._accessTokenCredential)) {
      return ;
    }

    this._accessTokenCredential.setRefreshToken(token);
  }

  getRefreshToken(): string {
    if (Util.isUnset(this._accessTokenCredential)) {
      return "";
    }

    let token = this._accessTokenCredential.getRefreshToken();
    return token;
  }

  setAccessToken(token: string): void {
    if (Util.isUnset(this._accessTokenCredential)) {
      return ;
    }

    this._accessTokenCredential.setAccessToken(token);
  }

  async getAccessToken(): Promise<string> {
    if (Util.isUnset(this._accessTokenCredential)) {
      return "";
    }

    let token = await this._accessTokenCredential.getAccessToken();
    return token;
  }

  setUserAgent(userAgent: string): void {
    this._userAgent = userAgent;
  }

  appendUserAgent(userAgent: string): void {
    this._userAgent = `${this._userAgent} ${userAgent}`;
  }

  getUserAgent(): string {
    let userAgent = Util.getUserAgent(this._userAgent);
    return userAgent;
  }

  async getAccessKeyId(): Promise<string> {
    if (Util.isUnset(this._credential)) {
      return "";
    }

    let accessKeyId = await this._credential.getAccessKeyId();
    return accessKeyId;
  }

  async getAccessKeySecret(): Promise<string> {
    if (Util.isUnset(this._credential)) {
      return "";
    }

    let secret = await this._credential.getAccessKeySecret();
    return secret;
  }

  async getSecurityToken(): Promise<string> {
    if (Util.isUnset(this._credential)) {
      return "";
    }

    let token = await this._credential.getSecurityToken();
    return token;
  }

}
