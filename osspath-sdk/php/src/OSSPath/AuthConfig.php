<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class AuthConfig extends Model
{
    /**
     * @var string
     */
    public $appId;
    /**
     * @var string
     */
    public $appSecret;
    /**
     * @var bool
     */
    public $enable;
    /**
     * @var string
     */
    public $endpoint;
    /**
     * @var string
     */
    public $enterpriseId;
    protected $_name = [
        'appId'        => 'app_id',
        'appSecret'    => 'app_secret',
        'enable'       => 'enable',
        'endpoint'     => 'endpoint',
        'enterpriseId' => 'enterprise_id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                  = [];
        $res['app_id']        = $this->appId;
        $res['app_secret']    = $this->appSecret;
        $res['enable']        = $this->enable;
        $res['endpoint']      = $this->endpoint;
        $res['enterprise_id'] = $this->enterpriseId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AuthConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['app_id'])) {
            $model->appId = $map['app_id'];
        }
        if (isset($map['app_secret'])) {
            $model->appSecret = $map['app_secret'];
        }
        if (isset($map['enable'])) {
            $model->enable = $map['enable'];
        }
        if (isset($map['endpoint'])) {
            $model->endpoint = $map['endpoint'];
        }
        if (isset($map['enterprise_id'])) {
            $model->enterpriseId = $map['enterprise_id'];
        }

        return $model;
    }
}
