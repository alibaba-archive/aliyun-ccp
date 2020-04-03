<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class GetUserAccessTokenRequest extends Model
{
    /**
     * @description 角色
     *
     * @example user
     *
     * @var string
     */
    public $role;
    /**
     * @description 用户 ID
     *
     * @example ccpuserid
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'role'   => 'role',
        'userId' => 'user_id',
    ];
    protected $_default = [
        'role' => 'user',
    ];

    public function validate()
    {
        Model::validateRequired('userId', $this->userId, true);
    }

    public function toMap()
    {
        $res            = [];
        $res['role']    = $this->role;
        $res['user_id'] = $this->userId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserAccessTokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['user_id'])) {
            $model->userId = $map['user_id'];
        }

        return $model;
    }
}
