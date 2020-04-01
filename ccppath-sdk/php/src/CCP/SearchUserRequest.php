<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Search user request.
 */
class SearchUserRequest extends Model
{
    public $email;
    public $limit;
    public $marker;
    public $nickName;
    public $phone;
    public $role;
    public $status;
    public $userName;
    protected $_name = [
        'email'    => 'email',
        'limit'    => 'limit',
        'marker'   => 'marker',
        'nickName' => 'nick_name',
        'phone'    => 'phone',
        'role'     => 'role',
        'status'   => 'status',
        'userName' => 'user_name',
    ];
    protected $_description = [
        'email'    => '邮箱',
        'limit'    => '每页大小限制',
        'marker'   => '翻页标记',
        'nickName' => '昵称',
        'phone'    => '电话号码',
        'role'     => '角色',
        'status'   => '状态',
        'userName' => '用户名',
    ];
    protected $_example = [
        'email'    => 'abc@ccp.com',
        'limit'    => 10,
        'marker'   => 'marker',
        'nickName' => 'la',
        'phone'    => '13700000000',
        'role'     => 'user',
        'status'   => 'enabled',
        'userName' => 'abc',
    ];
    protected $_default = [
        'limit'  => 100,
        'role'   => 'user',
        'status' => 'enabled',
    ];
    protected $_format = [
        'limit' => 'int32',
    ];
    protected $_maximum = [
        'limit' => 100,
    ];
    protected $_minimum = [
        'limit' => 1,
    ];
    protected $_enum = [
        'role'   => 'superadmin,  admin,  user',
        'status' => 'enabled,  disabled',
    ];
}
