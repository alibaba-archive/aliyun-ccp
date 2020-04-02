<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * create share request.
 */
class CreateShareRequest extends Model
{
    /**
     * @description description
     *
     * @example share description
     *
     * @var string
     */
    public $description;
    /**
     * @description drive_id
     *
     * @example 1
     *
     * @var string
     */
    public $driveId;
    /**
     * @description expiration
     *
     * @example 2006-01-02T15:04:05.999Z
     *
     * @var string
     */
    public $expiration;
    /**
     * @description creator
     *
     * @example abc
     *
     * @var string
     */
    public $owner;
    /**
     * @description permissions
     *
     * @example
     *
     * @var array
     */
    public $permissions;
    /**
     * @description share_file_path
     *
     * @var string
     */
    public $shareFilePath;
    /**
     * @description share_name
     *
     * @example share
     *
     * @var string
     */
    public $shareName;
    /**
     * @description share create policy
     *
     * share_policy
     * @var array
     */
    public $sharePolicy;
    /**
     * @description status
     *
     * @example enabled
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'description'   => 'description',
        'driveId'       => 'drive_id',
        'expiration'    => 'expiration',
        'owner'         => 'owner',
        'permissions'   => 'permissions',
        'shareFilePath' => 'share_file_path',
        'shareName'     => 'share_name',
        'sharePolicy'   => 'share_policy',
        'status'        => 'status',
    ];

    public function validate()
    {
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('owner', $this->owner, true);
        Model::validateRequired('shareFilePath', $this->shareFilePath, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
    }

    public function toMap()
    {
        $res                = [];
        $res['description'] = $this->description;
        $res['drive_id']    = $this->driveId;
        $res['expiration']  = $this->expiration;
        $res['owner']       = $this->owner;
        $res['permissions'] = [];
        if (null !== $this->permissions) {
            $res['permissions'] = $this->permissions;
        }
        $res['share_file_path'] = $this->shareFilePath;
        $res['share_name']      = $this->shareName;
        $res['share_policy']    = [];
        if (null !== $this->sharePolicy && \is_array($this->sharePolicy)) {
            $n = 0;
            foreach ($this->sharePolicy as $item) {
                $res['share_policy'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['status'] = $this->status;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateShareRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['expiration'])) {
            $model->expiration = $map['expiration'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
        }
        if (isset($map['permissions'])) {
            if (!empty($map['permissions'])) {
                $model->permissions = [];
                $model->permissions = $map['permissions'];
            }
        }
        if (isset($map['share_file_path'])) {
            $model->shareFilePath = $map['share_file_path'];
        }
        if (isset($map['share_name'])) {
            $model->shareName = $map['share_name'];
        }
        if (isset($map['share_policy'])) {
            if (!empty($map['share_policy'])) {
                $model->sharePolicy = [];
                $n                  = 0;
                foreach ($map['share_policy'] as $item) {
                    $model->sharePolicy[$n++] = null !== $item ? SharePermissionPolicy::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
