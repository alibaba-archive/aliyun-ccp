<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK;

use AlibabaCloud\Credentials\Credential;
use AlibabaCloud\Tea\Exception\TeaError;
use AlibabaCloud\Tea\Exception\TeaUnableRetryError;
use AlibabaCloud\Tea\Model;
use AlibabaCloud\Tea\Request;
use AlibabaCloud\Tea\RoaUtils\RoaUtils;
use AlibabaCloud\Tea\Tea;
use AlibabaCloud\Tea\Utils\Utils;
use Aliyun\CCP\SDK\CCP\AccountLinkRequestModel;
use Aliyun\CCP\SDK\CCP\CancelLinkModel;
use Aliyun\CCP\SDK\CCP\CancelLinkRequestModel;
use Aliyun\CCP\SDK\CCP\CCPBatchRequestModel;
use Aliyun\CCP\SDK\CCP\CCPCompleteFileRequestModel;
use Aliyun\CCP\SDK\CCP\CCPCopyFileRequestModel;
use Aliyun\CCP\SDK\CCP\CCPCreateFileRequestModel;
use Aliyun\CCP\SDK\CCP\CCPDeleteFileRequestModel;
use Aliyun\CCP\SDK\CCP\CCPGetAsyncTaskRequestModel;
use Aliyun\CCP\SDK\CCP\CCPGetDownloadUrlRequestModel;
use Aliyun\CCP\SDK\CCP\CCPGetFileRequestModel;
use Aliyun\CCP\SDK\CCP\CCPGetUploadUrlRequestModel;
use Aliyun\CCP\SDK\CCP\CCPListFileRequestModel;
use Aliyun\CCP\SDK\CCP\CCPListUploadedPartRequestModel;
use Aliyun\CCP\SDK\CCP\CCPMoveFileRequestModel;
use Aliyun\CCP\SDK\CCP\CCPSearchFileRequestModel;
use Aliyun\CCP\SDK\CCP\CCPUpdateFileMetaRequestModel;
use Aliyun\CCP\SDK\CCP\ChangePasswordModel;
use Aliyun\CCP\SDK\CCP\CheckExistModel;
use Aliyun\CCP\SDK\CCP\CompleteFileModel;
use Aliyun\CCP\SDK\CCP\Config;
use Aliyun\CCP\SDK\CCP\ConfirmLinkModel;
use Aliyun\CCP\SDK\CCP\ConfirmLinkRequestModel;
use Aliyun\CCP\SDK\CCP\CopyFileModel;
use Aliyun\CCP\SDK\CCP\CreateDriveModel;
use Aliyun\CCP\SDK\CCP\CreateDriveRequestModel;
use Aliyun\CCP\SDK\CCP\CreateFileModel;
use Aliyun\CCP\SDK\CCP\CreateUserModel;
use Aliyun\CCP\SDK\CCP\CreateUserRequestModel;
use Aliyun\CCP\SDK\CCP\DefaultChangePasswordRequestModel;
use Aliyun\CCP\SDK\CCP\DefaultSetPasswordRequestModel;
use Aliyun\CCP\SDK\CCP\DeleteDriveModel;
use Aliyun\CCP\SDK\CCP\DeleteDriveRequestModel;
use Aliyun\CCP\SDK\CCP\DeleteFileModel;
use Aliyun\CCP\SDK\CCP\DeleteUserModel;
use Aliyun\CCP\SDK\CCP\DeleteUserRequestModel;
use Aliyun\CCP\SDK\CCP\DownloadFileModel;
use Aliyun\CCP\SDK\CCP\DownloadFileRequestModel;
use Aliyun\CCP\SDK\CCP\GetAccessTokenByLinkInfoModel;
use Aliyun\CCP\SDK\CCP\GetAccessTokenByLinkInfoRequestModel;
use Aliyun\CCP\SDK\CCP\GetAsyncTaskInfoModel;
use Aliyun\CCP\SDK\CCP\GetByLinkInfoRequestModel;
use Aliyun\CCP\SDK\CCP\GetCaptchaModel;
use Aliyun\CCP\SDK\CCP\GetCaptchaRequestModel;
use Aliyun\CCP\SDK\CCP\GetDefaultDriveModel;
use Aliyun\CCP\SDK\CCP\GetDefaultDriveRequestModel;
use Aliyun\CCP\SDK\CCP\GetDownloadUrlModel;
use Aliyun\CCP\SDK\CCP\GetDriveModel;
use Aliyun\CCP\SDK\CCP\GetDriveRequestModel;
use Aliyun\CCP\SDK\CCP\GetFileModel;
use Aliyun\CCP\SDK\CCP\GetImageCountRequestModel;
use Aliyun\CCP\SDK\CCP\GetLinkInfoByUserIdModel;
use Aliyun\CCP\SDK\CCP\GetLinkInfoByUserIDRequestModel;
use Aliyun\CCP\SDK\CCP\GetLinkInfoModel;
use Aliyun\CCP\SDK\CCP\GetPhotoCountModel;
use Aliyun\CCP\SDK\CCP\GetUploadUrlModel;
use Aliyun\CCP\SDK\CCP\GetUserModel;
use Aliyun\CCP\SDK\CCP\GetUserRequestModel;
use Aliyun\CCP\SDK\CCP\LinkModel;
use Aliyun\CCP\SDK\CCP\ListAddressGroupsModel;
use Aliyun\CCP\SDK\CCP\ListDriveRequestModel;
use Aliyun\CCP\SDK\CCP\ListDrivesModel;
use Aliyun\CCP\SDK\CCP\ListFaceGroupsModel;
use Aliyun\CCP\SDK\CCP\ListFileModel;
use Aliyun\CCP\SDK\CCP\ListImageAddressGroupsRequestModel;
use Aliyun\CCP\SDK\CCP\ListImageFaceGroupsRequestModel;
use Aliyun\CCP\SDK\CCP\ListImageTagsRequestModel;
use Aliyun\CCP\SDK\CCP\ListMyDriveRequestModel;
use Aliyun\CCP\SDK\CCP\ListMyDrivesModel;
use Aliyun\CCP\SDK\CCP\ListTagsModel;
use Aliyun\CCP\SDK\CCP\ListUploadedPartsModel;
use Aliyun\CCP\SDK\CCP\ListUserRequestModel;
use Aliyun\CCP\SDK\CCP\ListUsersModel;
use Aliyun\CCP\SDK\CCP\LoginModel;
use Aliyun\CCP\SDK\CCP\MobileCheckExistRequestModel;
use Aliyun\CCP\SDK\CCP\MobileLoginRequestModel;
use Aliyun\CCP\SDK\CCP\MobileRegisterRequestModel;
use Aliyun\CCP\SDK\CCP\MobileSendSmsCodeModel;
use Aliyun\CCP\SDK\CCP\MobileSendSmsCodeRequestModel;
use Aliyun\CCP\SDK\CCP\MoveFileModel;
use Aliyun\CCP\SDK\CCP\OperationModel;
use Aliyun\CCP\SDK\CCP\RegisterModel;
use Aliyun\CCP\SDK\CCP\RuntimeOptions;
use Aliyun\CCP\SDK\CCP\SearchFileModel;
use Aliyun\CCP\SDK\CCP\SearchUserModel;
use Aliyun\CCP\SDK\CCP\SearchUserRequestModel;
use Aliyun\CCP\SDK\CCP\SetPasswordModel;
use Aliyun\CCP\SDK\CCP\TokenModel;
use Aliyun\CCP\SDK\CCP\TokenRequestModel;
use Aliyun\CCP\SDK\CCP\UpdateDriveModel;
use Aliyun\CCP\SDK\CCP\UpdateDriveRequestModel;
use Aliyun\CCP\SDK\CCP\UpdateFileModel;
use Aliyun\CCP\SDK\CCP\UpdateUserModel;
use Aliyun\CCP\SDK\CCP\UpdateUserRequestModel;

