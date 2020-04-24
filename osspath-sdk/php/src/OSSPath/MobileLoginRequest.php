<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class MobileLoginRequest extends Model
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
     * @description 是否自动注册用户，使用密码登录此参数不生效
     *
     * @example false
     *
     * @var bool
     */
    public $autoRegister;

    /**
     * @description 图片验证码ID, 密码登录需要此参数
     *
     * @example abc
     *
     * @var string
     */
    public $captchaId;

    /**
     * @description 用户输入的验证码值, 密码登录需要此参数
     *
     * @example abc
     *
     * @var string
     */
    public $captchaText;

    /**
     * @description 登录密码, 传入此参数则忽略短信验证码，不传此参数则默认使用短信登录。
     *
     * @example 123456
     *
     * @var string
     */
    public $password;

    /**
     * @description 待查询的手机号
     *
     * @example 152*****341
     *
     * @var string
     */
    public $phoneNumber;

    /**
     * @description 短信验证码内容，使用密码登录此参数不生效
     *
     * @example 1234
     *
     * @var string
     */
    public $smsCode;

    /**
     * @description 短信验证码ID，使用密码登录此参数不生效
     *
     * @example csjanwia
     *
     * @var string
     */
    public $smsCodeId;
    protected $_name = [
        'appId'        => 'app_id',
        'autoRegister' => 'auto_register',
        'captchaId'    => 'captcha_id',
        'captchaText'  => 'captcha_text',
        'password'     => 'password',
        'phoneNumber'  => 'phone_number',
        'smsCode'      => 'sms_code',
        'smsCodeId'    => 'sms_code_id',
    ];
    protected $_default = [
        'autoRegister' => 'false',
    ];

    public function validate()
    {
        Model::validateRequired('appId', $this->appId, true);
        Model::validateRequired('phoneNumber', $this->phoneNumber, true);
    }

    public function toMap()
    {
        $res                  = [];
        $res['app_id']        = $this->appId;
        $res['auto_register'] = $this->autoRegister;
        $res['captcha_id']    = $this->captchaId;
        $res['captcha_text']  = $this->captchaText;
        $res['password']      = $this->password;
        $res['phone_number']  = $this->phoneNumber;
        $res['sms_code']      = $this->smsCode;
        $res['sms_code_id']   = $this->smsCodeId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MobileLoginRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['app_id'])) {
            $model->appId = $map['app_id'];
        }
        if (isset($map['auto_register'])) {
            $model->autoRegister = $map['auto_register'];
        }
        if (isset($map['captcha_id'])) {
            $model->captchaId = $map['captcha_id'];
        }
        if (isset($map['captcha_text'])) {
            $model->captchaText = $map['captcha_text'];
        }
        if (isset($map['password'])) {
            $model->password = $map['password'];
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
