<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 更新文件元数据
 */
class UpdateFileMetaRequest extends Model{
    protected $_name = [
        "description" => "description",
        "driveId" => "drive_id",
        "fileId" => "file_id",
        "hidden" => "hidden",
        "meta" => "meta",
        "name" => "name",
        "shareId" => "share_id",
        "starred" => "starred",
        "tags" => "tags",
    ];
    protected $_description = [
        "description" => "description
type: string",
        "driveId" => "drive_id",
        "fileId" => "file_id",
        "hidden" => "hidden
type: boolean",
        "meta" => "meta",
        "name" => "name",
        "starred" => "starred
type: boolean",
        "tags" => "tags",
    ];
    protected $_maxLength = [
        "description" => 1000,
        "fileId" => 50,
    ];
    protected $_required = [
        "driveId" => true,
        "fileId" => true,
        "name" => true,
    ];
    protected $_example = [
        "driveId" => "1",
        "name" => "ccp.jpg",
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
        "fileId" => "[a-z0-9.-_]{1,50}",
        "name" => "[a-zA-Z0-9.-]{1,1000}",
    ];
    protected $_minLength = [
        "fileId" => 40,
    ];
    protected $_default = [
        "hidden" => "false",
        "starred" => "false",
    ];
    protected $_additionalProperties = [
        "tags" => "{"type":"object"}",
    ];
    public $description;
    public $driveId;
    public $fileId;
    public $hidden;
    public $meta;
    public $name;
    public $shareId;
    public $starred;
    public $tags;
}
