<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class LinkInfo extends Model
{
    public $identity;
    public $type;
    protected $_name = [
        'identity' => 'identity',
        'type'     => 'type',
    ];
    protected $_description = [
        'identity' => '当前用户已存在的登录标识',
        'type'     => '当前用户已存在的登录方式',
    ];
    protected $_example = [
        'identity' => '15208345000',
        'type'     => 'mobile',
    ];
}
