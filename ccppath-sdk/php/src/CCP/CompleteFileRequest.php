<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * complete file request
 */
class CompleteFileRequest extends Model{
    protected $_required = [
        "driveId" => true,
        "fileId" => true,
        "uploadId" => true,
    ];
    protected $_name = [
        "driveId" => "drive_id",
        "fileId" => "file_id",
        "filePath" => "file_path",
        "partInfoList" => "part_info_list",
        "shareId" => "share_id",
        "uploadId" => "upload_id",
    ];
    protected $_description = [
        "driveId" => "drive_id",
        "fileId" => "file_id",
        "partInfoList" => "part_info_list",
        "uploadId" => "upload_id",
    ];
    protected $_example = [
        "driveId" => "1",
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
        "fileId" => "[a-z0-9]{1,50}",
    ];
    protected $_maxLength = [
        "fileId" => 50,
    ];
    protected $_minLength = [
        "fileId" => 40,
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    public $driveId;
    public $fileId;
    public $filePath;
    public $partInfoList;
    public $shareId;
    public $uploadId;
}
