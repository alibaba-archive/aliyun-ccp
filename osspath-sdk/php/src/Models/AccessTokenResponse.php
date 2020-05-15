<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class AccessTokenResponse extends Model
{
    /**
     * @description 用于调用业务接口的accessToken
     *
     * @example cnskjajkahwdhwialsnd
     *
     * @var string
     */
    public $accessToken;

    /**
     * @description Default Drive ID
     *
     * @example 100
     *
     * @var string
     */
    public $defaultDriveId;

    /**
     * @description accessToken过期时间，ISO时间
     *
     * @example 2019-09-01T06:57:48.813Z
     *
     * @var string
     */
    public $expireTime;

    /**
     * @description accessToken过期时间，单位秒
     *
     * @example 3600
     *
     * @var int
     */
    public $expiresIn;

    /**
     * @description 用于刷新accessToken
     *
     * @example cnskjajkahwdhwialsnd
     *
     * @var string
     */
    public $refreshToken;

    /**
     * @description 当前用户角色
     *
     * @example user
     *
     * @var string
     */
    public $role;

    /**
     * @description accessToken类型，Bearer
     *
     * @example Bearer
     *
     * @var string
     */
    public $tokenType;

    /**
     * @description 当前用户ID
     *
     * @example DING-xxxxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'accessToken'    => 'access_token',
        'defaultDriveId' => 'default_drive_id',
        'expireTime'     => 'expire_time',
        'expiresIn'      => 'expires_in',
        'refreshToken'   => 'refresh_token',
        'role'           => 'role',
        'tokenType'      => 'token_type',
        'userId'         => 'user_id',
    ];

    public function validate()
    {
        Model::validateRequired('accessToken', $this->accessToken, true);
        Model::validateRequired('defaultDriveId', $this->defaultDriveId, true);
        Model::validateRequired('expireTime', $this->expireTime, true);
        Model::validateRequired('expiresIn', $this->expiresIn, true);
        Model::validateRequired('refreshToken', $this->refreshToken, true);
        Model::validateRequired('role', $this->role, true);
        Model::validateRequired('tokenType', $this->tokenType, true);
        Model::validateRequired('userId', $this->userId, true);
    }

    public function toMap()
    {
        $res                     = [];
        $res['access_token']     = $this->accessToken;
        $res['default_drive_id'] = $this->defaultDriveId;
        $res['expire_time']      = $this->expireTime;
        $res['expires_in']       = $this->expiresIn;
        $res['refresh_token']    = $this->refreshToken;
        $res['role']             = $this->role;
        $res['token_type']       = $this->tokenType;
        $res['user_id']          = $this->userId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AccessTokenResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['access_token'])) {
            $model->accessToken = $map['access_token'];
        }
        if (isset($map['default_drive_id'])) {
            $model->defaultDriveId = $map['default_drive_id'];
        }
        if (isset($map['expire_time'])) {
            $model->expireTime = $map['expire_time'];
        }
        if (isset($map['expires_in'])) {
            $model->expiresIn = $map['expires_in'];
        }
        if (isset($map['refresh_token'])) {
            $model->refreshToken = $map['refresh_token'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['token_type'])) {
            $model->tokenType = $map['token_type'];
        }
        if (isset($map['user_id'])) {
            $model->userId = $map['user_id'];
        }

        return $model;
    }
}