class CCP
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
    public function getAsyncTaskInfo(CCPGetAsyncTaskRequestModel $request, RuntimeOptions $runtime)
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
                    ], new GetAsyncTaskInfoModel());
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
     * @return OperationModel
     */
    public function operation(CCPBatchRequestModel $request, RuntimeOptions $runtime)
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
                    ], new OperationModel());
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
    public function completeFile(CCPCompleteFileRequestModel $request, RuntimeOptions $runtime)
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
    public function copyFile(CCPCopyFileRequestModel $request, RuntimeOptions $runtime)
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
                if (Utils::equalNumber($_response->statusCode, 202)) {
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
    public function createFile(CCPCreateFileRequestModel $request, RuntimeOptions $runtime)
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
    public function deleteFile(CCPDeleteFileRequestModel $request, RuntimeOptions $runtime)
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
                if (Utils::equalNumber($_response->statusCode, 202)) {
                    $obj     = Utils::readAsJSON($_response->body);
                    $respMap = Utils::assertAsMap($obj);

                    return Model::toModel([
                        'body'    => $respMap,
                        'headers' => $_response->headers,
                    ], new DeleteFileModel());
                }
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
                $securityToken      = $this->getSecurityToken();
                $accessToken        = $this->getAccessToken();
                $_request->protocol = Utils::defaultString($this->_protocol, 'https');
                $_request->method   = 'GET';
                $_request->pathname = $this->getPathname($this->_nickname, '/v2/file/download');
                $_request->query    = Utils::stringifyMapValue($request->query);
                $_request->headers  = Tea::merge([
                    'user-agent' => $this->getUserAgent(),
                    'host'       => Utils::defaultString($this->_endpoint, '' . $this->_domainId . '.api.alicloudccp.com'),
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
                $_lastRequest = $_request;
                $_response    = Tea::send($_request, $_runtime);
                $respMap      = null;
                $obj          = null;
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
    public function getFile(CCPGetFileRequestModel $request, RuntimeOptions $runtime)
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
    public function getDownloadUrl(CCPGetDownloadUrlRequestModel $request, RuntimeOptions $runtime)
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
    public function getUploadUrl(CCPGetUploadUrlRequestModel $request, RuntimeOptions $runtime)
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
    public function listFile(CCPListFileRequestModel $request, RuntimeOptions $runtime)
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
    public function listUploadedParts(CCPListUploadedPartRequestModel $request, RuntimeOptions $runtime)
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
    public function moveFile(CCPMoveFileRequestModel $request, RuntimeOptions $runtime)
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
    public function searchFile(CCPSearchFileRequestModel $request, RuntimeOptions $runtime)
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
                    ], new SearchFileModel());
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
    public function updateFile(CCPUpdateFileMetaRequestModel $request, RuntimeOptions $runtime)
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
                    ], new UpdateFileModel());
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
    public function getPhotoCount(GetImageCountRequestModel $request, RuntimeOptions $runtime)
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
                    ], new GetPhotoCountModel());
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
    public function listAddressGroups(ListImageAddressGroupsRequestModel $request, RuntimeOptions $runtime)
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
                    ], new ListAddressGroupsModel());
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
    public function listFaceGroups(ListImageFaceGroupsRequestModel $request, RuntimeOptions $runtime)
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
                    ], new ListFaceGroupsModel());
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
    public function listTags(ListImageTagsRequestModel $request, RuntimeOptions $runtime)
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
                    ], new ListTagsModel());
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
