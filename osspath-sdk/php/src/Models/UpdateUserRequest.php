<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * Update user request.
 */
class UpdateUserRequest extends Model
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
     * @description 描述信息
     *
     * @example ccp team user
     *
     * @var string
     */
    public $description;

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
     * @example ccpuser
     *
     * @var string
     */
    public $nickName;

    /**
     * @description 电话号码
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
     * @description 状态
     *
     * @example enabled
     *
     * @var string
     */
    public $status;

    /**
     * @description 用户 ID
     *
     * @example ccpuserid
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'avatar'      => 'avatar',
        'description' => 'description',
        'email'       => 'email',
        'nickName'    => 'nick_name',
        'phone'       => 'phone',
        'role'        => 'role',
        'status'      => 'status',
        'userId'      => 'user_id',
    ];
    protected $_default = [
        'role'   => 'user',
        'status' => 'enabled',
    ];

    public function validate()
    {
        Model::validateMaximum('description', $this->description, 1024);
        Model::validateRequired('userId', $this->userId, true);
    }

    public function toMap()
    {
        $res                = [];
        $res['avatar']      = $this->avatar;
        $res['description'] = $this->description;
        $res['email']       = $this->email;
        $res['nick_name']   = $this->nickName;
        $res['phone']       = $this->phone;
        $res['role']        = $this->role;
        $res['status']      = $this->status;
        $res['user_id']     = $this->userId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
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
        if (isset($map['user_id'])) {
            $model->userId = $map['user_id'];
        }

        return $model;
    }
}
