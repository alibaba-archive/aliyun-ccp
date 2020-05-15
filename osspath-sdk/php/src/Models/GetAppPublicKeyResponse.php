<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class GetAppPublicKeyResponse extends Model
{
    /**
     * @description App ID
     *
     * @example cksaljkfiwasdn
     *
     * @var string
     */
    public $appId;

    /**
     * @description RSA加密算法的公钥, PEM格式
     *
     * @example -----BEGIN RSA PUBLIC KEY-----****-----END RSA PUBLIC KEY-----
     *
     * @var string
     */
    public $publicKey;
    protected $_name = [
        'appId'     => 'app_id',
        'publicKey' => 'public_key',
    ];

    public function validate()
    {
        Model::validateRequired('appId', $this->appId, true);
        Model::validateRequired('publicKey', $this->publicKey, true);
    }

    public function toMap()
    {
        $res               = [];
        $res['app_id']     = $this->appId;
        $res['public_key'] = $this->publicKey;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAppPublicKeyResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['app_id'])) {
            $model->appId = $map['app_id'];
        }
        if (isset($map['public_key'])) {
            $model->publicKey = $map['public_key'];
        }

        return $model;
    }
}
