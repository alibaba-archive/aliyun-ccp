<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class DefaultChangePasswordRequest extends Model
{
    /**
     * @description App ID, 当前访问的App
     *
     * @example csaklidwasdhjwid
     *
     * @var string
     */
    public $appId;

    /**
     * @description AES-256对称加密密钥，通过App公钥加密后传输
     *
     * @example 123456,Abc
     *
     * @var string
     */
    public $encryptedKey;

    /**
     * @description 新密码，必须包含数字和字母，长度8-20个字符
     *
     * @example 123456,Abc
     *
     * @var string
     */
    public $newPassword;

    /**
     * @description 手机号
     *
     * @example 152*****341
     *
     * @var string
     */
    public $phoneNumber;

    /**
     * @description 国家编号，默认86，不需要填+号，直接填数字
     *
     * @example 86
     *
     * @var string
     */
    public $phoneRegion;

    /**
     * @description 修改密码的临时授权码
     *
     * @example csjanwia
     *
     * @var string
     */
    public $state;
    protected $_name = [
        'appId'        => 'app_id',
        'encryptedKey' => 'encrypted_key',
        'newPassword'  => 'new_password',
        'phoneNumber'  => 'phone_number',
        'phoneRegion'  => 'phone_region',
        'state'        => 'state',
    ];

    public function validate()
    {
        Model::validateRequired('appId', $this->appId, true);
        Model::validateRequired('encryptedKey', $this->encryptedKey, true);
        Model::validateRequired('newPassword', $this->newPassword, true);
        Model::validateRequired('phoneNumber', $this->phoneNumber, true);
        Model::validateRequired('state', $this->state, true);
    }

    public function toMap()
    {
        $res                  = [];
        $res['app_id']        = $this->appId;
        $res['encrypted_key'] = $this->encryptedKey;
        $res['new_password']  = $this->newPassword;
        $res['phone_number']  = $this->phoneNumber;
        $res['phone_region']  = $this->phoneRegion;
        $res['state']         = $this->state;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DefaultChangePasswordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['app_id'])) {
            $model->appId = $map['app_id'];
        }
        if (isset($map['encrypted_key'])) {
            $model->encryptedKey = $map['encrypted_key'];
        }
        if (isset($map['new_password'])) {
            $model->newPassword = $map['new_password'];
        }
        if (isset($map['phone_number'])) {
            $model->phoneNumber = $map['phone_number'];
        }
        if (isset($map['phone_region'])) {
            $model->phoneRegion = $map['phone_region'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }

        return $model;
    }
}
