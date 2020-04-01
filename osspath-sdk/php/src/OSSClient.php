<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient;

use AlibabaCloud\Credentials\Credential;
use AlibabaCloud\Tea\Exception\TeaError;
use AlibabaCloud\Tea\Exception\TeaUnableRetryError;
use AlibabaCloud\Tea\Model;
use AlibabaCloud\Tea\Request;
use AlibabaCloud\Tea\RoaUtils\RoaUtils;
use AlibabaCloud\Tea\Tea;
use AlibabaCloud\Tea\Utils\Utils;
use Aliyun\CCP\OSSClient\OSSClient\AccountLinkRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\AdminListStoresModel;
use Aliyun\CCP\OSSClient\OSSClient\AdminListStoresRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\CancelLinkModel;
use Aliyun\CCP\OSSClient\OSSClient\CancelLinkRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\ChangePasswordModel;
use Aliyun\CCP\OSSClient\OSSClient\CheckExistModel;
use Aliyun\CCP\OSSClient\OSSClient\CompleteFileModel;
use Aliyun\CCP\OSSClient\OSSClient\Config;
use Aliyun\CCP\OSSClient\OSSClient\ConfirmLinkModel;
use Aliyun\CCP\OSSClient\OSSClient\ConfirmLinkRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\CopyFileModel;
use Aliyun\CCP\OSSClient\OSSClient\CreateDriveModel;
use Aliyun\CCP\OSSClient\OSSClient\CreateDriveRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\CreateFileModel;
use Aliyun\CCP\OSSClient\OSSClient\CreateShareModel;
use Aliyun\CCP\OSSClient\OSSClient\CreateShareRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\CreateUserModel;
use Aliyun\CCP\OSSClient\OSSClient\CreateUserRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\DefaultChangePasswordRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\DefaultSetPasswordRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\DeleteDriveModel;
use Aliyun\CCP\OSSClient\OSSClient\DeleteDriveRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\DeleteFileModel;
use Aliyun\CCP\OSSClient\OSSClient\DeleteShareModel;
use Aliyun\CCP\OSSClient\OSSClient\DeleteShareRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\DeleteUserModel;
use Aliyun\CCP\OSSClient\OSSClient\DeleteUserRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\GetAccessTokenByLinkInfoModel;
use Aliyun\CCP\OSSClient\OSSClient\GetAccessTokenByLinkInfoRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\GetByLinkInfoRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\GetCaptchaModel;
use Aliyun\CCP\OSSClient\OSSClient\GetCaptchaRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\GetDefaultDriveModel;
use Aliyun\CCP\OSSClient\OSSClient\GetDefaultDriveRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\GetDownloadUrlModel;
use Aliyun\CCP\OSSClient\OSSClient\GetDriveModel;
use Aliyun\CCP\OSSClient\OSSClient\GetDriveRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\GetFileModel;
use Aliyun\CCP\OSSClient\OSSClient\GetLinkInfoByUserIdModel;
use Aliyun\CCP\OSSClient\OSSClient\GetLinkInfoByUserIDRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\GetLinkInfoModel;
use Aliyun\CCP\OSSClient\OSSClient\GetSecureUrlModel;
use Aliyun\CCP\OSSClient\OSSClient\GetShareModel;
use Aliyun\CCP\OSSClient\OSSClient\GetShareRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\GetUploadUrlModel;
use Aliyun\CCP\OSSClient\OSSClient\GetUserAccessTokenModel;
use Aliyun\CCP\OSSClient\OSSClient\GetUserAccessTokenRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\GetUserModel;
use Aliyun\CCP\OSSClient\OSSClient\GetUserRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\LinkModel;
use Aliyun\CCP\OSSClient\OSSClient\ListDriveRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\ListDrivesModel;
use Aliyun\CCP\OSSClient\OSSClient\ListFileModel;
use Aliyun\CCP\OSSClient\OSSClient\ListMyDriveRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\ListMyDrivesModel;
use Aliyun\CCP\OSSClient\OSSClient\ListShareModel;
use Aliyun\CCP\OSSClient\OSSClient\ListShareRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\ListStorefileModel;
use Aliyun\CCP\OSSClient\OSSClient\ListStoreFileRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\ListUploadedPartsModel;
use Aliyun\CCP\OSSClient\OSSClient\ListUserRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\ListUsersModel;
use Aliyun\CCP\OSSClient\OSSClient\LoginModel;
use Aliyun\CCP\OSSClient\OSSClient\MobileCheckExistRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\MobileLoginRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\MobileRegisterRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\MobileSendSmsCodeModel;
use Aliyun\CCP\OSSClient\OSSClient\MobileSendSmsCodeRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\MoveFileModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSCompleteFileRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSCopyFileRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSCreateFileRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSDeleteFileRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSGetDownloadUrlRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSGetFileRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSGetSecureUrlRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSGetUploadUrlRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSListFileRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSListUploadedPartRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSMoveFileRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSVideoDefinitionRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSVideoM3U8RequestModel;
use Aliyun\CCP\OSSClient\OSSClient\OSSVideoTranscodeRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\RegisterModel;
use Aliyun\CCP\OSSClient\OSSClient\RuntimeOptions;
use Aliyun\CCP\OSSClient\OSSClient\SearchUserModel;
use Aliyun\CCP\OSSClient\OSSClient\SearchUserRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\SetPasswordModel;
use Aliyun\CCP\OSSClient\OSSClient\TokenModel;
use Aliyun\CCP\OSSClient\OSSClient\TokenRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\UpdateDriveModel;
use Aliyun\CCP\OSSClient\OSSClient\UpdateDriveRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\UpdateShareModel;
use Aliyun\CCP\OSSClient\OSSClient\UpdateShareRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\UpdateUserModel;
use Aliyun\CCP\OSSClient\OSSClient\UpdateUserRequestModel;
use Aliyun\CCP\OSSClient\OSSClient\VideoDefinitionModel;
use Aliyun\CCP\OSSClient\OSSClient\VideoM3u8Model;
use Aliyun\CCP\OSSClient\OSSClient\VideoTranscodeModel;

