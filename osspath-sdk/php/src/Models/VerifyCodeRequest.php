<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class VerifyCodeRequest extends Model
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

    /**
     * @description 需要被校验内容的类型
     *
     * @example password
     *
     * @var string
     */
    public $verifyType;
    protected $_name = [
        'appId'       => 'app_id',
        'phoneNumber' => 'phone_number',
        'phoneRegion' => 'phone_region',
        'smsCode'     => 'sms_code',
        'smsCodeId'   => 'sms_code_id',
        'verifyType'  => 'verify_type',
    ];

    public function validate()
    {
        Model::validateRequired('appId', $this->appId, true);
        Model::validateRequired('phoneNumber', $this->phoneNumber, true);
        Model::validateRequired('smsCode', $this->smsCode, true);
        Model::validateRequired('smsCodeId', $this->smsCodeId, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['app_id']       = $this->appId;
        $res['phone_number'] = $this->phoneNumber;
        $res['phone_region'] = $this->phoneRegion;
        $res['sms_code']     = $this->smsCode;
        $res['sms_code_id']  = $this->smsCodeId;
        $res['verify_type']  = $this->verifyType;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return VerifyCodeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['app_id'])) {
            $model->appId = $map['app_id'];
        }
        if (isset($map['phone_number'])) {
            $model->phoneNumber = $map['phone_number'];
        }
        if (isset($map['phone_region'])) {
            $model->phoneRegion = $map['phone_region'];
        }
        if (isset($map['sms_code'])) {
            $model->smsCode = $map['sms_code'];
        }
        if (isset($map['sms_code_id'])) {
            $model->smsCodeId = $map['sms_code_id'];
        }
        if (isset($map['verify_type'])) {
            $model->verifyType = $map['verify_type'];
        }

        return $model;
    }
}
