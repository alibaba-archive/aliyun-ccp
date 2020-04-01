<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class MobileRegisterRequest extends Model
{
    public $appId;
    public $phoneNumber;
    public $smsCode;
    public $smsCodeId;
    protected $_required = [
        'appId'       => true,
        'phoneNumber' => true,
        'smsCode'     => true,
        'smsCodeId'   => true,
    ];
    protected $_name = [
        'appId'       => 'app_id',
        'phoneNumber' => 'phone_number',
        'smsCode'     => 'sms_code',
        'smsCodeId'   => 'sms_code_id',
    ];
    protected $_description = [
        'appId'       => 'App ID, 当前访问的App',
        'phoneNumber' => '待查询的手机号',
        'smsCode'     => '短信验证码内容',
        'smsCodeId'   => '短信验证码ID',
    ];
    protected $_example = [
        'appId'       => 'csaklidwasdhjwid',
        'phoneNumber' => '152*****341',
        'smsCode'     => '1234',
        'smsCodeId'   => 'csjanwia',
    ];
}
