<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK;

use AlibabaCloud\Credentials\Credential;
use AlibabaCloud\Tea\Exception\TeaError;
use AlibabaCloud\Tea\Exception\TeaUnableRetryError;
use AlibabaCloud\Tea\Request;
use AlibabaCloud\Tea\RoaUtils\RoaUtils;
use AlibabaCloud\Tea\Tea;
use AlibabaCloud\Tea\Utils\Utils;
use Aliyun\CCP\Credentials\CCPCredentials;
use Aliyun\CCP\SDK\Models\AccountRevokeModel;
use Aliyun\CCP\SDK\Models\AccountRevokeRequestModel;
use Aliyun\CCP\SDK\Models\AccountTokenModel;
use Aliyun\CCP\SDK\Models\AccountTokenRequestModel;
use Aliyun\CCP\SDK\Models\AdminListStoresModel;
use Aliyun\CCP\SDK\Models\AdminListStoresRequestModel;
use Aliyun\CCP\SDK\Models\BatchOperationModel;
use Aliyun\CCP\SDK\Models\BatchOperationRequestModel;
use Aliyun\CCP\SDK\Models\CancelLinkModel;
use Aliyun\CCP\SDK\Models\CancelLinkRequestModel;
use Aliyun\CCP\SDK\Models\ChangePasswordModel;
use Aliyun\CCP\SDK\Models\ChangePasswordRequestModel;
use Aliyun\CCP\SDK\Models\CheckExistModel;
use Aliyun\CCP\SDK\Models\CheckExistRequestModel;
use Aliyun\CCP\SDK\Models\CompleteFileModel;
use Aliyun\CCP\SDK\Models\CompleteFileRequestModel;
use Aliyun\CCP\SDK\Models\Config;
use Aliyun\CCP\SDK\Models\ConfirmLinkModel;
use Aliyun\CCP\SDK\Models\ConfirmLinkRequestModel;
use Aliyun\CCP\SDK\Models\CopyFileModel;
use Aliyun\CCP\SDK\Models\CopyFileRequestModel;
use Aliyun\CCP\SDK\Models\CreateDriveModel;
use Aliyun\CCP\SDK\Models\CreateDriveRequestModel;
use Aliyun\CCP\SDK\Models\CreateFileModel;
use Aliyun\CCP\SDK\Models\CreateFileRequestModel;
use Aliyun\CCP\SDK\Models\CreateUserModel;
use Aliyun\CCP\SDK\Models\CreateUserRequestModel;
use Aliyun\CCP\SDK\Models\DeleteDriveModel;
use Aliyun\CCP\SDK\Models\DeleteDriveRequestModel;
use Aliyun\CCP\SDK\Models\DeleteFileModel;
use Aliyun\CCP\SDK\Models\DeleteFileRequestModel;
use Aliyun\CCP\SDK\Models\DeleteUserModel;
use Aliyun\CCP\SDK\Models\DeleteUserRequestModel;
use Aliyun\CCP\SDK\Models\DownloadFileModel;
use Aliyun\CCP\SDK\Models\DownloadFileRequestModel;
use Aliyun\CCP\SDK\Models\GetAccessTokenByLinkInfoModel;
use Aliyun\CCP\SDK\Models\GetAccessTokenByLinkInfoRequestModel;
use Aliyun\CCP\SDK\Models\GetAsyncTaskInfoModel;
use Aliyun\CCP\SDK\Models\GetAsyncTaskInfoRequestModel;
use Aliyun\CCP\SDK\Models\GetCaptchaModel;
use Aliyun\CCP\SDK\Models\GetCaptchaRequestModel;
use Aliyun\CCP\SDK\Models\GetDefaultDriveModel;
use Aliyun\CCP\SDK\Models\GetDefaultDriveRequestModel;
use Aliyun\CCP\SDK\Models\GetDownloadUrlModel;
use Aliyun\CCP\SDK\Models\GetDownloadUrlRequestModel;
use Aliyun\CCP\SDK\Models\GetDriveModel;
use Aliyun\CCP\SDK\Models\GetDriveRequestModel;
use Aliyun\CCP\SDK\Models\GetFileByPathModel;
use Aliyun\CCP\SDK\Models\GetFileByPathRequestModel;
use Aliyun\CCP\SDK\Models\GetFileModel;
use Aliyun\CCP\SDK\Models\GetFileRequestModel;
use Aliyun\CCP\SDK\Models\GetLastCursorModel;
use Aliyun\CCP\SDK\Models\GetLastCursorRequestModel;
use Aliyun\CCP\SDK\Models\GetLinkInfoByUserIdModel;
use Aliyun\CCP\SDK\Models\GetLinkInfoByUserIdRequestModel;
use Aliyun\CCP\SDK\Models\GetLinkInfoModel;
use Aliyun\CCP\SDK\Models\GetLinkInfoRequestModel;
use Aliyun\CCP\SDK\Models\GetPhotoCountModel;
use Aliyun\CCP\SDK\Models\GetPhotoCountRequestModel;
use Aliyun\CCP\SDK\Models\GetPublicKeyModel;
use Aliyun\CCP\SDK\Models\GetPublicKeyRequestModel;
use Aliyun\CCP\SDK\Models\GetUploadUrlModel;
use Aliyun\CCP\SDK\Models\GetUploadUrlRequestModel;
use Aliyun\CCP\SDK\Models\GetUserAccessTokenModel;
use Aliyun\CCP\SDK\Models\GetUserAccessTokenRequestModel;
use Aliyun\CCP\SDK\Models\GetUserModel;
use Aliyun\CCP\SDK\Models\GetUserRequestModel;
use Aliyun\CCP\SDK\Models\LinkModel;
use Aliyun\CCP\SDK\Models\LinkRequestModel;
use Aliyun\CCP\SDK\Models\ListAddressGroupsModel;
use Aliyun\CCP\SDK\Models\ListAddressGroupsRequestModel;
use Aliyun\CCP\SDK\Models\ListDrivesModel;
use Aliyun\CCP\SDK\Models\ListDrivesRequestModel;
use Aliyun\CCP\SDK\Models\ListFaceGroupsModel;
use Aliyun\CCP\SDK\Models\ListFaceGroupsRequestModel;
use Aliyun\CCP\SDK\Models\ListFileByCustomIndexKeyModel;
use Aliyun\CCP\SDK\Models\ListFileByCustomIndexKeyRequestModel;
use Aliyun\CCP\SDK\Models\ListFileDeltaModel;
use Aliyun\CCP\SDK\Models\ListFileDeltaRequestModel;
use Aliyun\CCP\SDK\Models\ListFileModel;
use Aliyun\CCP\SDK\Models\ListFileRequestModel;
use Aliyun\CCP\SDK\Models\ListMyDrivesModel;
use Aliyun\CCP\SDK\Models\ListMyDrivesRequestModel;
use Aliyun\CCP\SDK\Models\ListTagsModel;
use Aliyun\CCP\SDK\Models\ListTagsRequestModel;
use Aliyun\CCP\SDK\Models\ListUploadedPartsModel;
use Aliyun\CCP\SDK\Models\ListUploadedPartsRequestModel;
use Aliyun\CCP\SDK\Models\ListUsersModel;
use Aliyun\CCP\SDK\Models\ListUsersRequestModel;
use Aliyun\CCP\SDK\Models\LoginModel;
use Aliyun\CCP\SDK\Models\LoginRequestModel;
use Aliyun\CCP\SDK\Models\MobileSendSmsCodeModel;
use Aliyun\CCP\SDK\Models\MobileSendSmsCodeRequestModel;
use Aliyun\CCP\SDK\Models\MoveFileModel;
use Aliyun\CCP\SDK\Models\MoveFileRequestModel;
use Aliyun\CCP\SDK\Models\RegisterModel;
use Aliyun\CCP\SDK\Models\RegisterRequestModel;
use Aliyun\CCP\SDK\Models\RuntimeOptions;
use Aliyun\CCP\SDK\Models\ScanFileMetaModel;
use Aliyun\CCP\SDK\Models\ScanFileMetaRequestModel;
use Aliyun\CCP\SDK\Models\SearchAddressGroupsModel;
use Aliyun\CCP\SDK\Models\SearchAddressGroupsRequestModel;
use Aliyun\CCP\SDK\Models\SearchFileModel;
use Aliyun\CCP\SDK\Models\SearchFileRequestModel;
use Aliyun\CCP\SDK\Models\SearchUserModel;
use Aliyun\CCP\SDK\Models\SearchUserRequestModel;
use Aliyun\CCP\SDK\Models\SetPasswordModel;
use Aliyun\CCP\SDK\Models\SetPasswordRequestModel;
use Aliyun\CCP\SDK\Models\UpdateDriveModel;
use Aliyun\CCP\SDK\Models\UpdateDriveRequestModel;
use Aliyun\CCP\SDK\Models\UpdateFacegroupInfoModel;
use Aliyun\CCP\SDK\Models\UpdateFacegroupInfoRequestModel;
use Aliyun\CCP\SDK\Models\UpdateFileModel;
use Aliyun\CCP\SDK\Models\UpdateFileRequestModel;
use Aliyun\CCP\SDK\Models\UpdateUserModel;
use Aliyun\CCP\SDK\Models\UpdateUserRequestModel;
use Aliyun\CCP\SDK\Models\VerifyCodeModel;
use Aliyun\CCP\SDK\Models\VerifyCodeRequestModel;

