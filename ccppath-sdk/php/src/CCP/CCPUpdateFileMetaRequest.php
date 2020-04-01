<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 更新文件元数据
 */
class CCPUpdateFileMetaRequest extends Model{
    protected $_name = [
        "customIndexKey" => "custom_index_key",
        "description" => "description",
        "driveId" => "drive_id",
        "encryptMode" => "encrypt_mode",
        "fileId" => "file_id",
        "hidden" => "hidden",
        "labels" => "labels",
        "meta" => "meta",
        "name" => "name",
        "starred" => "starred",
    ];
    protected $_description = [
        "description" => "description
type: string",
        "driveId" => "drive_id",
        "fileId" => "file_id",
        "hidden" => "hidden
type: boolean",
        "labels" => "labels",
        "meta" => "meta",
        "name" => "name",
        "starred" => "starred
type: boolean",
    ];
    protected $_example = [
        "description" => "description",
        "driveId" => "1",
        "fileId" => "5d5b846942cf94fa72324c14a4bda34e81da635d",
        "hidden" => "false",
        "labels" => "label1, label2",
        "meta" => "meta test",
        "name" => "ccp.jpg",
        "starred" => "false",
    ];
    protected $_maxLength = [
        "description" => 1024,
        "fileId" => 50,
    ];
    protected $_required = [
        "driveId" => true,
        "fileId" => true,
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
        "fileId" => "[a-z0-9.-_]{1,50}",
        "name" => ".{1,1000}",
    ];
    protected $_minLength = [
        "fileId" => 40,
    ];
    protected $_default = [
        "hidden" => "false",
        "starred" => "false",
    ];
    protected $_items = [
        "labels" => "{"type":"string"}",
    ];
    public $customIndexKey;
    public $description;
    public $driveId;
    public $encryptMode;
    public $fileId;
    public $hidden;
    public $labels;
    public $meta;
    public $name;
    public $starred;
}
