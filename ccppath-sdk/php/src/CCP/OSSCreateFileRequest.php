<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * create file request
 */
class OSSCreateFileRequest extends Model{
    protected $_name = [
        "contentMd5" => "content_md5",
        "contentType" => "content_type",
        "name" => "name",
        "partInfoList" => "part_info_list",
        "size" => "size",
        "type" => "type",
        "driveId" => "drive_id",
        "parentFilePath" => "parent_file_path",
        "shareId" => "share_id",
    ];
    protected $_description = [
        "contentMd5" => "ContentMd5",
        "contentType" => "ContentType",
        "name" => "Name",
        "partInfoList" => "part_info_list",
        "size" => "Size",
        "type" => "Type",
        "driveId" => "drive_id",
        "parentFilePath" => "parent_file_path",
        "shareId" => "share_id",
    ];
    protected $_example = [
        "contentMd5" => "E10ADC3949BA59ABBE56E057F20F883E",
        "contentType" => "application/json",
        "name" => "ccp.jpg",
        "type" => "file",
        "driveId" => "1",
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
    ];
    protected $_format = [
        "size" => "int64",
    ];
    protected $_enum = [
        "type" => "file, folder",
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
    ];
    protected $_maxLength = [
        "shareId" => 40,
    ];
    protected $_minLength = [
        "shareId" => 50,
    ];
    public $contentMd5;
    public $contentType;
    public $name;
    public $partInfoList;
    public $size;
    public $type;
    public $driveId;
    public $parentFilePath;
    public $shareId;
}
