<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * 获取签名 response
 */
class CCPListUploadedPartResponse extends Model{
    protected $_name = [
        "fileId" => "file_id",
        "nextPartNumberMarker" => "next_part_number_marker",
        "uploadId" => "upload_id",
        "uploadedParts" => "uploaded_parts",
    ];
    protected $_description = [
        "fileId" => "file_id",
        "nextPartNumberMarker" => "next_part_number_marker",
        "uploadId" => "upload_id",
        "uploadedParts" => "uploaded_parts",
    ];
    protected $_example = [
        "fileId" => "5d5b846942cf94fa72324c14a4bda34e81da635d",
        "nextPartNumberMarker" => "4",
        "uploadId" => "F3C25CDFA5C74ECB8DE32672F6211FD4",
        "uploadedParts" => "",
    ];
    protected $_maxLength = [
        "fileId" => 50,
    ];
    protected $_minLength = [
        "fileId" => 40,
    ];
    protected $_pattern = [
        "fileId" => "[a-z0-9]{1, 50}",
    ];
    protected $_items = [
        "uploadedParts" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    public $fileId;
    public $nextPartNumberMarker;
    public $uploadId;
    public $uploadedParts;
}
