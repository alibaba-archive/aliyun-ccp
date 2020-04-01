<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * Create file response
 */
class OSSCreateFileResponse extends Model{
    protected $_name = [
        "domainId" => "domain_id",
        "driveId" => "drive_id",
        "filePath" => "file_path",
        "partInfoList" => "part_info_list",
        "shareId" => "share_id",
        "type" => "type",
        "uploadId" => "upload_id",
    ];
    protected $_description = [
        "domainId" => "domain_id",
        "driveId" => "drive_id",
        "filePath" => "file_path",
        "partInfoList" => "part_info_list",
        "shareId" => "share_id",
        "type" => "type",
        "uploadId" => "upload_id",
    ];
    protected $_example = [
        "domainId" => "domain",
        "driveId" => "1",
        "filePath" => "/a/b/c.jpg",
        "partInfoList" => "[",
        "shareId" => "1",
        "type" => "file",
        "uploadId" => "C9DCFE5A82644AC7A02DB74C30C934A6",
    ];
    protected $_maxLength = [
        "domainId" => 50,
    ];
    protected $_minLength = [
        "domainId" => 40,
    ];
    protected $_pattern = [
        "domainId" => "[a-z0-9]{1, 50}",
        "driveId" => "[0-9]+",
        "shareId" => "[0-9]+",
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    protected $_enum = [
        "type" => "file, folder",
    ];
    public $domainId;
    public $driveId;
    public $filePath;
    public $partInfoList;
    public $shareId;
    public $type;
    public $uploadId;
}
