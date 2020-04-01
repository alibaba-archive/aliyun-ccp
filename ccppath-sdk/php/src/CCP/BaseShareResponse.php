<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * List share response
 */
class BaseShareResponse extends Model{
    protected $_name = [
        "createdAt" => "created_at",
        "creator" => "creator",
        "description" => "description",
        "domainId" => "domain_id",
        "driveId" => "drive_id",
        "expiration" => "expiration",
        "expired" => "expired",
        "owner" => "owner",
        "permissions" => "permissions",
        "shareFilePath" => "share_file_path",
        "shareId" => "share_id",
        "shareName" => "share_name",
        "status" => "status",
        "updatedAt" => "updated_at",
    ];
    protected $_description = [
        "createdAt" => "created_at",
        "creator" => "creator",
        "description" => "description",
        "domainId" => "domain_id",
        "driveId" => "drive_id",
        "expiration" => "expiration",
        "expired" => "expired",
        "owner" => "owner",
        "permissions" => "permissions",
        "shareFilePath" => "share_path",
        "shareId" => "share_id",
        "shareName" => "share_name",
        "status" => "status",
        "updatedAt" => "updated_at",
    ];
    protected $_example = [
        "createdAt" => "2006-01-02T15:04:05.999Z",
        "creator" => "xxx",
        "description" => "share description",
        "domainId" => "domain-1",
        "driveId" => "1",
        "expiration" => "2006-01-02T15:04:05.999Z",
        "expired" => "false",
        "owner" => "xxx",
        "permissions" => "",
        "shareFilePath" => "/a/b/c/",
        "shareId" => "3d336314-63c8-4d96-bce0-17aefb6833b6",
        "shareName" => "new_share",
        "status" => "enabled",
        "updatedAt" => "2006-01-02T15:04:05.999Z",
    ];
    protected $_items = [
        "permissions" => "{"type":"string"}",
    ];
    public $createdAt;
    public $creator;
    public $description;
    public $domainId;
    public $driveId;
    public $expiration;
    public $expired;
    public $owner;
    public $permissions;
    public $shareFilePath;
    public $shareId;
    public $shareName;
    public $status;
    public $updatedAt;
}
