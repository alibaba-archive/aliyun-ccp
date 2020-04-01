<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class GetAccessTokenByLinkInfoRequest extends Model
{
    public $identity;
    public $type;
    protected $_required = [
        'identity' => true,
        'type'     => true,
    ];
    protected $_name = [
        'identity' => 'identity',
        'type'     => 'type',
    ];
    protected $_description = [
        'identity' => '唯一身份标识',
        'type'     => '认证类型',
    ];
    protected $_example = [
        'identity' => '15208333333',
        'type'     => 'mobile',
    ];
}
