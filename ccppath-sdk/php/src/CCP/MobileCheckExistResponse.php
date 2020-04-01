<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class MobileCheckExistResponse extends Model
{
    public $isExist;
    public $phoneNumber;
    protected $_required = [
        'isExist'     => true,
        'phoneNumber' => true,
    ];
    protected $_name = [
        'isExist'     => 'is_exist',
        'phoneNumber' => 'phone_number',
    ];
    protected $_description = [
        'isExist'     => '当前手机号是否存在',
        'phoneNumber' => '待查询的手机号',
    ];
    protected $_example = [
        'isExist'     => 'true',
        'phoneNumber' => '152*****341',
    ];
}
