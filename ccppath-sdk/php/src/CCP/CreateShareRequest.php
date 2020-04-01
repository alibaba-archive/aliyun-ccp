<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\SharePermissionPolicy;

/**
 * create share request
 */
class CreateShareRequest extends Model{
    protected $_name = [
        "description" => "description",
        "driveId" => "drive_id",
        "expiration" => "expiration",
        "owner" => "owner",
        "permissions" => "permissions",
        "shareFilePath" => "share_file_path",
        "shareName" => "share_name",
        "sharePolicy" => "share_policy",
        "status" => "status",
    ];
    protected $_description = [
        "description" => "description",
        "driveId" => "drive_id",
        "expiration" => "expiration",
        "owner" => "creator",
        "permissions" => "permissions",
        "shareFilePath" => "share_file_path",
        "shareName" => "share_name",
        "sharePolicy" => "share create policy

share_policy",
        "status" => "status",
    ];
    protected $_example = [
        "description" => "share description",
        "driveId" => "1",
        "expiration" => "2006-01-02T15:04:05.999Z",
        "owner" => "abc",
        "permissions" => "",
        "shareName" => "share",
        "status" => "enabled",
    ];
    protected $_required = [
        "driveId" => true,
        "owner" => true,
        "shareFilePath" => true,
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
    ];
    protected $_items = [
        "permissions" => "{"type":"string"}",
        "sharePolicy" => "{"$ref":"#/definitions/SharePermissionPolicy"}",
    ];
    protected $_enum = [
        "status" => "enabled, disabled",
    ];
    public $description;
    public $driveId;
    public $expiration;
    public $owner;
    public $permissions;
    public $shareFilePath;
    public $shareName;
    public $sharePolicy;
    public $status;
}