class OSSClient
{
    private $_domainId;
    private $_endpoint;
    private $_protocol;
    private $_nickname;
    private $_userAgent;
    private $_credential;
    private $_accessTokenCredential;

    public function __construct(Config $config)
    {
        if (Utils::isUnset($config)) {
            throw new TeaError([
                'name'    => 'ParameterMissing',
                'message' => "'config' can not be unset",
            ]);
        }
        if (Utils::_empty($config->domainId)) {
            throw new TeaError([
                'name'    => 'ParameterMissing',
                'message' => "'config.domainId' can not be empty",
            ]);
        }
        if (!Utils::_empty($config->accessToken) || !Utils::_empty($config->refreshToken)) {
            $accessConfig = new Config([
                'accessToken'  => $config->accessToken,
                'endpoint'     => $config->endpoint,
                'domainId'     => $config->domainId,
                'clientId'     => $config->clientId,
                'refreshToken' => $config->refreshToken,
                'clientSecret' => $config->clientSecret,
                'expireTime'   => $config->expireTime,
            ]);
            $this->_accessTokenCredential = new AccessTokenCredential($accessConfig);
        }
        if (!Utils::_empty($config->accessKeyId)) {
            if (Utils::_empty($config->type)) {
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
        $this->_domainId  = $config->domainId;
        $this->_userAgent = $config->userAgent;
        $this->_nickname  = $config->nickname;
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/cancel_link');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new CancelLinkModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 确认绑定关系, 成功后返回访问令牌.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/confirm_link');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new ConfirmLinkModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 修改手机登录密码，密码必须包含数字和字母，长度8-32个字符.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return ChangePasswordModel
     */
    public function changePassword(DefaultChangePasswordRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/default/change_password');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return Model::toModel([
                        'headers' => $_response->headers,
                    ], new ChangePasswordModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 设置手机登录密码，密码必须包含数字和字母，长度8-32个字符.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return SetPasswordModel
     */
    public function setPassword(DefaultSetPasswordRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/default/set_password');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return Model::toModel([
                        'headers' => $_response->headers,
                    ], new SetPasswordModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/get_access_token_by_link_info');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetAccessTokenByLinkInfoModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 获取图片验证码，用于人机校验，默认不需要
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/get_captcha');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetCaptchaModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
    public function getLinkInfo(GetByLinkInfoRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/get_link_info');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetLinkInfoModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
    public function getLinkInfoByUserId(GetLinkInfoByUserIDRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/get_link_info_by_user_id');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetLinkInfoByUserIdModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
    public function link(AccountLinkRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/link');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new LinkModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
    public function checkExist(MobileCheckExistRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/mobile/check_exist');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new CheckExistModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
    public function login(MobileLoginRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/mobile/login');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new LoginModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 通过手机号+短信验证码注册账号.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error AlreadyExist {resource} has already exists. {extra_msg}
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return RegisterModel
     */
    public function register(MobileRegisterRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/mobile/register');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new RegisterModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 发送短信验证码，用于登录、注册、修改密码、绑定等.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/mobile/send_sms_code');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new MobileSendSmsCodeModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 用户通过刷新令牌（refresh_token）获取访问令牌（access_token）.
     *
     * @tags account
     * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
     * @error Forbidden User not authorized to operate on the specified APIs.
     * @error InternalError The request has been failed due to some unknown error.
     *
     * @throws \Exception
     *
     * @return TokenModel
     */
    public function token(TokenRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/account/token');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.auth.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new TokenModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/domain/list_stores');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new AdminListStoresModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/get_access_token');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetUserAccessTokenModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/create');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 201)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new CreateDriveModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/delete');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return Model::toModel([
                        'headers' => $_response->headers,
                    ], new DeleteDriveModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/get');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetDriveModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/get_default_drive');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetDefaultDriveModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
    public function listDrives(ListDriveRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/list');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new ListDrivesModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
    public function listMyDrives(ListMyDriveRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/list_my_drives');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new ListMyDrivesModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/drive/update');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new UpdateDriveModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 完成文件上传.
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
    public function completeFile(OSSCompleteFileRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/complete');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new CompleteFileModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 指定源文件或文件夹路径，拷贝到指定的文件夹。
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
    public function copyFile(OSSCopyFileRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/copy');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 201)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new CopyFileModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 创建文件或者文件夹。
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
    public function createFile(OSSCreateFileRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/create');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 201)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new CreateFileModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 指定文件或文件夹路径，删除文件或文件夹.
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
    public function deleteFile(OSSDeleteFileRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/delete');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return Model::toModel([
                        'headers' => $_response->headers,
                    ], new DeleteFileModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 获取指定文件或文件夹路径，获取文件或文件夹信息。
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
    public function getFile(OSSGetFileRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/get');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetFileModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 指定文件路径，获取文件下载地址
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
    public function getDownloadUrl(OSSGetDownloadUrlRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/get_download_url');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetDownloadUrlModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 指定文件路径，获取文件安全地址
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
     * @return GetSecureUrlModel
     */
    public function getSecureUrl(OSSGetSecureUrlRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/get_secure_url');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetSecureUrlModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
    public function getUploadUrl(OSSGetUploadUrlRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/get_upload_url');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetUploadUrlModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 指定父文件夹路径，列举文件夹下的文件或者文件夹.
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
    public function listFile(OSSListFileRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/list');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new ListFileModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 列举UploadID对应的已上传分片。
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
    public function listUploadedParts(OSSListUploadedPartRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/list_uploaded_parts');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new ListUploadedPartsModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 指定源文件或文件夹路径，移动到指定的文件夹。
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
    public function moveFile(OSSMoveFileRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/move');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new MoveFileModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 获取视频支持的分辨率.
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
     * @return VideoDefinitionModel
     */
    public function videoDefinition(OSSVideoDefinitionRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/video_definition');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new VideoDefinitionModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 获取视频转码后的m3u8文件.
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
     * @return VideoM3u8Model
     */
    public function videoM3u8(OSSVideoM3U8RequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/video_m3u8');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $byt = Utils::readAsBytes($_response->body);

                    return Model::toModel([
                        'body'    => $byt,
                        'headers' => $_response->headers,
                    ], new VideoM3u8Model());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 将mp4格式的视频文件，转为m3u8.
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
     * @return VideoTranscodeModel
     */
    public function videoTranscode(OSSVideoTranscodeRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/file/video_transcode');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new VideoTranscodeModel());
                }
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return Model::toModel([
                        'headers' => $_response->headers,
                    ], new VideoTranscodeModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 创建共享。
     *
     * @tags share
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return CreateShareModel
     */
    public function createShare(CreateShareRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/share/create');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 201)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new CreateShareModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 删除指定共享.
     *
     * @tags share
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return DeleteShareModel
     */
    public function deleteShare(DeleteShareRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/share/delete');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return Model::toModel([
                        'headers' => $_response->headers,
                    ], new DeleteShareModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 获取共享信息。
     *
     * @tags share
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return GetShareModel
     */
    public function getShare(GetShareRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/share/get');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetShareModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 列举指定用户的共享.
     *
     * @tags share
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListShareModel
     */
    public function listShare(ListShareRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/share/list');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new ListShareModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 修改指定共享.
     *
     * @tags share
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return UpdateShareModel
     */
    public function updateShare(UpdateShareRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/share/update');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new UpdateShareModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
    }

    /**
     * 列举指定store下的所有文件。
     *
     * @tags store
     * @error InvalidParameter The input parameter {parameter_name} is not valid.
     * @error AccessTokenInvalid AccessToken is invalid. {message}
     * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
     * @error NotFound The resource {resource_name} cannot be found. Please check.
     * @error InternalError The request has been failed due to some unknown error.
     * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
     *
     * @throws \Exception
     *
     * @return ListStorefileModel
     */
    public function listStorefile(ListStoreFileRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/osspath/store_file/list');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new ListStorefileModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/create');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 201)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new CreateUserModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/delete');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 204)) {
                    return Model::toModel([
                        'headers' => $_response->headers,
                    ], new DeleteUserModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/get');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new GetUserModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
    public function listUsers(ListUserRequestModel $request, RuntimeOptions $runtime)
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/list');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new ListUsersModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/search');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new SearchUserModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        $_lastRequest = null;
        $_now         = time();
        $_retryTimes  = 0;
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
                $securityToken      = $this->getAccessKeySecret();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'POST';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/user/update');
                $_request->headers  = Tea::merge([
                    'user-agent'   => $this->getUserAgent(),
                    'host'         => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
                    'content-type' => 'application/json; charset=utf-8',
                ], $request->headers);
                if (!Utils::_empty($accessToken)) {
                    $_request->headers['authorization'] = 'Bearer ' . $accessToken . '';
                } elseif (!Utils::_empty($accesskeyId) && !Utils::_empty($accessKeySecret)) {
                    if (!Utils::_empty($securityToken)) {
                        $_request->headers['x-acs-security-token'] = $securityToken;
                    }
                    $_request->headers['date']                    = Utils::getDateUTCString();
                    $_request->headers['accept']                  = 'application/json';
                    $_request->headers['x-acs-signature-method']  = 'HMAC-SHA1';
                    $_request->headers['x-acs-signature-version'] = '1.0';
                    $stringToSign                                 = RoaUtils::getStringToSign($_request);
                    $_request->headers['authorization']           = 'acs ' . $accesskeyId . ':' . RoaUtils::getSignature($stringToSign, $accessKeySecret) . '';
                }
                $_request->body = Utils::toJSONString($request->body);
                $_lastRequest   = $_request;
                $_response      = Tea::send($_request, $_runtime);
                $respMap        = null;
                $obj            = null;
                if (Utils::equalNumber($_response->statusCode, 200)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new UpdateUserModel());
                }
                if (!Utils::_empty($_response->headers['x-ca-error-message'])) {
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
                if (Tea::isRetryable($_runtime['retry'], $_retryTimes)) {
                    continue;
                }

                throw $e;
            }
        }

        throw new TeaUnableRetryError($_lastRequest);
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
        if (Utils::_empty($nickname)) {
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
}
