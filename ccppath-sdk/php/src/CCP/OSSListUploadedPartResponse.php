<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * 获取签名 response
 */
class OSSListUploadedPartResponse extends Model{
    protected $_name = [
        "filePath" => "file_path",
        "nextPartNumberMarker" => "next_part_number_marker",
        "uploadId" => "upload_id",
        "uploadedParts" => "uploaded_parts",
    ];
    protected $_description = [
        "filePath" => "file_path",
        "nextPartNumberMarker" => "next_part_number_marker",
        "uploadId" => "upload_id",
        "uploadedParts" => "uploaded_parts",
    ];
    protected $_example = [
        "filePath" => "/a/b/c.jpg",
        "nextPartNumberMarker" => "4",
        "uploadId" => "F3C25CDFA5C74ECB8DE32672F6211FD4",
        "uploadedParts" => "",
    ];
    protected $_items = [
        "uploadedParts" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    public $filePath;
    public $nextPartNumberMarker;
    public $uploadId;
    public $uploadedParts;
}
