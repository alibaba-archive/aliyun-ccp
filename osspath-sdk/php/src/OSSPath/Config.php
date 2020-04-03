<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class Config extends Model
{
    public $endpoint;
    /**
     * @var string
     */
    public $domainId;
    public $protocol;
    public $type;
    public $securityToken;
    public $accessKeyId;
    public $accessKeySecret;
    public $clientId;
    public $refreshToken;
    public $clientSecret;
    public $accessToken;
    public $expireTime;
    public $nickname;
    public $userAgent;

    public function validate()
    {
        Model::validateRequired('domainId', $this->domainId, true);
    }

    public function toMap()
    {
        $res                    = [];
        $res['endpoint']        = $this->endpoint;
        $res['domainId']        = $this->domainId;
        $res['protocol']        = $this->protocol;
        $res['type']            = $this->type;
        $res['securityToken']   = $this->securityToken;
        $res['accessKeyId']     = $this->accessKeyId;
        $res['accessKeySecret'] = $this->accessKeySecret;
        $res['clientId']        = $this->clientId;
        $res['refreshToken']    = $this->refreshToken;
        $res['clientSecret']    = $this->clientSecret;
        $res['accessToken']     = $this->accessToken;
        $res['expireTime']      = $this->expireTime;
        $res['nickname']        = $this->nickname;
        $res['userAgent']       = $this->userAgent;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return Config
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endpoint'])) {
            $model->endpoint = $map['endpoint'];
        }
        if (isset($map['domainId'])) {
            $model->domainId = $map['domainId'];
        }
        if (isset($map['protocol'])) {
            $model->protocol = $map['protocol'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['securityToken'])) {
            $model->securityToken = $map['securityToken'];
        }
        if (isset($map['accessKeyId'])) {
            $model->accessKeyId = $map['accessKeyId'];
        }
        if (isset($map['accessKeySecret'])) {
            $model->accessKeySecret = $map['accessKeySecret'];
        }
        if (isset($map['clientId'])) {
            $model->clientId = $map['clientId'];
        }
        if (isset($map['refreshToken'])) {
            $model->refreshToken = $map['refreshToken'];
        }
        if (isset($map['clientSecret'])) {
            $model->clientSecret = $map['clientSecret'];
        }
        if (isset($map['accessToken'])) {
            $model->accessToken = $map['accessToken'];
        }
        if (isset($map['expireTime'])) {
            $model->expireTime = $map['expireTime'];
        }
        if (isset($map['nickname'])) {
            $model->nickname = $map['nickname'];
        }
        if (isset($map['userAgent'])) {
            $model->userAgent = $map['userAgent'];
        }

        return $model;
    }
}
