<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class MobileCheckExistRequest extends Model
{
    public $appId;
    public $phoneNumber;
    protected $_required = [
        'appId'       => true,
        'phoneNumber' => true,
    ];
    protected $_name = [
        'appId'       => 'app_id',
        'phoneNumber' => 'phone_number',
    ];
    protected $_description = [
        'appId'       => 'App ID, 当前访问的App',
        'phoneNumber' => '待查询的手机号',
    ];
    protected $_example = [
        'appId'       => 'csaklidwasdhjwid',
        'phoneNumber' => '152*****341',
    ];
}
