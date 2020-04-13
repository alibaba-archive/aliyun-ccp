<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\MGMTClient\MGMTClient;

use AlibabaCloud\Tea\Model;

class Config extends Model
{
    public $endpoint;
    public $region;
    public $protocol;
    public $type;
    public $securityToken;
    public $accessKeyId;
    public $accessKeySecret;
    public $nickname;
    public $userAgent;

    public function validate()
    {
    }

    public function toMap()
    {
        $res                    = [];
        $res['endpoint']        = $this->endpoint;
        $res['region']          = $this->region;
        $res['protocol']        = $this->protocol;
        $res['type']            = $this->type;
        $res['securityToken']   = $this->securityToken;
        $res['accessKeyId']     = $this->accessKeyId;
        $res['accessKeySecret'] = $this->accessKeySecret;
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
        if (isset($map['region'])) {
            $model->region = $map['region'];
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
        if (isset($map['nickname'])) {
            $model->nickname = $map['nickname'];
        }
        if (isset($map['userAgent'])) {
            $model->userAgent = $map['userAgent'];
        }

        return $model;
    }
}