class CCPPath
{
    protected $_domainId;

    protected $_accessTokenCredential;

    protected $_endpoint;

    protected $_protocol;

    protected $_nickname;

    protected $_userAgent;

    protected $_credential;

    public function __construct(Config $config)
    {
        if (Utils::isUnset($config)) {
            throw new TeaError([
                'name'    => 'ParameterMissing',
                'message' => "'config' can not be unset",
            ]);
        }
        if (!Utils::empty_($config->accessToken) || !Utils::empty_($config->refreshToken)) {
            $accessConfig = new \Aliyun\CCP\Credentials\CCPCredentials\Config([
                'accessToken'  => $config->accessToken,
                'endpoint'     => $config->endpoint,
                'domainId'     => $config->domainId,
                'clientId'     => $config->clientId,
                'refreshToken' => $config->refreshToken,
                'clientSecret' => $config->clientSecret,
                'expireTime'   => $config->expireTime,
            ]);
            $this->_accessTokenCredential = new CCPCredentials($accessConfig);
        }
        if (!Utils::empty_($config->accessKeyId)) {
            if (Utils::empty_($config->type)) {
                $config->type = 'access_key';
            }
            $credentialConfig = new \AlibabaCloud\Credentials\Credential\Config([
                'accessKeyId'     => $config->accessKeyId,
                'type'            => $config->type,
                'accessKeySecret' => $config->accessKeySecret,
                'securityToken'   => $config->securityToken,
            ]);
            $this->_credential = new Credential($credentialConfig);
        }
        $this->_endpoint  = $config->endpoint;
        $this->_protocol  = $config->protocol;
        $this->_userAgent = $config->userAgent;
        $this->_nickname  = $config->nickname;
        $this->_domainId  = $config->domainId;
    }

