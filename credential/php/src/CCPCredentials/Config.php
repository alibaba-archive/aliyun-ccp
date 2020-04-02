<?php

namespace Aliyun\CCP\Credentials\CCPCredentials;

use AlibabaCloud\Tea\Model;

class Config extends Model
{
    public $endpoint;
    /**
     * @var string
     */
    public $domainId;
    public $clientId;
    public $refreshToken;
    public $clientSecret;
    public $accessToken;
    public $expireTime;

    public function validate()
    {
        Model::validateRequired('domainId', $this->domainId, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['endpoint']     = $this->endpoint;
        $res['domainId']     = $this->domainId;
        $res['clientId']     = $this->clientId;
        $res['refreshToken'] = $this->refreshToken;
        $res['clientSecret'] = $this->clientSecret;
        $res['accessToken']  = $this->accessToken;
        $res['expireTime']   = $this->expireTime;

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

        return $model;
    }
}
