<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\SharePermissionPolicy;

/**
 * update share request
 */
class UpdateShareRequest extends Model{
    protected $_name = [
        "description" => "description",
        "expiration" => "expiration",
        "permissions" => "permissions",
        "shareId" => "share_id",
        "shareName" => "share_name",
        "sharePolicy" => "share_policy",
        "status" => "status",
    ];
    protected $_description = [
        "description" => "description",
        "expiration" => "expiration",
        "permissions" => "permissions",
        "shareId" => "share_id",
        "shareName" => "share_name",
        "sharePolicy" => "share_policy",
        "status" => "status",
    ];
    protected $_example = [
        "description" => "share description",
        "expiration" => "2006-01-02T15:04:05.999Z",
        "permissions" => "",
        "shareId" => "3d336314-63c8-4d96-bce0-17aefb6833b6",
        "shareName" => "new_share_name",
        "status" => "enabled",
    ];
    protected $_maxLength = [
        "description" => 1024,
    ];
    protected $_items = [
        "permissions" => "{"type":"string"}",
        "sharePolicy" => "{"$ref":"#/definitions/SharePermissionPolicy"}",
    ];
    protected $_required = [
        "shareId" => true,
    ];
    protected $_enum = [
        "status" => "enabled, disabled",
    ];
    public $description;
    public $expiration;
    public $permissions;
    public $shareId;
    public $shareName;
    public $sharePolicy;
    public $status;
}
