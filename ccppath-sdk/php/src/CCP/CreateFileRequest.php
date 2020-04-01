<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * create file request
 */
class CreateFileRequest extends Model{
    protected $_name = [
        "contentHash" => "content_hash",
        "contentHashName" => "content_hash_name",
        "contentMd5" => "content_md5",
        "contentType" => "content_type",
        "description" => "description",
        "driveId" => "drive_id",
        "hidden" => "hidden",
        "meta" => "meta",
        "name" => "name",
        "parentFileId" => "parent_file_id",
        "parentFilePath" => "parent_file_path",
        "partInfoList" => "part_info_list",
        "preHash" => "pre_hash",
        "shareId" => "share_id",
        "size" => "size",
        "tags" => "tags",
        "type" => "type",
    ];
    protected $_description = [
        "contentHash" => "ContentHash",
        "contentHashName" => "ContentHashName",
        "contentMd5" => "ContentMd5",
        "contentType" => "ContentType",
        "description" => "Description",
        "driveId" => "DriveID",
        "hidden" => "Hidden",
        "meta" => "Meta",
        "name" => "name",
        "parentFileId" => "parent_file_id",
        "parentFilePath" => "ParentFilePath",
        "partInfoList" => "part_info_list",
        "preHash" => "pre_hash",
        "shareId" => "ShareID",
        "size" => "Size",
        "tags" => "tags",
        "type" => "Type",
    ];
    protected $_enum = [
        "contentHashName" => "sha1",
        "hidden" => "true, false",
        "type" => "file, folder",
    ];
    protected $_example = [
        "contentHashName" => "sha1",
        "driveId" => "1",
        "name" => "ccp.jpg",
    ];
    protected $_maxLength = [
        "contentMd5" => 32,
        "description" => 0,
        "parentFileId" => 50,
    ];
    protected $_required = [
        "contentType" => true,
        "driveId" => true,
        "name" => true,
        "parentFileId" => true,
        "size" => true,
        "type" => true,
    ];
    protected $_minLength = [
        "description" => 1024,
        "parentFileId" => 40,
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
        "parentFileId" => "[a-z0-9]{1,50}",
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    protected $_format = [
        "size" => "int64",
    ];
    protected $_maximum = [
        "size" => 53687091200,
    ];
    protected $_minimum = [
        "size" => 0,
    ];
    protected $_additionalProperties = [
        "tags" => "{"type":"object"}",
    ];
    public $contentHash;
    public $contentHashName;
    public $contentMd5;
    public $contentType;
    public $description;
    public $driveId;
    public $hidden;
    public $meta;
    public $name;
    public $parentFileId;
    public $parentFilePath;
    public $partInfoList;
    public $preHash;
    public $shareId;
    public $size;
    public $tags;
    public $type;
}
