<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * Get user response.
 */
class GetUserResponse extends Model
{
    /**
     * @description 头像
     *
     * @example http://a.b.c/ccp.jpg
     *
     * @var string
     */
    public $avatar;
    /**
     * @description 用户创建时间
     *
     * @example 1567407718386
     *
     * @var int
     */
    public $createdAt;
    /**
     * @description 默认 Drive ID
     *
     * @example 123
     *
     * @var string
     */
    public $defaultDriveId;
    /**
     * @description 用户备注信息
     *
     * @example ccp team user
     *
     * @var string
     */
    public $description;
    /**
     * @description Domain ID
     *
     * @example hz999
     *
     * @var string
     */
    public $domainId;
    /**
     * @description 邮箱
     *
     * @example 123@ccp.com
     *
     * @var string
     */
    public $email;
    /**
     * @description 昵称
     *
     * @example abc
     *
     * @var string
     */
    public $nickName;
    /**
     * @description 电话
     *
     * @example 13700000000
     *
     * @var string
     */
    public $phone;
    /**
     * @description 角色
     *
     * @example user
     *
     * @var string
     */
    public $role;
    /**
     * @description 用户状态
     *
     * @example enabled
     *
     * @var string
     */
    public $status;
    /**
     * @description 用户修改时间
     *
     * @example 1567407718386
     *
     * @var int
     */
    public $updatedAt;
    /**
     * @description 用户 ID
     *
     * @example ccpuserid
     *
     * @var string
     */
    public $userId;
    /**
     * @description 用户名称
     *
     * @example name
     *
     * @var string
     */
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

    public function validate()
    {
    }

    public function toMap()
    {
        $res                     = [];
        $res['avatar']           = $this->avatar;
        $res['created_at']       = $this->createdAt;
        $res['default_drive_id'] = $this->defaultDriveId;
        $res['description']      = $this->description;
        $res['domain_id']        = $this->domainId;
        $res['email']            = $this->email;
        $res['nick_name']        = $this->nickName;
        $res['phone']            = $this->phone;
        $res['role']             = $this->role;
        $res['status']           = $this->status;
        $res['updated_at']       = $this->updatedAt;
        $res['user_id']          = $this->userId;
        $res['user_name']        = $this->userName;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['created_at'])) {
            $model->createdAt = $map['created_at'];
        }
        if (isset($map['default_drive_id'])) {
            $model->defaultDriveId = $map['default_drive_id'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['nick_name'])) {
            $model->nickName = $map['nick_name'];
        }
        if (isset($map['phone'])) {
            $model->phone = $map['phone'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['updated_at'])) {
            $model->updatedAt = $map['updated_at'];
        }
        if (isset($map['user_id'])) {
            $model->userId = $map['user_id'];
        }
        if (isset($map['user_name'])) {
            $model->userName = $map['user_name'];
        }

        return $model;
    }
}
