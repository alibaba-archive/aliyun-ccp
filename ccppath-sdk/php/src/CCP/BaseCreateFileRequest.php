<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * create file request
 */
class BaseCreateFileRequest extends Model{
    protected $_required = [
        "contentMd5" => true,
        "contentType" => true,
        "name" => true,
        "size" => true,
        "type" => true,
    ];
    protected $_name = [
        "contentMd5" => "content_md5",
        "contentType" => "content_type",
        "name" => "name",
        "partInfoList" => "part_info_list",
        "size" => "size",
        "type" => "type",
    ];
    protected $_description = [
        "contentMd5" => "ContentMd5",
        "contentType" => "ContentType",
        "name" => "Name",
        "partInfoList" => "part_info_list",
        "size" => "Size",
        "type" => "Type",
    ];
    protected $_example = [
        "contentMd5" => "E10ADC3949BA59ABBE56E057F20F883E",
        "contentType" => "application/json",
        "name" => "ccp.jpg",
        "type" => "file",
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
    public $contentMd5;
    public $contentType;
    public $name;
    public $partInfoList;
    public $size;
    public $type;
}
