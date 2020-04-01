<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * 获取文件上传URL
 */
class GetUploadUrlRequest extends Model{
    protected $_name = [
        "contentMd5" => "content_md5",
        "driveId" => "drive_id",
        "fileId" => "file_id",
        "filePath" => "file_path",
        "partInfoList" => "part_info_list",
        "shareId" => "share_id",
        "uploadId" => "upload_id",
    ];
    protected $_description = [
        "contentMd5" => "content_md5",
        "driveId" => "drive_id",
        "fileId" => "file_id",
        "partInfoList" => "upload_part_list",
        "uploadId" => "upload_id",
    ];
    protected $_maxLength = [
        "contentMd5" => 32,
        "fileId" => 50,
    ];
    protected $_required = [
        "driveId" => true,
        "fileId" => true,
        "uploadId" => true,
    ];
    protected $_example = [
        "driveId" => "1",
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
        "fileId" => "[a-z0-9]{1,50}",
    ];
    protected $_minLength = [
        "fileId" => 40,
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    public $contentMd5;
    public $driveId;
    public $fileId;
    public $filePath;
    public $partInfoList;
    public $shareId;
    public $uploadId;
}
