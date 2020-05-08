<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * Get share response.
 */
class GetShareResponse extends Model
{
    /**
     * @description created_at
     *
     * @example 2006-01-02T15:04:05.999Z
     *
     * @var string
     */
    public $createdAt;

    /**
     * @description creator
     *
     * @example xxx
     *
     * @var string
     */
    public $creator;

    /**
     * @description description
     *
     * @example share description
     *
     * @var string
     */
    public $description;

    /**
     * @description domain_id
     *
     * @example domain-1
     *
     * @var string
     */
    public $domainId;

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
     * @description expired
     *
     * @example false
     *
     * @var bool
     */
    public $expired;

    /**
     * @description owner
     *
     * @example xxx
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
     * @description share_path
     *
     * @example /a/b/c/
     *
     * @var string
     */
    public $shareFilePath;

    /**
     * @description share_id
     *
     * @example 3d336314-63c8-4d96-bce0-17aefb6833b6
     *
     * @var string
     */
    public $shareId;

    /**
     * @description share_name
     *
     * @example new_share
     *
     * @var string
     */
    public $shareName;

    /**
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

    /**
     * @description updated_at
     *
     * @example 2006-01-02T15:04:05.999Z
     *
     * @var string
     */
    public $updatedAt;
    protected $_name = [
        'createdAt'     => 'created_at',
        'creator'       => 'creator',
        'description'   => 'description',
        'domainId'      => 'domain_id',
        'driveId'       => 'drive_id',
        'expiration'    => 'expiration',
        'expired'       => 'expired',
        'owner'         => 'owner',
        'permissions'   => 'permissions',
        'shareFilePath' => 'share_file_path',
        'shareId'       => 'share_id',
        'shareName'     => 'share_name',
        'sharePolicy'   => 'share_policy',
        'status'        => 'status',
        'updatedAt'     => 'updated_at',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                = [];
        $res['created_at']  = $this->createdAt;
        $res['creator']     = $this->creator;
        $res['description'] = $this->description;
        $res['domain_id']   = $this->domainId;
        $res['drive_id']    = $this->driveId;
        $res['expiration']  = $this->expiration;
        $res['expired']     = $this->expired;
        $res['owner']       = $this->owner;
        $res['permissions'] = [];
        if (null !== $this->permissions) {
            $res['permissions'] = $this->permissions;
        }
        $res['share_file_path'] = $this->shareFilePath;
        $res['share_id']        = $this->shareId;
        $res['share_name']      = $this->shareName;
        $res['share_policy']    = [];
        if (null !== $this->sharePolicy && \is_array($this->sharePolicy)) {
            $n = 0;
            foreach ($this->sharePolicy as $item) {
                $res['share_policy'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['status']     = $this->status;
        $res['updated_at'] = $this->updatedAt;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetShareResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['created_at'])) {
            $model->createdAt = $map['created_at'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['expiration'])) {
            $model->expiration = $map['expiration'];
        }
        if (isset($map['expired'])) {
            $model->expired = $map['expired'];
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
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
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
        if (isset($map['updated_at'])) {
            $model->updatedAt = $map['updated_at'];
        }

        return $model;
    }
}
