<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * update share request.
 */
class UpdateShareRequest extends Model
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
     * @description expiration
     *
     * @example 2006-01-02T15:04:05.999Z
     *
     * @var string
     */
    public $expiration;
    /**
     * @description permissions
     *
     * @example
     *
     * @var array
     */
    public $permissions;
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
     * @example new_share_name
     *
     * @var string
     */
    public $shareName;
    /**
     * @description share_policy
     *
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
        'description' => 'description',
        'expiration'  => 'expiration',
        'permissions' => 'permissions',
        'shareId'     => 'share_id',
        'shareName'   => 'share_name',
        'sharePolicy' => 'share_policy',
        'status'      => 'status',
    ];

    public function validate()
    {
        Model::validateField($this->description, 'maxLength', 1024);
        Model::validateField($this->shareId, 'required', true);
    }

    public function toMap()
    {
        $res                = [];
        $res['description'] = $this->description;
        $res['expiration']  = $this->expiration;
        $res['permissions'] = [];
        if (null !== $this->permissions) {
            $res['permissions'] = $this->permissions;
        }
        $res['share_id']     = $this->shareId;
        $res['share_name']   = $this->shareName;
        $res['share_policy'] = [];
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
     * @return UpdateShareRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['expiration'])) {
            $model->expiration = $map['expiration'];
        }
        if (isset($map['permissions'])) {
            if (!empty($map['permissions'])) {
                $model->permissions = [];
                $model->permissions = $map['permissions'];
            }
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

        return $model;
    }
}
