<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * 创建文件
 */
class CCPCreateFileRequest extends Model{
    protected $_name = [
        "contentMd5" => "content_md5",
        "contentType" => "content_type",
        "name" => "name",
        "partInfoList" => "part_info_list",
        "size" => "size",
        "type" => "type",
        "autoRename" => "auto_rename",
        "contentHash" => "content_hash",
        "contentHashName" => "content_hash_name",
        "description" => "description",
        "driveId" => "drive_id",
        "encryptMode" => "encrypt_mode",
        "fileId" => "file_id",
        "hidden" => "hidden",
        "labels" => "labels",
        "meta" => "meta",
        "parentFileId" => "parent_file_id",
        "preHash" => "pre_hash",
    ];
    protected $_description = [
        "contentMd5" => "ContentMd5",
        "contentType" => "ContentType",
        "name" => "Name",
        "partInfoList" => "part_info_list",
        "size" => "Size",
        "type" => "Type",
        "autoRename" => "auto_rename",
        "contentHash" => "content_hash",
        "contentHashName" => "content_hash_name",
        "description" => "description",
        "driveId" => "drive_id",
        "encryptMode" => "encrypt_mode",
        "fileId" => "file_id",
        "hidden" => "hidden",
        "labels" => "labels",
        "meta" => "meta",
        "parentFileId" => "parent_file_id",
        "preHash" => "pre_hash",
    ];
    protected $_example = [
        "contentMd5" => "E10ADC3949BA59ABBE56E057F20F883E",
        "contentType" => "application/json",
        "name" => "ccp.jpg",
        "type" => "file",
        "contentHash" => "7C4A8D09CA3762AF61E59520943DC26494F8941B",
        "contentHashName" => "sha1",
        "description" => "file description",
        "driveId" => "1",
        "hidden" => "false",
        "labels" => "label1, label2",
        "meta" => "meta test",
        "parentFileId" => "root",
        "preHash" => "E10ADC3949BA59ABBE56E057F20F883E",
    ];
    protected $_maximum = [
        "name" => 1024,
        "size" => 53687091200,
    ];
    protected $_minimum = [
        "name" => 1,
        "size" => 0,
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
        "labels" => "{"type":"string"}",
    ];
    protected $_format = [
        "size" => "int64",
    ];
    protected $_enum = [
        "type" => "file, folder",
        "autoRename" => "false, true",
        "contentHashName" => "sha1",
        "hidden" => "true, false",
    ];
    protected $_default = [
        "autoRename" => "false",
    ];
    protected $_maxLength = [
        "description" => 0,
        "parentFileId" => 50,
    ];
    protected $_minLength = [
        "description" => 1024,
        "parentFileId" => 40,
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
        "parentFileId" => "[a-z0-9]{1,50}",
    ];
    public $contentMd5;
    public $contentType;
    public $name;
    public $partInfoList;
    public $size;
    public $type;
    public $autoRename;
    public $contentHash;
    public $contentHashName;
    public $description;
    public $driveId;
    public $encryptMode;
    public $fileId;
    public $hidden;
    public $labels;
    public $meta;
    public $parentFileId;
    public $preHash;
}
