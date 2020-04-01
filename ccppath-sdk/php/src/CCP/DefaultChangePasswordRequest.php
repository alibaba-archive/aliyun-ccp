<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class DefaultChangePasswordRequest extends Model
{
    public $appId;
    public $newPassword;
    public $phoneNumber;
    public $smsCode;
    public $smsCodeId;
    protected $_required = [
        'appId'       => true,
        'newPassword' => true,
        'phoneNumber' => true,
        'smsCode'     => true,
        'smsCodeId'   => true,
    ];
    protected $_name = [
        'appId'       => 'app_id',
        'newPassword' => 'new_password',
        'phoneNumber' => 'phone_number',
        'smsCode'     => 'sms_code',
        'smsCodeId'   => 'sms_code_id',
    ];
    protected $_description = [
        'appId'       => 'App ID, 当前访问的App',
        'newPassword' => '新密码，必须包含数字和字母，长度8-32个字符',
        'phoneNumber' => '手机号',
        'smsCode'     => '短信验证码内容',
        'smsCodeId'   => '短信验证码ID',
    ];
    protected $_example = [
        'appId'       => 'csaklidwasdhjwid',
        'newPassword' => '123456,abc',
        'phoneNumber' => '152*****341',
        'smsCode'     => '1234',
        'smsCodeId'   => 'csjanwia',
    ];
}
