<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class MobileRegisterRequest extends Model
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
     * @description 待查询的手机号
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
        'phoneNumber' => 'phone_number',
        'smsCode'     => 'sms_code',
        'smsCodeId'   => 'sms_code_id',
    ];

    public function validate()
    {
        Model::validateField($this->appId, 'required', true);
        Model::validateField($this->phoneNumber, 'required', true);
        Model::validateField($this->smsCode, 'required', true);
        Model::validateField($this->smsCodeId, 'required', true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['app_id']       = $this->appId;
        $res['phone_number'] = $this->phoneNumber;
        $res['sms_code']     = $this->smsCode;
        $res['sms_code_id']  = $this->smsCodeId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MobileRegisterRequest
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
        if (isset($map['sms_code'])) {
            $model->smsCode = $map['sms_code'];
        }
        if (isset($map['sms_code_id'])) {
            $model->smsCodeId = $map['sms_code_id'];
        }

        return $model;
    }
}
