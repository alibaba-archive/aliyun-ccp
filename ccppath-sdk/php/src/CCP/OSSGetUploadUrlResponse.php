<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * Get UploadUrl Response
 */
class OSSGetUploadUrlResponse extends Model{
    protected $_name = [
        "createAt" => "create_at",
        "domainId" => "domain_id",
        "driveId" => "drive_id",
        "filePath" => "file_path",
        "partInfoList" => "part_info_list",
        "uploadId" => "upload_id",
    ];
    protected $_description = [
        "createAt" => "created_at",
        "domainId" => "domain_id",
        "driveId" => "drive_id",
        "filePath" => "file_path",
        "partInfoList" => "part_info_list",
        "uploadId" => "upload_id",
    ];
    protected $_example = [
        "createAt" => "2019-09-11T16:34:36.977Z",
        "domainId" => "test001",
        "driveId" => "1",
        "filePath" => "/a/b/c.jpg",
        "partInfoList" => "",
        "uploadId" => "F3C25CDFA5C74ECB8DE32672F6211FD4",
    ];
    protected $_pattern = [
        "domainId" => "[a-z0-9A-Z]+",
        "driveId" => "[0-9]+",
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    public $createAt;
    public $domainId;
    public $driveId;
    public $filePath;
    public $partInfoList;
    public $uploadId;
}
