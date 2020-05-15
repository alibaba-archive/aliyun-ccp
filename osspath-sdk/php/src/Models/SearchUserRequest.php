<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * Search user request.
 */
class SearchUserRequest extends Model
{
    /**
     * @description 邮箱
     *
     * @example abc@ccp.com
     *
     * @var string
     */
    public $email;

    /**
     * @description 每页大小限制
     *
     * @example 10
     *
     * @var int
     */
    public $limit;

    /**
     * @description 翻页标记
     *
     * @example marker
     *
     * @var string
     */
    public $marker;

    /**
     * @description 昵称
     *
     * @example la
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
     * @description 用户名
     *
     * @example abc
     *
     * @var string
     */
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
    protected $_default = [
        'limit'  => 100,
        'role'   => 'user',
        'status' => 'enabled',
    ];

    public function validate()
    {
        Model::validateMaximum('limit', $this->limit, 100);
        Model::validateMinimum('limit', $this->limit, 1);
    }

    public function toMap()
    {
        $res              = [];
        $res['email']     = $this->email;
        $res['limit']     = $this->limit;
        $res['marker']    = $this->marker;
        $res['nick_name'] = $this->nickName;
        $res['phone']     = $this->phone;
        $res['role']      = $this->role;
        $res['status']    = $this->status;
        $res['user_name'] = $this->userName;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['marker'])) {
            $model->marker = $map['marker'];
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
        if (isset($map['user_name'])) {
            $model->userName = $map['user_name'];
        }

        return $model;
    }
}
