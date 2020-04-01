<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class MobileSendSmsCodeRequest extends Model
{
    public $appId;
    public $captchaId;
    public $captchaText;
    public $phoneNumber;
    public $type;
    protected $_required = [
        'appId'       => true,
        'phoneNumber' => true,
        'type'        => true,
    ];
    protected $_name = [
        'appId'       => 'app_id',
        'captchaId'   => 'captcha_id',
        'captchaText' => 'captcha_text',
        'phoneNumber' => 'phone_number',
        'type'        => 'type',
    ];
    protected $_description = [
        'appId'       => 'App ID, 当前访问的App',
        'captchaId'   => '图片验证码ID',
        'captchaText' => '用户输入的验证码值',
        'phoneNumber' => '待发送验证短信的手机号',
        'type'        => '验证码用途',
    ];
    protected $_example = [
        'appId'       => 'csaklidwasdhjwid',
        'captchaId'   => 'abc',
        'captchaText' => 'abc',
        'phoneNumber' => '152*****341',
        'type'        => 'abc',
    ];
}
