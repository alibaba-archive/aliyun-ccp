<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class SharePermissionPolicy extends Model
{
    /**
     * @var string
     */
    public $filePath;

    /**
     * @var bool
     */
    public $permissionInheritable;

    /**
     * @var array
     */
    public $permissionList;

    /**
     * @var string
     */
    public $permissionType;
    protected $_name = [
        'filePath'              => 'file_path',
        'permissionInheritable' => 'permission_inheritable',
        'permissionList'        => 'permission_list',
        'permissionType'        => 'permission_type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                           = [];
        $res['file_path']              = $this->filePath;
        $res['permission_inheritable'] = $this->permissionInheritable;
        $res['permission_list']        = [];
        if (null !== $this->permissionList) {
            $res['permission_list'] = $this->permissionList;
        }
        $res['permission_type'] = $this->permissionType;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SharePermissionPolicy
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['file_path'])) {
            $model->filePath = $map['file_path'];
        }
        if (isset($map['permission_inheritable'])) {
            $model->permissionInheritable = $map['permission_inheritable'];
        }
        if (isset($map['permission_list'])) {
            if (!empty($map['permission_list'])) {
                $model->permissionList = [];
                $model->permissionList = $map['permission_list'];
            }
        }
        if (isset($map['permission_type'])) {
            $model->permissionType = $map['permission_type'];
        }

        return $model;
    }
}
