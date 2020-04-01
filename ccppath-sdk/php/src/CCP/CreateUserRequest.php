<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Create user request.
 */
class CreateUserRequest extends Model
{
    public $avatar;
    public $description;
    public $email;
    public $nickName;
    public $phone;
    public $role;
    public $status;
    public $userId;
    public $userName;
    protected $_name = [
        'avatar'      => 'avatar',
        'description' => 'description',
        'email'       => 'email',
        'nickName'    => 'nick_name',
        'phone'       => 'phone',
        'role'        => 'role',
        'status'      => 'status',
        'userId'      => 'user_id',
        'userName'    => 'user_name',
    ];
    protected $_description = [
        'avatar'      => '头像',
        'description' => '描述信息',
        'email'       => '邮箱',
        'nickName'    => '昵称',
        'phone'       => '电话号码',
        'role'        => '角色',
        'status'      => '状态',
        'userId'      => '用户 ID',
        'userName'    => '用户名称',
    ];
    protected $_example = [
        'avatar'      => 'http://a.b.c/ccp.jpg',
        'description' => 'ccp team user',
        'email'       => '123@ccp.com',
        'nickName'    => 'ccpuser',
        'phone'       => '13700000000',
        'role'        => 'user',
        'status'      => 'enabled',
        'userId'      => 'ccpuserid',
        'userName'    => 'abc',
    ];
    protected $_maximum = [
        'description' => 1024,
    ];
    protected $_default = [
        'role'   => 'user',
        'status' => 'enabled',
    ];
    protected $_enum = [
        'role'   => 'superadmin,  admin,  user',
        'status' => 'enabled,  disabled',
    ];
    protected $_required = [
        'userId' => true,
    ];
}
