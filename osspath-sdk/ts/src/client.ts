// This file is auto-generated, don't edit it
import * as $tea from '@alicloud/tea-typescript';
import BaseClient from '@alicloud/ccp-baseclient';

export class RuntimeOptions extends $tea.Model {
  autoretry: boolean
  ignoreSSL: boolean
  maxAttempts: number
  backoffPolicy: string
  backoffPeriod: number
  readTimeout: number
  connectTimeout: number
  httpProxy: string
  httpsProxy: string
  noProxy: string
  maxIdleConns: number
  localAddr: string
  socks5Proxy: string
  socks5NetWork: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class Config extends $tea.Model {
  endpoint?: string
  domainId?: string
  protocol?: string
  credentialType?: string
  securityToken?: string
  accessKeyId?: string
  accessKeySecret?: string
  clientId?: string
  refreshToken?: string
  clientSecret?: string
  accessToken?: string
  expireTime?: string
  static names(): { [key: string]: string } {
    return {
      endpoint: 'endpoint',
      domainId: 'domainId',
      protocol: 'protocol',
      credentialType: 'credentialType',
      securityToken: 'securityToken',
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
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
      protocol: 'string',
      credentialType: 'string',
      securityToken: 'string',
      accessKeyId: 'string',
      accessKeySecret: 'string',
      clientId: 'string',
      refreshToken: 'string',
      clientSecret: 'string',
      accessToken: 'string',
      expireTime: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class AccountAccessTokenResponse extends $tea.Model {
  requestId?: string
  accessToken: string
  avatar?: string
  defaultDriveId?: string
  existLink?: LinkInfo[]
  expireTime?: string
  expiresIn?: number
  needLink: boolean
  nickName?: string
  refreshToken?: string
  role?: string
  state?: string
  tokenType?: string
  userId?: string
  userName?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      accessToken: 'access_token',
      avatar: 'avatar',
      defaultDriveId: 'default_drive_id',
      existLink: 'exist_link',
      expireTime: 'expire_time',
      expiresIn: 'expires_in',
      needLink: 'need_link',
      nickName: 'nick_name',
      refreshToken: 'refresh_token',
      role: 'role',
      state: 'state',
      tokenType: 'token_type',
      userId: 'user_id',
      userName: 'user_name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      accessToken: 'string',
      avatar: 'string',
      defaultDriveId: 'string',
      existLink: { 'type': 'array', 'itemType': LinkInfo },
      expireTime: 'string',
      expiresIn: 'number',
      needLink: 'boolean',
      nickName: 'string',
      refreshToken: 'string',
      role: 'string',
      state: 'string',
      tokenType: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class AccountLinkRequest extends $tea.Model {
  detail?: string
  identity: string
  status?: string
  type: string
  userId: string
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
      identity: 'identity',
      status: 'status',
      type: 'type',
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: 'string',
      identity: 'string',
      status: 'string',
      type: 'string',
      userId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class AddStoreRequest extends $tea.Model {
  basePath?: string
  bucket?: string
  domainId: string
  endpoint: string
  ownership?: string
  roleArn?: string
  type: string
  static names(): { [key: string]: string } {
    return {
      basePath: 'base_path',
      bucket: 'bucket',
      domainId: 'domain_id',
      endpoint: 'endpoint',
      ownership: 'ownership',
      roleArn: 'role_arn',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      basePath: 'string',
      bucket: 'string',
      domainId: 'string',
      endpoint: 'string',
      ownership: 'string',
      roleArn: 'string',
      type: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class AppAccessStrategy extends $tea.Model {
  effect?: string
  exceptAppIdList?: string[]
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class AuthConfig extends $tea.Model {
  appId?: string
  appSecret?: string
  enable?: boolean
  endpoint?: string
  enterpriseId?: string
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      appSecret: 'app_secret',
      enable: 'enable',
      endpoint: 'endpoint',
      enterpriseId: 'enterprise_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      appSecret: 'string',
      enable: 'boolean',
      endpoint: 'string',
      enterpriseId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseCCPFileResponse extends $tea.Model {
  requestId?: string
  category?: string
  contentHash?: string
  contentHashName?: string
  contentType?: string
  crc64Hash?: string
  createdAt?: string
  description?: string
  domainId?: string
  downloadUrl?: string
  driveId?: string
  fileExtension?: string
  fileId?: string
  hidden?: boolean
  imageMediaMetadata?: ImageMediaResponse[]
  labels?: string[]
  meta?: string
  name: string
  parentFileId?: string
  size?: number
  starred?: boolean
  status?: string
  thumbnail?: string
  trashedAt?: string
  type?: string
  updatedAt?: string
  uploadId?: string
  url?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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
      fileExtension: 'string',
      fileId: 'string',
      hidden: 'boolean',
      imageMediaMetadata: { 'type': 'array', 'itemType': ImageMediaResponse },
      labels: { 'type': 'array', 'itemType': 'string' },
      meta: 'string',
      name: 'string',
      parentFileId: 'string',
      size: 'number',
      starred: 'boolean',
      status: 'string',
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseDriveResponse extends $tea.Model {
  requestId?: string
  creator?: string
  description?: string
  domainId?: string
  driveId?: string
  driveName?: string
  driveType?: string
  owner?: string
  relativePath?: string
  status?: string
  storeId?: string
  totalSize?: number
  usedSize?: number
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      creator: 'creator',
      description: 'description',
      domainId: 'domain_id',
      driveId: 'drive_id',
      driveName: 'drive_name',
      driveType: 'drive_type',
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
      requestId: 'string',
      creator: 'string',
      description: 'string',
      domainId: 'string',
      driveId: 'string',
      driveName: 'string',
      driveType: 'string',
      owner: 'string',
      relativePath: 'string',
      status: 'string',
      storeId: 'string',
      totalSize: 'number',
      usedSize: 'number',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseOSSFileResponse extends $tea.Model {
  requestId?: string
  contentHash?: string
  contentHashName?: string
  contentType?: string
  crc64Hash?: string
  createdAt?: string
  description?: string
  domainId?: string
  downloadUrl?: string
  driveId?: string
  fileExtension?: string
  filePath?: string
  name: string
  parentFilePath?: string
  shareId?: string
  size?: number
  status?: string
  thumbnail?: string
  trashedAt?: string
  type?: string
  updatedAt?: string
  uploadId?: string
  url?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseShareResponse extends $tea.Model {
  requestId?: string
  createdAt?: string
  creator?: string
  description?: string
  domainId?: string
  driveId?: string
  expiration?: string
  expired?: boolean
  owner?: string
  permissions?: string[]
  shareFilePath?: string
  shareId?: string
  shareName?: string
  status?: string
  updatedAt?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      status: 'status',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
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
      status: 'string',
      updatedAt: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSubResponse extends $tea.Model {
  requestId?: string
  body?: object
  id?: string
  status?: number
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      body: 'body',
      id: 'id',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      body: 'object',
      id: 'string',
      status: 'number',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPBatchResponse extends $tea.Model {
  requestId?: string
  responses?: BatchSubResponse[]
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      responses: 'responses',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      responses: { 'type': 'array', 'itemType': BatchSubResponse },
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPCompleteFileResponse extends $tea.Model {
  requestId?: string
  category?: string
  contentHash?: string
  contentHashName?: string
  contentType?: string
  crc64Hash?: string
  createdAt?: string
  description?: string
  domainId?: string
  downloadUrl?: string
  driveId?: string
  fileExtension?: string
  fileId?: string
  hidden?: boolean
  imageMediaMetadata?: ImageMediaResponse[]
  labels?: string[]
  meta?: string
  name: string
  parentFileId?: string
  size?: number
  starred?: boolean
  status?: string
  thumbnail?: string
  trashedAt?: string
  type?: string
  updatedAt?: string
  uploadId?: string
  url?: string
  crc?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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
      fileExtension: 'string',
      fileId: 'string',
      hidden: 'boolean',
      imageMediaMetadata: { 'type': 'array', 'itemType': ImageMediaResponse },
      labels: { 'type': 'array', 'itemType': 'string' },
      meta: 'string',
      name: 'string',
      parentFileId: 'string',
      size: 'number',
      starred: 'boolean',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPCopyFileResponse extends $tea.Model {
  requestId?: string
  asyncTaskId?: string
  domainId?: string
  driveId?: string
  fileId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      fileId: 'file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      fileId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPCreateFileResponse extends $tea.Model {
  requestId?: string
  domainId?: string
  driveId?: string
  fileId?: string
  parentFileId?: string
  partInfoList?: UploadPartInfo[]
  rapidUpload?: boolean
  type?: string
  uploadId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      domainId: 'domain_id',
      driveId: 'drive_id',
      fileId: 'file_id',
      parentFileId: 'parent_file_id',
      partInfoList: 'part_info_list',
      rapidUpload: 'rapid_upload',
      type: 'type',
      uploadId: 'upload_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      domainId: 'string',
      driveId: 'string',
      fileId: 'string',
      parentFileId: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      rapidUpload: 'boolean',
      type: 'string',
      uploadId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPDeleteFileResponse extends $tea.Model {
  requestId?: string
  asyncTaskId?: string
  domainId?: string
  driveId?: string
  fileId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      fileId: 'file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      fileId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPDeleteFilesResponse extends $tea.Model {
  requestId?: string
  deletedFileIdList?: string[]
  domainId?: string
  driveId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      deletedFileIdList: 'deleted_file_id_list',
      domainId: 'domain_id',
      driveId: 'drive_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      deletedFileIdList: { 'type': 'array', 'itemType': 'string' },
      domainId: 'string',
      driveId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPGetAsyncTaskResponse extends $tea.Model {
  requestId?: string
  asyncTaskId?: string
  message?: string
  state?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      asyncTaskId: 'async_task_id',
      message: 'message',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      asyncTaskId: 'string',
      message: 'string',
      state: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPGetDownloadUrlResponse extends $tea.Model {
  requestId?: string
  expiration?: string
  method?: string
  url?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      expiration: 'expiration',
      method: 'method',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      expiration: 'string',
      method: 'string',
      url: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPGetFileResponse extends $tea.Model {
  requestId?: string
  category?: string
  contentHash?: string
  contentHashName?: string
  contentType?: string
  crc64Hash?: string
  createdAt?: string
  description?: string
  domainId?: string
  downloadUrl?: string
  driveId?: string
  fileExtension?: string
  fileId?: string
  hidden?: boolean
  imageMediaMetadata?: ImageMediaResponse[]
  labels?: string[]
  meta?: string
  name: string
  parentFileId?: string
  size?: number
  starred?: boolean
  status?: string
  thumbnail?: string
  trashedAt?: string
  type?: string
  updatedAt?: string
  uploadId?: string
  url?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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
      fileExtension: 'string',
      fileId: 'string',
      hidden: 'boolean',
      imageMediaMetadata: { 'type': 'array', 'itemType': ImageMediaResponse },
      labels: { 'type': 'array', 'itemType': 'string' },
      meta: 'string',
      name: 'string',
      parentFileId: 'string',
      size: 'number',
      starred: 'boolean',
      status: 'string',
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPGetUploadUrlResponse extends $tea.Model {
  requestId?: string
  createAt?: string
  domainId?: string
  driveId?: string
  fileId?: string
  partInfoList?: UploadPartInfo[]
  uploadId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
      createAt: 'string',
      domainId: 'string',
      driveId: 'string',
      fileId: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      uploadId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPListFileResponse extends $tea.Model {
  requestId?: string
  items?: BaseCCPFileResponse[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': BaseCCPFileResponse },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPListUploadedPartResponse extends $tea.Model {
  requestId?: string
  fileId?: string
  nextPartNumberMarker?: string
  uploadId?: string
  uploadedParts?: UploadPartInfo[]
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      fileId: 'file_id',
      nextPartNumberMarker: 'next_part_number_marker',
      uploadId: 'upload_id',
      uploadedParts: 'uploaded_parts',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      fileId: 'string',
      nextPartNumberMarker: 'string',
      uploadId: 'string',
      uploadedParts: { 'type': 'array', 'itemType': UploadPartInfo },
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPMoveFileResponse extends $tea.Model {
  requestId?: string
  asyncTaskId?: string
  domainId?: string
  driveId?: string
  fileId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      fileId: 'file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      fileId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPSearchFileResponse extends $tea.Model {
  requestId?: string
  items?: BaseCCPFileResponse[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': BaseCCPFileResponse },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPUpdateFileMetaResponse extends $tea.Model {
  requestId?: string
  category?: string
  contentHash?: string
  contentHashName?: string
  contentType?: string
  crc64Hash?: string
  createdAt?: string
  description?: string
  domainId?: string
  downloadUrl?: string
  driveId?: string
  fileExtension?: string
  fileId?: string
  hidden?: boolean
  imageMediaMetadata?: ImageMediaResponse[]
  labels?: string[]
  meta?: string
  name: string
  parentFileId?: string
  size?: number
  starred?: boolean
  status?: string
  thumbnail?: string
  trashedAt?: string
  type?: string
  updatedAt?: string
  uploadId?: string
  url?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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
      fileExtension: 'string',
      fileId: 'string',
      hidden: 'boolean',
      imageMediaMetadata: { 'type': 'array', 'itemType': ImageMediaResponse },
      labels: { 'type': 'array', 'itemType': 'string' },
      meta: 'string',
      name: 'string',
      parentFileId: 'string',
      size: 'number',
      starred: 'boolean',
      status: 'string',
      thumbnail: 'string',
      trashedAt: 'string',
      type: 'string',
      updatedAt: 'string',
      uploadId: 'string',
      url: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CancelLinkRequest extends $tea.Model {
  temporaryToken: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class Captcha extends $tea.Model {
  captcha: string
  captchaFormat: string
  captchaId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ConfirmLinkRequest extends $tea.Model {
  temporaryToken: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CorsRule extends $tea.Model {
  allowedHeader?: string[]
  allowedMethod?: string[]
  allowedOrigin?: string[]
  exposeHeader?: string[]
  maxAgeSeconds?: number
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAppRequest extends $tea.Model {
  appName: string
  description?: string
  isThirdParty?: boolean
  logo: string
  redirectUri?: string
  scope: string[]
  type: string
  static names(): { [key: string]: string } {
    return {
      appName: 'app_name',
      description: 'description',
      isThirdParty: 'is_third_party',
      logo: 'logo',
      redirectUri: 'redirect_uri',
      scope: 'scope',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appName: 'string',
      description: 'string',
      isThirdParty: 'boolean',
      logo: 'string',
      redirectUri: 'string',
      scope: { 'type': 'array', 'itemType': 'string' },
      type: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDomainRequest extends $tea.Model {
  authAlipayAppId?: string
  authAlipayEnbale?: boolean
  authAlipayPrivateKey?: string
  authConfig?: object
  authDingdingAppId?: string
  authDingdingAppSecret?: string
  authDingdingEnable?: boolean
  authEndpointEnable?: boolean
  authRamAppId?: string
  authRamAppSecret?: string
  authRamEnable?: boolean
  dataHashName?: string
  description?: string
  domainName: string
  eventFilenameMatches?: string
  eventMnsEndpoint?: string
  eventMnsTopic?: string
  eventNames?: string[]
  eventRoleArn?: string
  initDriveEnable?: boolean
  initDriveSize?: number
  pathType: string
  publishedAppAccessStrategy?: AppAccessStrategy[]
  sharable?: boolean
  storeLevel?: string
  storeRegionList: string[]
  static names(): { [key: string]: string } {
    return {
      authAlipayAppId: 'auth_alipay_app_id',
      authAlipayEnbale: 'auth_alipay_enbale',
      authAlipayPrivateKey: 'auth_alipay_private_key',
      authConfig: 'auth_config',
      authDingdingAppId: 'auth_dingding_app_id',
      authDingdingAppSecret: 'auth_dingding_app_secret',
      authDingdingEnable: 'auth_dingding_enable',
      authEndpointEnable: 'auth_endpoint_enable',
      authRamAppId: 'auth_ram_app_id',
      authRamAppSecret: 'auth_ram_app_secret',
      authRamEnable: 'auth_ram_enable',
      dataHashName: 'data_hash_name',
      description: 'description',
      domainName: 'domain_name',
      eventFilenameMatches: 'event_filename_matches',
      eventMnsEndpoint: 'event_mns_endpoint',
      eventMnsTopic: 'event_mns_topic',
      eventNames: 'event_names',
      eventRoleArn: 'event_role_arn',
      initDriveEnable: 'init_drive_enable',
      initDriveSize: 'init_drive_size',
      pathType: 'path_type',
      publishedAppAccessStrategy: 'published_app_access_strategy',
      sharable: 'sharable',
      storeLevel: 'store_level',
      storeRegionList: 'store_region_list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authAlipayAppId: 'string',
      authAlipayEnbale: 'boolean',
      authAlipayPrivateKey: 'string',
      authConfig: 'object',
      authDingdingAppId: 'string',
      authDingdingAppSecret: 'string',
      authDingdingEnable: 'boolean',
      authEndpointEnable: 'boolean',
      authRamAppId: 'string',
      authRamAppSecret: 'string',
      authRamEnable: 'boolean',
      dataHashName: 'string',
      description: 'string',
      domainName: 'string',
      eventFilenameMatches: 'string',
      eventMnsEndpoint: 'string',
      eventMnsTopic: 'string',
      eventNames: { 'type': 'array', 'itemType': 'string' },
      eventRoleArn: 'string',
      initDriveEnable: 'boolean',
      initDriveSize: 'number',
      pathType: 'string',
      publishedAppAccessStrategy: { 'type': 'array', 'itemType': AppAccessStrategy },
      sharable: 'boolean',
      storeLevel: 'string',
      storeRegionList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDriveResponse extends $tea.Model {
  requestId?: string
  domainId?: string
  driveId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      domainId: 'domain_id',
      driveId: 'drive_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      domainId: 'string',
      driveId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CreateShareResponse extends $tea.Model {
  requestId?: string
  domainId?: string
  shareId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      domainId: 'domain_id',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      domainId: 'string',
      shareId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DefaultChangePasswordRequest extends $tea.Model {
  appId: string
  newPassword: string
  phoneNumber: string
  smsCode: string
  smsCodeId: string
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      newPassword: 'new_password',
      phoneNumber: 'phone_number',
      smsCode: 'sms_code',
      smsCodeId: 'sms_code_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      newPassword: 'string',
      phoneNumber: 'string',
      smsCode: 'string',
      smsCodeId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DefaultSetPasswordRequest extends $tea.Model {
  appId: string
  newPassword: string
  state: string
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      newPassword: 'new_password',
      state: 'state',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      newPassword: 'string',
      state: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAppRequest extends $tea.Model {
  appId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDomainRequest extends $tea.Model {
  domainId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDriveResponse extends $tea.Model {
  requestId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccessTokenByLinkInfoRequest extends $tea.Model {
  identity: string
  type: string
  static names(): { [key: string]: string } {
    return {
      identity: 'identity',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      identity: 'string',
      type: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppRequest extends $tea.Model {
  appId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetByLinkInfoRequest extends $tea.Model {
  identity: string
  type: string
  static names(): { [key: string]: string } {
    return {
      identity: 'identity',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      identity: 'string',
      type: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetCaptchaRequest extends $tea.Model {
  appId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainRequest extends $tea.Model {
  domainId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetDriveResponse extends $tea.Model {
  requestId?: string
  creator?: string
  description?: string
  domainId?: string
  driveId?: string
  driveName?: string
  driveType?: string
  owner?: string
  relativePath?: string
  status?: string
  storeId?: string
  totalSize?: number
  usedSize?: number
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      creator: 'creator',
      description: 'description',
      domainId: 'domain_id',
      driveId: 'drive_id',
      driveName: 'drive_name',
      driveType: 'drive_type',
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
      requestId: 'string',
      creator: 'string',
      description: 'string',
      domainId: 'string',
      driveId: 'string',
      driveName: 'string',
      driveType: 'string',
      owner: 'string',
      relativePath: 'string',
      status: 'string',
      storeId: 'string',
      totalSize: 'number',
      usedSize: 'number',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetLinkInfoByUserIDRequest extends $tea.Model {
  userId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareResponse extends $tea.Model {
  requestId?: string
  createdAt?: string
  creator?: string
  description?: string
  domainId?: string
  driveId?: string
  expiration?: string
  expired?: boolean
  owner?: string
  permissions?: string[]
  shareFilePath?: string
  shareId?: string
  shareName?: string
  status?: string
  updatedAt?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      status: 'status',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
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
      status: 'string',
      updatedAt: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ImageMediaResponse extends $tea.Model {
  requestId?: string
  height?: number
  time?: string
  width?: number
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      height: 'height',
      time: 'time',
      width: 'width',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      height: 'number',
      time: 'string',
      width: 'number',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class LinkInfo extends $tea.Model {
  identity?: string
  type?: string
  static names(): { [key: string]: string } {
    return {
      identity: 'identity',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      identity: 'string',
      type: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class LinkInfoListResponse extends $tea.Model {
  requestId?: string
  items: LinkInfoResponse[]
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': LinkInfoResponse },
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class LinkInfoResponse extends $tea.Model {
  requestId?: string
  authenticationType: string
  createdAt: number
  domainId: string
  identity: string
  lastLoginTime: number
  status: string
  userId: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      authenticationType: 'authentication_type',
      createdAt: 'created_at',
      domainId: 'domain_id',
      identity: 'identity',
      lastLoginTime: 'last_login_time',
      status: 'status',
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      authenticationType: 'string',
      createdAt: 'number',
      domainId: 'string',
      identity: 'string',
      lastLoginTime: 'number',
      status: 'string',
      userId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListAppsRequest extends $tea.Model {
  limit?: number
  marker?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListDomainsRequest extends $tea.Model {
  limit?: number
  marker?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListDriveResponse extends $tea.Model {
  requestId?: string
  items?: BaseDriveResponse[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': BaseDriveResponse },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListShareResponse extends $tea.Model {
  requestId?: string
  items?: BaseShareResponse[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': BaseShareResponse },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListStoreFileResponse extends $tea.Model {
  requestId?: string
  items?: StoreFile[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': StoreFile },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListStoreResponse extends $tea.Model {
  requestId?: string
  items?: StoreItemResponse[]
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': StoreItemResponse },
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListStoresRequest extends $tea.Model {
  domainId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class LoginByCodeRequest extends $tea.Model {
  accessToken?: string
  appId: string
  authCode?: string
  type: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class MobileCheckExistRequest extends $tea.Model {
  appId: string
  phoneNumber: string
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      phoneNumber: 'phone_number',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      phoneNumber: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class MobileCheckExistResponse extends $tea.Model {
  requestId?: string
  isExist: boolean
  phoneNumber: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      isExist: 'is_exist',
      phoneNumber: 'phone_number',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      isExist: 'boolean',
      phoneNumber: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class MobileLoginRequest extends $tea.Model {
  appId: string
  autoRegister?: boolean
  captchaId?: string
  captchaText?: string
  password?: string
  phoneNumber: string
  smsCode?: string
  smsCodeId?: string
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      autoRegister: 'auto_register',
      captchaId: 'captcha_id',
      captchaText: 'captcha_text',
      password: 'password',
      phoneNumber: 'phone_number',
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
      password: 'string',
      phoneNumber: 'string',
      smsCode: 'string',
      smsCodeId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class MobileRegisterRequest extends $tea.Model {
  appId: string
  phoneNumber: string
  smsCode: string
  smsCodeId: string
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      phoneNumber: 'phone_number',
      smsCode: 'sms_code',
      smsCodeId: 'sms_code_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      phoneNumber: 'string',
      smsCode: 'string',
      smsCodeId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class MobileSendSmsCodeRequest extends $tea.Model {
  appId: string
  captchaId?: string
  captchaText?: string
  phoneNumber: string
  type: string
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      captchaId: 'captcha_id',
      captchaText: 'captcha_text',
      phoneNumber: 'phone_number',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      captchaId: 'string',
      captchaText: 'string',
      phoneNumber: 'string',
      type: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class MobileSendSmsCodeResponse extends $tea.Model {
  requestId?: string
  smsCodeId: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      smsCodeId: 'sms_code_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      smsCodeId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSCompleteFileResponse extends $tea.Model {
  requestId?: string
  contentHash?: string
  contentHashName?: string
  contentType?: string
  crc64Hash?: string
  createdAt?: string
  description?: string
  domainId?: string
  downloadUrl?: string
  driveId?: string
  fileExtension?: string
  filePath?: string
  name: string
  parentFilePath?: string
  shareId?: string
  size?: number
  status?: string
  thumbnail?: string
  trashedAt?: string
  type?: string
  updatedAt?: string
  uploadId?: string
  url?: string
  crc?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSCopyFileResponse extends $tea.Model {
  requestId?: string
  asyncTaskId?: string
  domainId?: string
  driveId?: string
  filePath?: string
  shareId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSCreateFileResponse extends $tea.Model {
  requestId?: string
  domainId?: string
  driveId?: string
  filePath?: string
  partInfoList?: UploadPartInfo[]
  shareId?: string
  type?: string
  uploadId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
      domainId: 'string',
      driveId: 'string',
      filePath: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      shareId: 'string',
      type: 'string',
      uploadId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSDeleteFileResponse extends $tea.Model {
  requestId?: string
  asyncTaskId?: string
  domainId?: string
  driveId?: string
  filePath?: string
  shareId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSDeleteFilesResponse extends $tea.Model {
  requestId?: string
  deletedFileIdList?: string[]
  domainId?: string
  driveId?: string
  shareId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      deletedFileIdList: 'deleted_file_id_list',
      domainId: 'domain_id',
      driveId: 'drive_id',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      deletedFileIdList: { 'type': 'array', 'itemType': 'string' },
      domainId: 'string',
      driveId: 'string',
      shareId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSGetDownloadUrlResponse extends $tea.Model {
  requestId?: string
  expiration?: string
  method?: string
  url?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      expiration: 'expiration',
      method: 'method',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      expiration: 'string',
      method: 'string',
      url: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSGetFileResponse extends $tea.Model {
  requestId?: string
  contentHash?: string
  contentHashName?: string
  contentType?: string
  crc64Hash?: string
  createdAt?: string
  description?: string
  domainId?: string
  downloadUrl?: string
  driveId?: string
  fileExtension?: string
  filePath?: string
  name: string
  parentFilePath?: string
  shareId?: string
  size?: number
  status?: string
  thumbnail?: string
  trashedAt?: string
  type?: string
  updatedAt?: string
  uploadId?: string
  url?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSGetUploadUrlResponse extends $tea.Model {
  requestId?: string
  createAt?: string
  domainId?: string
  driveId?: string
  filePath?: string
  partInfoList?: UploadPartInfo[]
  uploadId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
      createAt: 'string',
      domainId: 'string',
      driveId: 'string',
      filePath: 'string',
      partInfoList: { 'type': 'array', 'itemType': UploadPartInfo },
      uploadId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSListFileResponse extends $tea.Model {
  requestId?: string
  items?: BaseOSSFileResponse[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': BaseOSSFileResponse },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSListUploadedPartResponse extends $tea.Model {
  requestId?: string
  filePath?: string
  nextPartNumberMarker?: string
  uploadId?: string
  uploadedParts?: UploadPartInfo[]
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      filePath: 'file_path',
      nextPartNumberMarker: 'next_part_number_marker',
      uploadId: 'upload_id',
      uploadedParts: 'uploaded_parts',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      filePath: 'string',
      nextPartNumberMarker: 'string',
      uploadId: 'string',
      uploadedParts: { 'type': 'array', 'itemType': UploadPartInfo },
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSMoveFileResponse extends $tea.Model {
  requestId?: string
  asyncTaskId?: string
  domainId?: string
  driveId?: string
  filePath?: string
  shareId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      asyncTaskId: 'async_task_id',
      domainId: 'domain_id',
      driveId: 'drive_id',
      filePath: 'file_path',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      asyncTaskId: 'string',
      domainId: 'string',
      driveId: 'string',
      filePath: 'string',
      shareId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSSearchFileResponse extends $tea.Model {
  requestId?: string
  items?: BaseOSSFileResponse[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': BaseOSSFileResponse },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSUpdateFileMetaResponse extends $tea.Model {
  requestId?: string
  contentHash?: string
  contentHashName?: string
  contentType?: string
  crc64Hash?: string
  createdAt?: string
  description?: string
  domainId?: string
  downloadUrl?: string
  driveId?: string
  fileExtension?: string
  filePath?: string
  name: string
  parentFilePath?: string
  shareId?: string
  size?: number
  status?: string
  thumbnail?: string
  trashedAt?: string
  type?: string
  updatedAt?: string
  uploadId?: string
  url?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class PreHashCheckSuccessResponse extends $tea.Model {
  requestId?: string
  code?: string
  fileName?: string
  message?: string
  parentFileId: string
  preHash?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      code: 'code',
      fileName: 'file_name',
      message: 'message',
      parentFileId: 'parent_file_id',
      preHash: 'pre_hash',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      code: 'string',
      fileName: 'string',
      message: 'string',
      parentFileId: 'string',
      preHash: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveStoreRequest extends $tea.Model {
  domainId: string
  storeId: string
  static names(): { [key: string]: string } {
    return {
      domainId: 'domain_id',
      storeId: 'store_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domainId: 'string',
      storeId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class SetStoreCorsRequest extends $tea.Model {
  corsRule: CorsRule[]
  domainId: string
  storeId: string
  static names(): { [key: string]: string } {
    return {
      corsRule: 'cors_rule',
      domainId: 'domain_id',
      storeId: 'store_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corsRule: { 'type': 'array', 'itemType': CorsRule },
      domainId: 'string',
      storeId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class StoreFile extends $tea.Model {
  domainId?: string
  name?: string
  parentFilePath?: string
  storeId?: string
  type?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class StoreItemResponse extends $tea.Model {
  requestId?: string
  accelerateEndpoint?: string
  basePath?: string
  bucket: string
  customizedEndpoint?: string
  domainId?: string
  endpoint: string
  internalEndpoint?: string
  ownership: string
  policy: string
  roleArn?: string
  storeId: string
  type: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class TokenRequest extends $tea.Model {
  appId: string
  grantType: string
  refreshToken: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAppRequest extends $tea.Model {
  appId: string
  appName: string
  description?: string
  isThirdParty: boolean
  logo: string
  redirectUri: string
  scope: string[]
  type: string
  static names(): { [key: string]: string } {
    return {
      appId: 'app_id',
      appName: 'app_name',
      description: 'description',
      isThirdParty: 'is_third_party',
      logo: 'logo',
      redirectUri: 'redirect_uri',
      scope: 'scope',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      appName: 'string',
      description: 'string',
      isThirdParty: 'boolean',
      logo: 'string',
      redirectUri: 'string',
      scope: { 'type': 'array', 'itemType': 'string' },
      type: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDomainRequest extends $tea.Model {
  authAlipayAppId?: string
  authAlipayEnbale?: boolean
  authAlipayPrivateKey?: string
  authConfig?: object
  authDingdingAppId?: string
  authDingdingAppSecret?: string
  authDingdingEnable?: boolean
  authEndpointEnable?: boolean
  authRamAppId?: string
  authRamAppSecret?: string
  authRamEnable?: boolean
  dataHashName?: string
  description?: string
  domainId: string
  domainName?: string
  eventFilenameMatches?: string
  eventMnsEndpoint?: string
  eventMnsTopic?: string
  eventNames?: string[]
  eventRoleArn?: string
  initDriveEnable?: boolean
  initDriveSize?: number
  initDriveStoreId?: string
  publishedAppAccessStrategy?: AppAccessStrategy[]
  sharable?: boolean
  static names(): { [key: string]: string } {
    return {
      authAlipayAppId: 'auth_alipay_app_id',
      authAlipayEnbale: 'auth_alipay_enbale',
      authAlipayPrivateKey: 'auth_alipay_private_key',
      authConfig: 'auth_config',
      authDingdingAppId: 'auth_dingding_app_id',
      authDingdingAppSecret: 'auth_dingding_app_secret',
      authDingdingEnable: 'auth_dingding_enable',
      authEndpointEnable: 'auth_endpoint_enable',
      authRamAppId: 'auth_ram_app_id',
      authRamAppSecret: 'auth_ram_app_secret',
      authRamEnable: 'auth_ram_enable',
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
      publishedAppAccessStrategy: 'published_app_access_strategy',
      sharable: 'sharable',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authAlipayAppId: 'string',
      authAlipayEnbale: 'boolean',
      authAlipayPrivateKey: 'string',
      authConfig: 'object',
      authDingdingAppId: 'string',
      authDingdingAppSecret: 'string',
      authDingdingEnable: 'boolean',
      authEndpointEnable: 'boolean',
      authRamAppId: 'string',
      authRamAppSecret: 'string',
      authRamEnable: 'boolean',
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
      publishedAppAccessStrategy: { 'type': 'array', 'itemType': AppAccessStrategy },
      sharable: 'boolean',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDriveResponse extends $tea.Model {
  requestId?: string
  creator?: string
  description?: string
  domainId?: string
  driveId?: string
  driveName?: string
  driveType?: string
  owner?: string
  relativePath?: string
  status?: string
  storeId?: string
  totalSize?: number
  usedSize?: number
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      creator: 'creator',
      description: 'description',
      domainId: 'domain_id',
      driveId: 'drive_id',
      driveName: 'drive_name',
      driveType: 'drive_type',
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
      requestId: 'string',
      creator: 'string',
      description: 'string',
      domainId: 'string',
      driveId: 'string',
      driveName: 'string',
      driveType: 'string',
      owner: 'string',
      relativePath: 'string',
      status: 'string',
      storeId: 'string',
      totalSize: 'number',
      usedSize: 'number',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateShareResponse extends $tea.Model {
  requestId?: string
  createdAt?: string
  creator?: string
  description?: string
  domainId?: string
  driveId?: string
  expiration?: string
  expired?: boolean
  owner?: string
  permissions?: string[]
  shareFilePath?: string
  shareId?: string
  shareName?: string
  status?: string
  updatedAt?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      status: 'status',
      updatedAt: 'updated_at',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
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
      status: 'string',
      updatedAt: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UploadPartInfo extends $tea.Model {
  etag?: string
  partNumber?: number
  partSize?: number
  uploadUrl?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UserAuthentication extends $tea.Model {
  AuthenticationType: string
  CreatedAt: number
  Detail: string
  DomainID: string
  Identity: string
  LastLoginTime: number
  Status: string
  UserID: string
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
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class AccessTokenResponse extends $tea.Model {
  requestId?: string
  accessToken: string
  expiresTime?: string
  refreshToken?: string
  role?: string
  tokenType?: string
  userId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      accessToken: 'access_token',
      expiresTime: 'expires_time',
      refreshToken: 'refresh_token',
      role: 'role',
      tokenType: 'token_type',
      userId: 'user_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      accessToken: 'string',
      expiresTime: 'string',
      refreshToken: 'string',
      role: 'string',
      tokenType: 'string',
      userId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class AddStoreResponse extends $tea.Model {
  requestId?: string
  accelerateEndpoint?: string
  basePath?: string
  bucket: string
  customizedEndpoint?: string
  domainId: string
  endpoint: string
  internalEndpoint?: string
  ownership: string
  policy: string
  roleArn?: string
  storeId: string
  type: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class AdminListStoresRequest extends $tea.Model {
  static names(): { [key: string]: string } {
    return {
    };
  }

  static types(): { [key: string]: any } {
    return {
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseDomainResponse extends $tea.Model {
  requestId?: string
  authAlipayAppId?: string
  authAlipayEnable?: boolean
  authAlipayPrivateKey?: string
  authConfig?: object
  authDingdingAppId?: string
  authDingdingAppSecret?: string
  authDingdingEnable?: boolean
  authEndpointEnable?: boolean
  authRamAppId?: string
  authRamAppSecret?: string
  authRamEnable?: boolean
  createdAt?: string
  dataHashName?: string
  description?: string
  domainId?: string
  domainName?: string
  eventFilenameMatches?: string
  eventMnsEndpoint?: string
  eventMnsTopic?: string
  eventNames?: string[]
  eventRoleArn?: string
  initDriveEnable?: boolean
  initDriveSize?: number
  initDriveStoreId?: string
  pathType?: string
  publishedAppAccessStrategy?: AppAccessStrategy[]
  sharable?: boolean
  storeLevel?: string
  storeRegionList?: string[]
  updatedAt?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
      authAlipayAppId: 'string',
      authAlipayEnable: 'boolean',
      authAlipayPrivateKey: 'string',
      authConfig: 'object',
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
      publishedAppAccessStrategy: { 'type': 'array', 'itemType': AppAccessStrategy },
      sharable: 'boolean',
      storeLevel: 'string',
      storeRegionList: { 'type': 'array', 'itemType': 'string' },
      updatedAt: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDomainResponse extends $tea.Model {
  requestId?: string
  authAlipayAppId?: string
  authAlipayEnable?: boolean
  authAlipayPrivateKey?: string
  authConfig?: object
  authDingdingAppId?: string
  authDingdingAppSecret?: string
  authDingdingEnable?: boolean
  authEndpointEnable?: boolean
  authRamAppId?: string
  authRamAppSecret?: string
  authRamEnable?: boolean
  createdAt?: string
  dataHashName?: string
  description?: string
  domainId?: string
  domainName?: string
  eventFilenameMatches?: string
  eventMnsEndpoint?: string
  eventMnsTopic?: string
  eventNames?: string[]
  eventRoleArn?: string
  initDriveEnable?: boolean
  initDriveSize?: number
  initDriveStoreId?: string
  pathType?: string
  publishedAppAccessStrategy?: AppAccessStrategy[]
  sharable?: boolean
  storeLevel?: string
  storeRegionList?: string[]
  updatedAt?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
      authAlipayAppId: 'string',
      authAlipayEnable: 'boolean',
      authAlipayPrivateKey: 'string',
      authConfig: 'object',
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
      publishedAppAccessStrategy: { 'type': 'array', 'itemType': AppAccessStrategy },
      sharable: 'boolean',
      storeLevel: 'string',
      storeRegionList: { 'type': 'array', 'itemType': 'string' },
      updatedAt: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppResponse extends $tea.Model {
  requestId?: string
  aliOwnerId: string
  appId: string
  appName: string
  appSecret: string
  createdAt: string
  description: string
  logo: string
  provider: string
  redirectUri: string
  scope: string[]
  screenshots: string[]
  stage: string
  type: string
  updatedAt: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainResponse extends $tea.Model {
  requestId?: string
  authAlipayAppId?: string
  authAlipayEnable?: boolean
  authAlipayPrivateKey?: string
  authConfig?: object
  authDingdingAppId?: string
  authDingdingAppSecret?: string
  authDingdingEnable?: boolean
  authEndpointEnable?: boolean
  authRamAppId?: string
  authRamAppSecret?: string
  authRamEnable?: boolean
  createdAt?: string
  dataHashName?: string
  description?: string
  domainId?: string
  domainName?: string
  eventFilenameMatches?: string
  eventMnsEndpoint?: string
  eventMnsTopic?: string
  eventNames?: string[]
  eventRoleArn?: string
  initDriveEnable?: boolean
  initDriveSize?: number
  initDriveStoreId?: string
  pathType?: string
  publishedAppAccessStrategy?: AppAccessStrategy[]
  sharable?: boolean
  storeLevel?: string
  storeRegionList?: string[]
  updatedAt?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
      authAlipayAppId: 'string',
      authAlipayEnable: 'boolean',
      authAlipayPrivateKey: 'string',
      authConfig: 'object',
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
      publishedAppAccessStrategy: { 'type': 'array', 'itemType': AppAccessStrategy },
      sharable: 'boolean',
      storeLevel: 'string',
      storeRegionList: { 'type': 'array', 'itemType': 'string' },
      updatedAt: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserAccessTokenRequest extends $tea.Model {
  role?: string
  userId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListAppsResponse extends $tea.Model {
  requestId?: string
  items: GetAppResponse[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': GetAppResponse },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListDomainsResponse extends $tea.Model {
  requestId?: string
  items?: BaseDomainResponse[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': BaseDomainResponse },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListStoresResponse extends $tea.Model {
  requestId?: string
  items: Store[]
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': Store },
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class Store extends $tea.Model {
  accelerateEndpoint?: string
  basePath?: string
  bucket: string
  customizedEndpoint?: string
  endpoint: string
  internalEndpoint?: string
  ownership: string
  policy: string
  roleArn?: string
  storeId: string
  type: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDomainResponse extends $tea.Model {
  requestId?: string
  authAlipayAppId?: string
  authAlipayEnable?: boolean
  authAlipayPrivateKey?: string
  authConfig?: object
  authDingdingAppId?: string
  authDingdingAppSecret?: string
  authDingdingEnable?: boolean
  authEndpointEnable?: boolean
  authRamAppId?: string
  authRamAppSecret?: string
  authRamEnable?: boolean
  createdAt?: string
  dataHashName?: string
  description?: string
  domainId?: string
  domainName?: string
  eventFilenameMatches?: string
  eventMnsEndpoint?: string
  eventMnsTopic?: string
  eventNames?: string[]
  eventRoleArn?: string
  initDriveEnable?: boolean
  initDriveSize?: number
  initDriveStoreId?: string
  pathType?: string
  publishedAppAccessStrategy?: AppAccessStrategy[]
  sharable?: boolean
  storeLevel?: string
  storeRegionList?: string[]
  updatedAt?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
      authAlipayAppId: 'string',
      authAlipayEnable: 'boolean',
      authAlipayPrivateKey: 'string',
      authConfig: 'object',
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
      publishedAppAccessStrategy: { 'type': 'array', 'itemType': AppAccessStrategy },
      sharable: 'boolean',
      storeLevel: 'string',
      storeRegionList: { 'type': 'array', 'itemType': 'string' },
      updatedAt: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseCompleteFileRequest extends $tea.Model {
  driveId: string
  partInfoList?: UploadPartInfo[]
  uploadId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseCreateFileRequest extends $tea.Model {
  contentMd5: string
  contentType: string
  name: string
  partInfoList?: UploadPartInfo[]
  size: number
  type: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseGetUploadUrlRequest extends $tea.Model {
  contentMd5?: string
  driveId: string
  partInfoList?: UploadPartInfo[]
  uploadId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseListFileRequest extends $tea.Model {
  driveId: string
  imageThumbnailProcess?: string
  imageUrlProcess?: string
  limit?: number
  marker?: string
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      limit: 'limit',
      marker: 'marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      limit: 'number',
      marker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseMoveFileRequest extends $tea.Model {
  driveId: string
  newName?: string
  overwrite?: boolean
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPCompleteFileRequest extends $tea.Model {
  driveId: string
  partInfoList?: UploadPartInfo[]
  uploadId?: string
  fileId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPCopyFileRequest extends $tea.Model {
  driveId: string
  fileId: string
  newName: string
  overwrite?: boolean
  toDriveId: string
  toParentFileId: string
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fileId: 'file_id',
      newName: 'new_name',
      overwrite: 'overwrite',
      toDriveId: 'to_drive_id',
      toParentFileId: 'to_parent_file_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fileId: 'string',
      newName: 'string',
      overwrite: 'boolean',
      toDriveId: 'string',
      toParentFileId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPCreateFileRequest extends $tea.Model {
  contentMd5: string
  contentType: string
  name: string
  partInfoList?: UploadPartInfo[]
  size: number
  type: string
  contentHash?: string
  contentHashName?: string
  description?: string
  driveId: string
  hidden?: boolean
  meta?: string
  parentFileId: string
  preHash?: string
  tags?: object
  static names(): { [key: string]: string } {
    return {
      contentMd5: 'content_md5',
      contentType: 'content_type',
      name: 'name',
      partInfoList: 'part_info_list',
      size: 'size',
      type: 'type',
      contentHash: 'content_hash',
      contentHashName: 'content_hash_name',
      description: 'description',
      driveId: 'drive_id',
      hidden: 'hidden',
      meta: 'meta',
      parentFileId: 'parent_file_id',
      preHash: 'pre_hash',
      tags: 'tags',
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
      contentHash: 'string',
      contentHashName: 'string',
      description: 'string',
      driveId: 'string',
      hidden: 'boolean',
      meta: 'string',
      parentFileId: 'string',
      preHash: 'string',
      tags: 'object',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPDeleteFileRequest extends $tea.Model {
  driveId: string
  fileId: string
  permanently?: boolean
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPDeleteFilesRequest extends $tea.Model {
  driveId: string
  fileIdList: string[]
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPGetAsyncTaskRequest extends $tea.Model {
  asyncTaskId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPGetDownloadUrlRequest extends $tea.Model {
  driveId: string
  expireSec?: number
  fileId: string
  fileName: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPGetFileRequest extends $tea.Model {
  driveId: string
  fileId: string
  imageThumbnailProcess?: string
  imageUrlProcess?: string
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      fileId: 'file_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      fileId: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPGetUploadUrlRequest extends $tea.Model {
  contentMd5?: string
  driveId: string
  partInfoList?: UploadPartInfo[]
  uploadId: string
  fileId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPListFileRequest extends $tea.Model {
  driveId: string
  imageThumbnailProcess?: string
  imageUrlProcess?: string
  limit?: number
  marker?: string
  category?: string
  orderBy?: string
  orderDirection?: string
  parentFileId: string
  status?: string
  type?: string
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      limit: 'limit',
      marker: 'marker',
      category: 'category',
      orderBy: 'order_by',
      orderDirection: 'order_direction',
      parentFileId: 'parent_file_id',
      status: 'status',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      limit: 'number',
      marker: 'string',
      category: 'string',
      orderBy: 'string',
      orderDirection: 'string',
      parentFileId: 'string',
      status: 'string',
      type: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPListUploadedPartRequest extends $tea.Model {
  driveId: string
  fileId: string
  limit: number
  partNumberMarker?: number
  uploadId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPMoveFileRequest extends $tea.Model {
  driveId: string
  newName?: string
  overwrite?: boolean
  fileId: string
  toParentFileId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPSearchFileRequest extends $tea.Model {
  driveId: string
  imageThumbnailProcess?: string
  imageUrlProcess?: string
  limit?: number
  marker?: string
  orderBy?: string
  query?: string
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      limit: 'limit',
      marker: 'marker',
      orderBy: 'order_by',
      query: 'query',
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
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CCPUpdateFileMetaRequest extends $tea.Model {
  description?: string
  driveId: string
  fileId: string
  hidden?: boolean
  meta?: string
  name: string
  starred?: boolean
  tags?: object
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      driveId: 'drive_id',
      fileId: 'file_id',
      hidden: 'hidden',
      meta: 'meta',
      name: 'name',
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
      starred: 'boolean',
      tags: 'object',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CompleteFileRequest extends $tea.Model {
  driveId: string
  fileId: string
  filePath?: string
  partInfoList?: UploadPartInfo[]
  shareId?: string
  uploadId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CopyFileRequest extends $tea.Model {
  driveId: string
  fileId: string
  filePath?: string
  newName: string
  overwrite?: boolean
  shareId?: string
  toDriveId: string
  toParentFileId: string
  toParentFilePath?: string
  toShareId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDriveRequest extends $tea.Model {
  default?: boolean
  description?: string
  driveName: string
  driveType?: string
  owner: string
  relativePath?: string
  status?: string
  storeId?: string
  totalSize?: number
  static names(): { [key: string]: string } {
    return {
      default: 'default',
      description: 'description',
      driveName: 'drive_name',
      driveType: 'drive_type',
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
      owner: 'string',
      relativePath: 'string',
      status: 'string',
      storeId: 'string',
      totalSize: 'number',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CreateFileRequest extends $tea.Model {
  contentHash?: string
  contentHashName?: string
  contentMd5?: string
  contentType: string
  description?: string
  driveId: string
  hidden?: boolean
  meta?: string
  name: string
  parentFileId: string
  parentFilePath?: string
  partInfoList?: UploadPartInfo[]
  preHash?: string
  shareId?: string
  size: number
  tags?: object
  type: string
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
      tags: 'object',
      type: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CreateShareRequest extends $tea.Model {
  description?: string
  driveId: string
  expiration?: string
  owner: string
  permissions?: string[]
  shareFilePath: string
  shareName?: string
  status?: string
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      driveId: 'drive_id',
      expiration: 'expiration',
      owner: 'owner',
      permissions: 'permissions',
      shareFilePath: 'share_file_path',
      shareName: 'share_name',
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
      status: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDriveRequest extends $tea.Model {
  driveId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteFileRequest extends $tea.Model {
  driveId: string
  fileId: string
  filePath?: string
  permanently?: boolean
  shareId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteShareRequest extends $tea.Model {
  shareId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DownloadRequest extends $tea.Model {
  DriveID: string
  FileID: string
  ImageProcess?: string
  ShareID?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetAsyncTaskRequest extends $tea.Model {
  asyncTaskId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetDefaultDriveRequest extends $tea.Model {
  userId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetDownloadUrlRequest extends $tea.Model {
  driveId: string
  expireSec?: number
  fileId: string
  fileName: string
  filePath?: string
  shareId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetDriveRequest extends $tea.Model {
  driveId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileRequest extends $tea.Model {
  driveId: string
  fileId: string
  filePath?: string
  imageThumbnailProcess?: string
  imageUrlProcess?: string
  shareId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetShareRequest extends $tea.Model {
  shareId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlRequest extends $tea.Model {
  contentMd5?: string
  driveId: string
  fileId: string
  filePath?: string
  partInfoList?: UploadPartInfo[]
  shareId?: string
  uploadId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListDriveRequest extends $tea.Model {
  limit?: number
  marker?: string
  owner?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListFileRequest extends $tea.Model {
  all?: boolean
  driveId: string
  imageThumbnailProcess?: string
  imageUrlProcess?: string
  limit?: number
  marker?: string
  parentFileId: string
  parentFilePath?: string
  shareId?: string
  status?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListMyDriveRequest extends $tea.Model {
  limit?: number
  marker?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListShareRequest extends $tea.Model {
  creator: string
  limit: number
  marker?: string
  owner: string
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      limit: 'limit',
      marker: 'marker',
      owner: 'owner',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      limit: 'number',
      marker: 'string',
      owner: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListStorageFileRequest extends $tea.Model {
  limit?: number
  marker?: string
  parentFilePath?: string
  storeId?: string
  type?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListStorageFileResponse extends $tea.Model {
  requestId?: string
  items?: StoreFile[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': StoreFile },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListStorageRequest extends $tea.Model {
  domainId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListStorageResponse extends $tea.Model {
  requestId?: string
  items?: StoreItemResponse[]
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': StoreItemResponse },
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSCompleteFileRequest extends $tea.Model {
  driveId: string
  partInfoList?: UploadPartInfo[]
  uploadId?: string
  filePath?: string
  shareId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSCopyFileRequest extends $tea.Model {
  driveId?: string
  filePath?: string
  newName: string
  overwrite?: boolean
  shareId?: string
  toDriveId: string
  toParentFilePath: string
  toShareId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSCreateFileRequest extends $tea.Model {
  contentMd5: string
  contentType: string
  name: string
  partInfoList?: UploadPartInfo[]
  size: number
  type: string
  driveId: string
  parentFilePath: string
  shareId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSDeleteFileRequest extends $tea.Model {
  driveId: string
  filePath: string
  permanently?: boolean
  shareId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSGetDownloadUrlRequest extends $tea.Model {
  driveId: string
  expireSec?: number
  fileName: string
  filePath: string
  shareId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSGetFileRequest extends $tea.Model {
  driveId: string
  filePath: string
  imageThumbnailProcess?: string
  imageUrlProcess?: string
  shareId?: string
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      filePath: 'file_path',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      shareId: 'share_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      driveId: 'string',
      filePath: 'string',
      imageThumbnailProcess: 'string',
      imageUrlProcess: 'string',
      shareId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSGetUploadUrlRequest extends $tea.Model {
  contentMd5?: string
  driveId: string
  partInfoList?: UploadPartInfo[]
  uploadId: string
  filePath: string
  shareId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSListFileRequest extends $tea.Model {
  driveId: string
  imageThumbnailProcess?: string
  imageUrlProcess?: string
  limit?: number
  marker?: string
  parentFilePath: string
  shareId: string
  static names(): { [key: string]: string } {
    return {
      driveId: 'drive_id',
      imageThumbnailProcess: 'image_thumbnail_process',
      imageUrlProcess: 'image_url_process',
      limit: 'limit',
      marker: 'marker',
      parentFilePath: 'parent_file_path',
      shareId: 'share_id',
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
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSListUploadedPartRequest extends $tea.Model {
  driveId: string
  filePath: string
  limit: number
  partNumberMarker?: number
  shareId?: string
  uploadId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class OSSMoveFileRequest extends $tea.Model {
  driveId: string
  filePath?: string
  newName: string
  overwrite?: boolean
  shareId?: string
  toParentFilePath?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UCGetObjectInfoByObjectKeyRequest extends $tea.Model {
  objectKey?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UCGetObjectInfoBySha1Request extends $tea.Model {
  sha1?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDriveRequest extends $tea.Model {
  description?: string
  driveId: string
  driveName: string
  status?: string
  totalSize?: number
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      driveId: 'drive_id',
      driveName: 'drive_name',
      status: 'status',
      totalSize: 'total_size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      driveId: 'string',
      driveName: 'string',
      status: 'string',
      totalSize: 'number',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFileMetaRequest extends $tea.Model {
  description?: string
  driveId: string
  fileId: string
  hidden?: boolean
  meta?: string
  name: string
  shareId?: string
  starred?: boolean
  tags?: object
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
      tags: 'object',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateShareRequest extends $tea.Model {
  description?: string
  expiration?: string
  permissions?: string[]
  shareId: string
  shareName?: string
  status?: string
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      expiration: 'expiration',
      permissions: 'permissions',
      shareId: 'share_id',
      shareName: 'share_name',
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
      status: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class BaseUserResponse extends $tea.Model {
  requestId?: string
  avatar?: string
  createdAt?: number
  defaultDriveId?: string
  description?: string
  domainId?: string
  email?: string
  nickName?: string
  phone?: string
  role?: string
  status?: string
  updatedAt?: number
  userId?: string
  userName?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserRequest extends $tea.Model {
  avatar?: string
  description?: string
  email?: string
  nickName?: string
  phone?: string
  role?: string
  status?: string
  userId: string
  userName?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserResponse extends $tea.Model {
  requestId?: string
  avatar?: string
  createdAt?: number
  defaultDriveId?: string
  description?: string
  domainId?: string
  email?: string
  nickName?: string
  phone?: string
  role?: string
  status?: string
  updatedAt?: number
  userId?: string
  userName?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUserRequest extends $tea.Model {
  userId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteUserResponse extends $tea.Model {
  requestId?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRequest extends $tea.Model {
  userId?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponse extends $tea.Model {
  requestId?: string
  avatar?: string
  createdAt?: number
  defaultDriveId?: string
  description?: string
  domainId?: string
  email?: string
  nickName?: string
  phone?: string
  role?: string
  status?: string
  updatedAt?: number
  userId?: string
  userName?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserRequest extends $tea.Model {
  limit?: number
  marker?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserResponse extends $tea.Model {
  requestId?: string
  items?: BaseUserResponse[]
  nextMarker?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      items: 'items',
      nextMarker: 'next_marker',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      items: { 'type': 'array', 'itemType': BaseUserResponse },
      nextMarker: 'string',
    };
  }

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserRequest extends $tea.Model {
  email?: string
  limit?: number
  marker?: string
  nickName?: string
  phone?: string
  role?: string
  status?: string
  userName?: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserRequest extends $tea.Model {
  avatar?: string
  description?: string
  email?: string
  nickName?: string
  phone?: string
  role?: string
  status?: string
  userId: string
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserResponse extends $tea.Model {
  requestId?: string
  avatar?: string
  createdAt?: number
  defaultDriveId?: string
  description?: string
  domainId?: string
  email?: string
  nickName?: string
  phone?: string
  role?: string
  status?: string
  updatedAt?: number
  userId?: string
  userName?: string
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
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
      requestId: 'string',
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

  constructor(map: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends BaseClient {
  constructor(config: Config) {
    super(config.toMap());
    super(config.toMap());
  }

  async cancelLink(request: CancelLinkRequest, runtime: RuntimeOptions): Promise<AccountAccessTokenResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/cancel_link`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<AccountAccessTokenResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new AccountAccessTokenResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async confirmLink(request: ConfirmLinkRequest, runtime: RuntimeOptions): Promise<AccountAccessTokenResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/confirm_link`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<AccountAccessTokenResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new AccountAccessTokenResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async changePassword(request: DefaultChangePasswordRequest, runtime: RuntimeOptions): Promise<void>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/default/change_password`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 204)) {
          return ;
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async setPassword(request: DefaultSetPasswordRequest, runtime: RuntimeOptions): Promise<void>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/default/set_password`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 204)) {
          return ;
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getAccessTokenByLinkInfo(request: GetAccessTokenByLinkInfoRequest, runtime: RuntimeOptions): Promise<AccountAccessTokenResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/get_access_token_by_link_info`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<AccountAccessTokenResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new AccountAccessTokenResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getCaptcha(request: GetCaptchaRequest, runtime: RuntimeOptions): Promise<Captcha>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/get_captcha`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<Captcha>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new Captcha({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getLinkInfo(request: GetByLinkInfoRequest, runtime: RuntimeOptions): Promise<LinkInfoResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/get_link_info`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<LinkInfoResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new LinkInfoResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getLinkInfoByUserId(request: GetLinkInfoByUserIDRequest, runtime: RuntimeOptions): Promise<LinkInfoListResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/get_link_info_by_user_id`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<LinkInfoListResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new LinkInfoListResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async link(request: AccountLinkRequest, runtime: RuntimeOptions): Promise<AccountAccessTokenResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/link`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<AccountAccessTokenResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new AccountAccessTokenResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async checkExist(request: MobileCheckExistRequest, runtime: RuntimeOptions): Promise<MobileCheckExistResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/mobile/check_exist`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<MobileCheckExistResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new MobileCheckExistResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async login(request: MobileLoginRequest, runtime: RuntimeOptions): Promise<AccountAccessTokenResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/mobile/login`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<AccountAccessTokenResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new AccountAccessTokenResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async register(request: MobileRegisterRequest, runtime: RuntimeOptions): Promise<AccountAccessTokenResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/mobile/register`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<AccountAccessTokenResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new AccountAccessTokenResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async mobileSendSmsCode(request: MobileSendSmsCodeRequest, runtime: RuntimeOptions): Promise<MobileSendSmsCodeResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/mobile/send_sms_code`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<MobileSendSmsCodeResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new MobileSendSmsCodeResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async token(request: TokenRequest, runtime: RuntimeOptions): Promise<AccountAccessTokenResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/account/token`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.auth.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<AccountAccessTokenResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new AccountAccessTokenResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async adminListStores(request: AdminListStoresRequest, runtime: RuntimeOptions): Promise<ListStoresResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/domain/list_stores`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<ListStoresResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new ListStoresResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getAccessToken(request: GetUserAccessTokenRequest, runtime: RuntimeOptions): Promise<AccessTokenResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/user/get_access_token`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<AccessTokenResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new AccessTokenResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async createDrive(request: CreateDriveRequest, runtime: RuntimeOptions): Promise<CreateDriveResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/drive/create`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 201)) {
          return $tea.cast<CreateDriveResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new CreateDriveResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async deleteDrive(request: DeleteDriveRequest, runtime: RuntimeOptions): Promise<void>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/drive/delete`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 204)) {
          return ;
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getDrive(request: GetDriveRequest, runtime: RuntimeOptions): Promise<GetDriveResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/drive/get`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<GetDriveResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new GetDriveResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getDefaultDrive(request: GetDefaultDriveRequest, runtime: RuntimeOptions): Promise<GetDriveResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/drive/get_default_drive`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<GetDriveResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new GetDriveResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async listDrives(request: ListDriveRequest, runtime: RuntimeOptions): Promise<ListDriveResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/drive/list`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<ListDriveResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new ListDriveResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async listMyDrives(request: ListMyDriveRequest, runtime: RuntimeOptions): Promise<ListDriveResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/drive/list_my_drives`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<ListDriveResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new ListDriveResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async updateDrive(request: UpdateDriveRequest, runtime: RuntimeOptions): Promise<UpdateDriveResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/drive/update`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<UpdateDriveResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new UpdateDriveResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async completeFile(request: OSSCompleteFileRequest, runtime: RuntimeOptions): Promise<OSSCompleteFileResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/file/complete`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<OSSCompleteFileResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new OSSCompleteFileResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async copyFile(request: OSSCopyFileRequest, runtime: RuntimeOptions): Promise<OSSCopyFileResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/file/copy`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 201)) {
          return $tea.cast<OSSCopyFileResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new OSSCopyFileResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async createFile(request: OSSCreateFileRequest, runtime: RuntimeOptions): Promise<OSSCreateFileResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/file/create`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 201)) {
          return $tea.cast<OSSCreateFileResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new OSSCreateFileResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async deleteFile(request: OSSDeleteFileRequest, runtime: RuntimeOptions): Promise<void>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/file/delete`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 204)) {
          return ;
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getFile(request: OSSGetFileRequest, runtime: RuntimeOptions): Promise<OSSGetFileResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/file/get`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<OSSGetFileResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new OSSGetFileResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getDownloadUrl(request: OSSGetDownloadUrlRequest, runtime: RuntimeOptions): Promise<OSSGetDownloadUrlResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/file/get_download_url`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<OSSGetDownloadUrlResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new OSSGetDownloadUrlResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getUploadUrl(request: OSSGetUploadUrlRequest, runtime: RuntimeOptions): Promise<OSSGetUploadUrlResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/file/get_upload_url`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<OSSGetUploadUrlResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new OSSGetUploadUrlResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async listFile(request: OSSListFileRequest, runtime: RuntimeOptions): Promise<OSSListFileResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/file/list`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<OSSListFileResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new OSSListFileResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async listUploadedParts(request: OSSListUploadedPartRequest, runtime: RuntimeOptions): Promise<OSSListUploadedPartResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/file/list_uploaded_parts`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<OSSListUploadedPartResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new OSSListUploadedPartResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async moveFile(request: OSSMoveFileRequest, runtime: RuntimeOptions): Promise<OSSMoveFileResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/file/move`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<OSSMoveFileResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new OSSMoveFileResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async createShare(request: CreateShareRequest, runtime: RuntimeOptions): Promise<CreateShareResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/share/create`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 201)) {
          return $tea.cast<CreateShareResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new CreateShareResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async deleteShare(request: DeleteShareRequest, runtime: RuntimeOptions): Promise<void>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/share/delete`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 204)) {
          return ;
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getShare(request: GetShareRequest, runtime: RuntimeOptions): Promise<GetShareResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/share/get`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async listShare(request: ListShareRequest, runtime: RuntimeOptions): Promise<ListShareResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/share/list`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<ListShareResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new ListShareResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async updateShare(request: UpdateShareRequest, runtime: RuntimeOptions): Promise<UpdateShareResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/share/update`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<UpdateShareResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new UpdateShareResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async listStorage(request: ListStorageRequest, runtime: RuntimeOptions): Promise<ListStorageResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/storage/list`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<ListStorageResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new ListStorageResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async listStoragefile(request: ListStorageFileRequest, runtime: RuntimeOptions): Promise<ListStorageFileResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/osspath/storage_file/list`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<ListStorageFileResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new ListStorageFileResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async createUser(request: CreateUserRequest, runtime: RuntimeOptions): Promise<CreateUserResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/user/create`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 201)) {
          return $tea.cast<CreateUserResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new CreateUserResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async deleteUser(request: DeleteUserRequest, runtime: RuntimeOptions): Promise<void>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/user/delete`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 204)) {
          return ;
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async getUser(request: GetUserRequest, runtime: RuntimeOptions): Promise<GetUserResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/user/get`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<GetUserResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new GetUserResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async listUsers(request: ListUserRequest, runtime: RuntimeOptions): Promise<ListUserResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/user/list`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<ListUserResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new ListUserResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async searchUser(request: SearchUserRequest, runtime: RuntimeOptions): Promise<ListUserResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/user/search`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<ListUserResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new ListUserResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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

  async updateUser(request: UpdateUserRequest, runtime: RuntimeOptions): Promise<UpdateUserResponse>  {
    let _runtime : {[key: string]: any} = {
      timeouted: "retry",
      readTimeout: runtime["readTimeout"],
      connectTimeout: runtime["connectTimeout"],
      localAddr: runtime["localAddr"],
      httpProxy: runtime["httpProxy"],
      httpsProxy: runtime["httpsProxy"],
      noProxy: runtime["noProxy"],
      maxIdleConns: runtime["maxIdleConns"],
      socks5Proxy: runtime["socks5Proxy"],
      socks5NetWork: runtime["socks5NetWork"],
      retry: {
        retryable: runtime["autoretry"],
        maxAttempts: this._defaultNumber(runtime["maxAttempts"], 3),
      },
      backoff: {
        policy: this._default(runtime["backoffPolicy"], "no"),
        period: this._defaultNumber(runtime["backoffPeriod"], 1),
      },
      ignoreSSL: runtime["ignoreSSL"],
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
        let accesskeyId = await this._getAccessKeyId();
        let accessKeySecret = await this._getAccessKeySecret();
        let accessToken = await this._getAccessToken();
        request_.protocol = this._getProtocol(this._protocol, "https");
        request_.method = "POST";
        request_.pathname = `/v2/user/update`;
        request_.headers = {
          host: this._getHost(this._endpoint, `${this._domainId}.api.alicloudccp.com`),
          'content-type': "application/json; charset=utf-8",
        };
        if (this._notEmpty(accessToken)) {
          request_.headers["authorization"] = `Bearer ${accessToken}`;
        } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
          request_.headers["date"] = this._getRFC2616Date();
          request_.headers["accept"] = "application/json";
          request_.headers["x-acs-signature-method"] = "HMAC-SHA1";
          request_.headers["x-acs-signature-version"] = "1.0";
          request_.headers["authorization"] = `acs ${accesskeyId}:${this._getSignature(request_)}`;
        }
        request_.body = this._toJSONString(request.toMap());
        _lastRequest = request_;
        let response_ = await $tea.doAction(request_, _runtime);

        if (this._isStatusCode(response_, 200)) {
          return $tea.cast<UpdateUserResponse>({
            requestId: response_.headers["x-ca-request-id"],
            ...await this._readAsJSON(response_),
          }, new UpdateUserResponse({}));
        }

        if (this._notEmpty(response_.headers["x-ca-error-message"])) {
          throw $tea.newError({
            data: {
              requestId: response_.headers["x-ca-request-id"],
              statusCode: response_.statusCode,
              statusMessage: response_.statusMessage,
            },
            message: response_.headers["x-ca-error-message"],
          });
        }

        throw $tea.newError({
          data: {
            requestId: response_.headers["x-ca-request-id"],
            statusCode: response_.statusCode,
            statusMessage: response_.statusMessage,
          },
          ...await this._readAsJSON(response_),
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


}