    /**
     * 取消绑定关系，生成新用户，返回访问令牌.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return CancelLinkModel
     */
    public function cancelLink(CancelLinkRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/cancel_link');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return CancelLinkModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 确认绑定关系, 成功后返回访问令牌.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return ConfirmLinkModel
     */
    public function confirmLink(ConfirmLinkRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/confirm_link');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ConfirmLinkModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 修改手机登录密码，密码必须包含数字和字母，长度8-20个字符.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return ChangePasswordModel
     */
    public function changePassword(ChangePasswordRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/default/change_password');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ChangePasswordModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 设置手机登录密码，密码必须包含数字和字母，长度8-20个字符.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return SetPasswordModel
     */
    public function setPassword(SetPasswordRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/default/set_password');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return SetPasswordModel::fromMap([
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 校验手机短信验证码，用于重置密码时校验手机，通过校验后返回state，可通过state重新设置密码
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return VerifyCodeModel
     */
    public function verifyCode(VerifyCodeRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/default/verify_code');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return VerifyCodeModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 管理员通过账号信息直接获取用户的访问令牌.
     *
     * @tags account
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return GetAccessTokenByLinkInfoModel
     */
    public function getAccessTokenByLinkInfo(GetAccessTokenByLinkInfoRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/get_access_token_by_link_info');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetAccessTokenByLinkInfoModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 获取图片验证码，用于人机校验，默认不需要
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return GetCaptchaModel
     */
    public function getCaptcha(GetCaptchaRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/get_captcha');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetCaptchaModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 获取用户认证方式详情.
     *
     * @tags account
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return GetLinkInfoModel
     */
    public function getLinkInfo(GetLinkInfoRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/get_link_info');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetLinkInfoModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 获取用户的所有绑定信息.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return GetLinkInfoByUserIdModel
     */
    public function getLinkInfoByUserId(GetLinkInfoByUserIdRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/get_link_info_by_user_id');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetLinkInfoByUserIdModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 获取公钥，用于加密对称密钥.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return GetPublicKeyModel
     */
    public function getPublicKey(GetPublicKeyRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/get_public_key');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetPublicKeyModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 绑定用户认证方式.
     *
     * @tags account
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error AlreadyExist {resource} has already exists. {extra_msg}
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return LinkModel
     */
    public function link(LinkRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/link');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return LinkModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 查询手机号是否已被注册.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return CheckExistModel
     */
    public function checkExist(CheckExistRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/mobile/check_exist');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return CheckExistModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 通过手机号+短信或密码登录，返回刷新令牌和访问令牌.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return LoginModel
     */
    public function login(LoginRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/mobile/login');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return LoginModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 通过手机号+短信验证码注册账号.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error AlreadyExist {resource} has already exists. {extra_msg}
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return RegisterModel
     */
    public function register(RegisterRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/mobile/register');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return RegisterModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 发送短信验证码，用于登录、注册、修改密码、绑定等.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return MobileSendSmsCodeModel
     */
    public function mobileSendSmsCode(MobileSendSmsCodeRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/mobile/send_sms_code');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return MobileSendSmsCodeModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 用户退出登录.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return AccountRevokeModel
     */
    public function accountRevoke(AccountRevokeRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/revoke');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return AccountRevokeModel::fromMap([
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 用户通过刷新令牌（refresh_token）获取访问令牌（access_token）.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return AccountTokenModel
     */
    public function accountToken(AccountTokenRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/token');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return AccountTokenModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 列举Store列表.
     *
     * @tags admin
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return AdminListStoresModel
     */
    public function adminListStores(AdminListStoresRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/domain/list_stores');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return AdminListStoresModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 获取用户的accessToken.
     *
     * @tags admin
     * @error undefined undefined
     * @error undefined undefined
     * @error undefined undefined
     * @error undefined undefined
     * @error undefined undefined
     *
     * @throws \Exception
     *
     * @return GetUserAccessTokenModel
     */
    public function getUserAccessToken(GetUserAccessTokenRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/get_access_token');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetUserAccessTokenModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 如果目录拷贝、目录删除不能在限定时间内完成，将访问一个异步任务id，
     * 通过此接口获取异步任务的信息，以确定任务是否执行成功。
     *
     * @tags async_task
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetAsyncTaskInfoModel
     */
    public function getAsyncTaskInfo(GetAsyncTaskInfoRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/async_task/get');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetAsyncTaskInfoModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 对多个原子操作封装成一个批处理请求，服务端并行处理并打包返回每个操作的执行结果。
     * 支持对文件和文件夹的移动、删除、修改，每个批处理请求最多包含100个原则操作。
     *
     * @tags batch
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return BatchOperationModel
     */
    public function batchOperation(BatchOperationRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/batch');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return BatchOperationModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 支持normal和large两种drive，
     * large类型的drive用于文件数多的场景，不支持list操作，
     * 当drive的文件数量大于1亿时，建议使用large类型。
     *
     * @tags drive
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return CreateDriveModel
     */
    public function createDrive(CreateDriveRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/create');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 201)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return CreateDriveModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 删除指定drive_id对应的Drive.
     *
     * @tags drive
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return DeleteDriveModel
     */
    public function deleteDrive(DeleteDriveRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/delete');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return DeleteDriveModel::fromMap([
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 获取指定drive_id对应的Drive详细信息。
     *
     * @tags drive
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetDriveModel
     */
    public function getDrive(GetDriveRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/get');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetDriveModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 一个用户可拥有多个drive，在创建drive时通过参数指定是否为这个用户的默认drive，
     * 每个用户只能设置一个默认drive。
     *
     * @tags drive
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetDefaultDriveModel
     */
    public function getDefaultDrive(GetDefaultDriveRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/get_default_drive');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetDefaultDriveModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 管理员列举指定用户的Drive.
     *
     * @tags drive
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListDrivesModel
     */
    public function listDrives(ListDrivesRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/list');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ListDrivesModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 列举当前用户（访问令牌）的Drive.
     *
     * @tags drive
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListMyDrivesModel
     */
    public function listMyDrives(ListMyDrivesRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/list_my_drives');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ListMyDrivesModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 更新指定drive_id的Drive信息.
     *
     * @tags drive
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return UpdateDriveModel
     */
    public function updateDrive(UpdateDriveRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/update');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return UpdateDriveModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 完成文件上传。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return CompleteFileModel
     */
    public function completeFile(CompleteFileRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/complete');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return CompleteFileModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 指定源文件或文件夹，拷贝到指定的文件夹。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return CopyFileModel
     */
    public function copyFile(CopyFileRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/copy');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 201)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return CopyFileModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (Utils::equalNumber($_response->statusCode, 202)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return CopyFileModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 在指定文件夹下创建文件或者文件夹，
     * 根文件夹用root表示，其他文件夹使用创建文件夹时返回的file_id。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error AlreadyExist {resource} has already exists. {extra_msg}
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return CreateFileModel
     */
    public function createFile(CreateFileRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/create');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 201)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return CreateFileModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 指定文件或文件夹ID，删除文件或者文件夹。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return DeleteFileModel
     */
    public function deleteFile(DeleteFileRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/delete');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 202)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return DeleteFileModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return DeleteFileModel::fromMap([
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 指定文件ID，下载文件。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return DownloadFileModel
     */
    public function downloadFile(DownloadFileRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'GET';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/download');
                $_request->query    = Utils::stringifyMapValue($request->query->toMap());
                $_request->headers  = Tea::merge([
                    'user-agent' => $this->getUserAgent(),
                    'host'       => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_lastRequest = $_request;
                $_response    = Tea::send($_request, $_runtime);
                $respMap      = null;
                $obj          = null;
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 获取指定文件或文件夹ID的信息。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetFileModel
     */
    public function getFile(GetFileRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/get');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetFileModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 根据路径获取指定文件或文件夹的信息。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetFileByPathModel
     */
    public function getFileByPath(GetFileByPathRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/get_by_path');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetFileByPathModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 获取文件的下载地址，调用者可自己设置range头并发下载。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetDownloadUrlModel
     */
    public function getDownloadUrl(GetDownloadUrlRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/get_download_url');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetDownloadUrlModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 获取drive内，增量数据最新的游标.
     *
     * @tags file_delta
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetLastCursorModel
     */
    public function getLastCursor(GetLastCursorRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/get_last_cursor');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetLastCursorModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 可指定分片信息，一次获取多个分片的上传地址。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetUploadUrlModel
     */
    public function getUploadUrl(GetUploadUrlRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/get_upload_url');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetUploadUrlModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 列举指定目录下的文件或文件夹。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListFileModel
     */
    public function listFile(ListFileRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/list');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ListFileModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 根据自定义同步索引键列举文件或文件夹。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListFileByCustomIndexKeyModel
     */
    public function listFileByCustomIndexKey(ListFileByCustomIndexKeyRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/list_by_custom_index_key');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ListFileByCustomIndexKeyModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 获取drive内，增量数据列表.
     *
     * @tags file_delta
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListFileDeltaModel
     */
    public function listFileDelta(ListFileDeltaRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/list_delta');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ListFileDeltaModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 列举upload_id对应的已上传分片。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListUploadedPartsModel
     */
    public function listUploadedParts(ListUploadedPartsRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/list_uploaded_parts');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ListUploadedPartsModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 指定源文件或文件夹，移动到指定的文件夹。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return MoveFileModel
     */
    public function moveFile(MoveFileRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/move');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return MoveFileModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 在指定drive下全量获取文件元信息。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ScanFileMetaModel
     */
    public function scanFileMeta(ScanFileMetaRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/scan');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ScanFileMetaModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 根据筛选条件，在指定drive下搜索文件。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return SearchFileModel
     */
    public function searchFile(SearchFileRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/search');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return SearchFileModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 对指定的文件或文件夹更新信息。
     *
     * @tags file
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error AlreadyExist {resource} has already exists. {extra_msg}
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return UpdateFileModel
     */
    public function updateFile(UpdateFileRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/update');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return UpdateFileModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会创建用户， 只有管理员可以调用.
     *
     * @tags user
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return CreateUserModel
     */
    public function createUser(CreateUserRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/create');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 201)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return CreateUserModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会删除用户.
     *
     * @tags user
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return DeleteUserModel
     */
    public function deleteUser(DeleteUserRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/delete');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return DeleteUserModel::fromMap([
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会查看用户详细信息.
     *
     * @tags user
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetUserModel
     */
    public function getUser(GetUserRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/get');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetUserModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会展示用户列表.
     *
     * @tags user
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListUsersModel
     */
    public function listUsers(ListUsersRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/list');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ListUsersModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会根据条件查询用户.
     *
     * @tags user
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return SearchUserModel
     */
    public function searchUser(SearchUserRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/search');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return SearchUserModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会更新用户信息.
     *
     * @tags user
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return UpdateUserModel
     */
    public function updateUser(UpdateUserRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/update');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return UpdateUserModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将返回用户Drive下的云照片个数.
     *
     * @tags image
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetPhotoCountModel
     */
    public function getPhotoCount(GetPhotoCountRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/image/get_photo_count');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return GetPhotoCountModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会展示用户图片的地点分组.
     *
     * @tags image
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListAddressGroupsModel
     */
    public function listAddressGroups(ListAddressGroupsRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/image/list_address_groups');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ListAddressGroupsModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会列举人脸分组.
     *
     * @tags image
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListFaceGroupsModel
     */
    public function listFaceGroups(ListFaceGroupsRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/image/list_face_groups');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ListFaceGroupsModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会展示场景标记.
     *
     * @tags image
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListTagsModel
     */
    public function listTags(ListTagsRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/image/list_tags');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return ListTagsModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会展示用户图片的地点分组.
     *
     * @tags image
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return SearchAddressGroupsModel
     */
    public function searchAddressGroups(SearchAddressGroupsRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/image/search_address_groups');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return SearchAddressGroupsModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * 该接口将会更新人脸分组信息.
     *
     * @tags image
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return UpdateFacegroupInfoModel
     */
    public function updateFacegroupInfo(UpdateFacegroupInfoRequestModel $request, RuntimeOptions $runtime)
    {
        $request->validate();
        $runtime->validate();
        $_runtime = [
            'timeouted'      => 'retry',
            'readTimeout'    => $runtime->readTimeout,
            'connectTimeout' => $runtime->connectTimeout,
            'localAddr'      => $runtime->localAddr,
            'httpProxy'      => $runtime->httpProxy,
            'httpsProxy'     => $runtime->httpsProxy,
            'noProxy'        => $runtime->noProxy,
            'maxIdleConns'   => $runtime->maxIdleConns,
            'socks5Proxy'    => $runtime->socks5Proxy,
            'socks5NetWork'  => $runtime->socks5NetWork,
            'retry'          => [
                'retryable'   => $runtime->autoretry,
                'maxAttempts' => Utils::defaultNumber($runtime->maxAttempts, 3),
            ],
            'backoff' => [
                'policy' => Utils::defaultString($runtime->backoffPolicy, 'no'),
                'period' => Utils::defaultNumber($runtime->backoffPeriod, 1),
            ],
            'ignoreSSL' => $runtime->ignoreSSL,
        ];
        $_lastRequest   = null;
        $_lastException = null;
        $_now           = time();
        $_retryTimes    = 0;
        while (Tea::allowRetry($_runtime['retry'], $_retryTimes, $_now)) {
            if ($_retryTimes > 0) {
                $_backoffTime = Tea::getBackoffTime($_runtime['backoff'], $_retryTimes);
                if ($_backoffTime > 0) {
                    Tea::sleep($_backoffTime);
                }
            }
            $_retryTimes = $_retryTimes + 1;

            try {
                $_request           = new Request();
                $accesskeyId        = $this->getAccessKeyId();
                $accessKeySecret    = $this->getAccessKeySecret();
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/image/update_facegroup_info');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::empty_($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::empty_($accesskeyId) && !Utils::empty_($accessKeySecret)) {
                    if (!Utils::empty_($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body->toMap());
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return UpdateFacegroupInfoModel::fromMap([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ]);
                }
                if (!Utils::empty_($_response->headers['x-ca-error-message'])) {
                    throw new TeaError([
                        'data' => [
                            'requestId'     => $_response->headers['x-ca-request-id'],
                            'statusCode'    => $_response->statusCode,
                            'statusMessage' => $_response->statusMessage,
                        ],
                        'message' => $_response->headers['x-ca-error-message'],
                    ]);
                }
                $obj     = Utils::readAsJSON($_response->body);
                $respMap = Utils::assertAsMap($obj);

                throw new TeaError(Tea::merge([
                    'data' => [
                        'requestId'     => $_response->headers['x-ca-request-id'],
                        'statusCode'    => $_response->statusCode,
                        'statusMessage' => $_response->statusMessage,
                    ],
                ], $respMap));
            } catch (\Exception $e) {
                if (Tea::isRetryable($e)) {
                    $_lastException = $e;

                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest, $_lastException);
    }

    /**
     * @param string $nickname
     * @param string $path
     *
     * @throws \Exception
     *
     * @return string
     */
    public function getPathname($nickname, $path)
    {
        if (Utils::empty_($nickname)) {
            return $path;
        }

        return '/' . $nickname . '' . $path . '';
    }

    /**
     * @param string $expireTime
     *
     * @throws \Exception
     */
    public function setExpireTime($expireTime)
    {
        if (Utils::isUnset($this->_accessTokenCredential)) {
            return null;
        }
        $this->_accessTokenCredential->setExpireTime($expireTime);
    }

    /**
     * @throws \Exception
     *
     * @return string
     */
    public function getExpireTime()
    {
        if (Utils::isUnset($this->_accessTokenCredential)) {
            return '';
        }

        return $this->_accessTokenCredential->getExpireTime();
    }

    /**
     * @param string $token
     *
     * @throws \Exception
     */
    public function setRefreshToken($token)
    {
        if (Utils::isUnset($this->_accessTokenCredential)) {
            return null;
        }
        $this->_accessTokenCredential->setRefreshToken($token);
    }

    /**
     * @throws \Exception
     *
     * @return string
     */
    public function getRefreshToken()
    {
        if (Utils::isUnset($this->_accessTokenCredential)) {
            return '';
        }

        return $this->_accessTokenCredential->getRefreshToken();
    }

    /**
     * @param string $token
     *
     * @throws \Exception
     */
    public function setAccessToken($token)
    {
        if (Utils::isUnset($this->_accessTokenCredential)) {
            return null;
        }
        $this->_accessTokenCredential->setAccessToken($token);
    }

    /**
     * @throws \Exception
     *
     * @return string
     */
    public function getAccessToken()
    {
        if (Utils::isUnset($this->_accessTokenCredential)) {
            return '';
        }

        return $this->_accessTokenCredential->getAccessToken();
    }

    /**
     * @param string $userAgent
     *
     * @throws \Exception
     */
    public function setUserAgent($userAgent)
    {
        $this->_userAgent = $userAgent;
    }

    /**
     * @param string $userAgent
     *
     * @throws \Exception
     */
    public function appendUserAgent($userAgent)
    {
        $this->_userAgent = '' . $this->_userAgent . ' ' . $userAgent . '';
    }

    /**
     * @throws \Exception
     *
     * @return string
     */
    public function getUserAgent()
    {
        return Utils::getUserAgent($this->_userAgent);
    }

    /**
     * @throws \Exception
     *
     * @return string
     */
    public function getAccessKeyId()
    {
        if (Utils::isUnset($this->_credential)) {
            return '';
        }

        return $this->_credential->getAccessKeyId();
    }

    /**
     * @throws \Exception
     *
     * @return string
     */
    public function getAccessKeySecret()
    {
        if (Utils::isUnset($this->_credential)) {
            return '';
        }

        return $this->_credential->getAccessKeySecret();
    }

    /**
     * @throws \Exception
     *
     * @return string
     */
    public function getSecurityToken()
    {
        if (Utils::isUnset($this->_credential)) {
            return '';
        }

        return $this->_credential->getSecurityToken();
    }
}
