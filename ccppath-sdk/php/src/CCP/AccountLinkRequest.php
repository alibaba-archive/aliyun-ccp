<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class AccountLinkRequest extends Model
{
    public $detail;
    public $identity;
    public $status;
    public $type;
    public $userId;
    protected $_name = [
        'detail'   => 'detail',
        'identity' => 'identity',
        'status'   => 'status',
        'type'     => 'type',
        'userId'   => 'user_id',
    ];
    protected $_description = [
        'detail'   => '账号信息',
        'identity' => '唯一身份标识',
        'status'   => '状态',
        'type'     => '认证类型',
        'userId'   => '绑定的user_id',
    ];
    protected $_example = [
        'detail'   => '{name:jack,age:20}',
        'identity' => '15208333333',
        'status'   => 'normal',
        'type'     => 'mobile',
        'userId'   => '123987123617823',
    ];
    protected $_required = [
        'identity' => true,
        'type'     => true,
        'userId'   => true,
    ];
}
