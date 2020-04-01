<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class MobileLoginRequest extends Model
{
    public $appId;
    public $autoRegister;
    public $captchaId;
    public $captchaText;
    public $password;
    public $phoneNumber;
    public $smsCode;
    public $smsCodeId;
    protected $_required = [
        'appId'       => true,
        'phoneNumber' => true,
    ];
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
    protected $_description = [
        'appId'        => 'App ID, 当前访问的App',
        'autoRegister' => '是否自动注册用户，使用密码登录此参数不生效',
        'captchaId'    => '图片验证码ID, 密码登录需要此参数',
        'captchaText'  => '用户输入的验证码值, 密码登录需要此参数',
        'password'     => '登录密码, 传入此参数则忽略短信验证码，不传此参数则默认使用短信登录。',
        'phoneNumber'  => '待查询的手机号',
        'smsCode'      => '短信验证码内容，使用密码登录此参数不生效',
        'smsCodeId'    => '短信验证码ID，使用密码登录此参数不生效',
    ];
    protected $_example = [
        'appId'        => 'csaklidwasdhjwid',
        'autoRegister' => 'false',
        'captchaId'    => 'abc',
        'captchaText'  => 'abc',
        'password'     => '123456',
        'phoneNumber'  => '152*****341',
        'smsCode'      => '1234',
        'smsCodeId'    => 'csjanwia',
    ];
    protected $_default = [
        'autoRegister' => 'false',
    ];
}
