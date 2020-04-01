<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class MobileSendSmsCodeResponse extends Model
{
    public $smsCodeId;
    protected $_required = [
        'smsCodeId' => true,
    ];
    protected $_name = [
        'smsCodeId' => 'sms_code_id',
    ];
    protected $_description = [
        'smsCodeId' => '短信验证码ID',
    ];
    protected $_example = [
        'smsCodeId' => 'csjanwia',
    ];
}
