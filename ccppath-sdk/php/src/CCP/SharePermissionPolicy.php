<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * *
 */
class SharePermissionPolicy extends Model{
    protected $_name = [
        "filePath" => "file_path",
        "permissionInheritable" => "permission_inheritable",
        "permissionList" => "permission_list",
        "permissionType" => "permission_type",
    ];
    protected $_items = [
        "permissionList" => "{"type":"string"}",
    ];
    public $filePath;
    public $permissionInheritable;
    public $permissionList;
    public $permissionType;
}
