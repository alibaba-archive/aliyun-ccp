<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Get user response.
 */
class GetUserResponse extends Model
{
    public $avatar;
    public $createdAt;
    public $defaultDriveId;
    public $description;
    public $domainId;
    public $email;
    public $nickName;
    public $phone;
    public $role;
    public $status;
    public $updatedAt;
    public $userId;
    public $userName;
    protected $_name = [
        'avatar'         => 'avatar',
        'createdAt'      => 'created_at',
        'defaultDriveId' => 'default_drive_id',
        'description'    => 'description',
        'domainId'       => 'domain_id',
        'email'          => 'email',
        'nickName'       => 'nick_name',
        'phone'          => 'phone',
        'role'           => 'role',
        'status'         => 'status',
        'updatedAt'      => 'updated_at',
        'userId'         => 'user_id',
        'userName'       => 'user_name',
    ];
    protected $_description = [
        'avatar'         => '头像',
        'createdAt'      => '用户创建时间',
        'defaultDriveId' => '默认 Drive ID',
        'description'    => '用户备注信息',
        'domainId'       => 'Domain ID',
        'email'          => '邮箱',
        'nickName'       => '昵称',
        'phone'          => '电话',
        'role'           => '角色',
        'status'         => '用户状态',
        'updatedAt'      => '用户修改时间',
        'userId'         => '用户 ID',
        'userName'       => '用户名称',
    ];
    protected $_example = [
        'avatar'         => 'http://a.b.c/ccp.jpg',
        'createdAt'      => 1567407718386,
        'defaultDriveId' => '123',
        'description'    => 'ccp team user',
        'domainId'       => 'hz999',
        'email'          => '123@ccp.com',
        'nickName'       => 'abc',
        'phone'          => '13700000000',
        'role'           => 'user',
        'status'         => 'enabled',
        'updatedAt'      => 1567407718386,
        'userId'         => 'ccpuserid',
        'userName'       => 'name',
    ];
    protected $_format = [
        'createdAt' => 'int64',
        'updatedAt' => 'int64',
    ];
}
