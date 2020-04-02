<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

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
     * @description 新密码，必须包含数字和字母，长度8-32个字符
     *
     * @example 123456,abc
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
     * @description 短信验证码内容
     *
     * @example 1234
     *
     * @var string
     */
    public $smsCode;
    /**
     * @description 短信验证码ID
     *
     * @example csjanwia
     *
     * @var string
     */
    public $smsCodeId;
    protected $_name = [
        'appId'       => 'app_id',
        'newPassword' => 'new_password',
        'phoneNumber' => 'phone_number',
        'smsCode'     => 'sms_code',
        'smsCodeId'   => 'sms_code_id',
    ];

    public function validate()
    {
        Model::validateRequired('appId', $this->appId, true);
        Model::validateRequired('newPassword', $this->newPassword, true);
        Model::validateRequired('phoneNumber', $this->phoneNumber, true);
        Model::validateRequired('smsCode', $this->smsCode, true);
        Model::validateRequired('smsCodeId', $this->smsCodeId, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['app_id']       = $this->appId;
        $res['new_password'] = $this->newPassword;
        $res['phone_number'] = $this->phoneNumber;
        $res['sms_code']     = $this->smsCode;
        $res['sms_code_id']  = $this->smsCodeId;

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
        if (isset($map['new_password'])) {
            $model->newPassword = $map['new_password'];
        }
        if (isset($map['phone_number'])) {
            $model->phoneNumber = $map['phone_number'];
        }
        if (isset($map['sms_code'])) {
            $model->smsCode = $map['sms_code'];
        }
        if (isset($map['sms_code_id'])) {
            $model->smsCodeId = $map['sms_code_id'];
        }

        return $model;
    }
}
