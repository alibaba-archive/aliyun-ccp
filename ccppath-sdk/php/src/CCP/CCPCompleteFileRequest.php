<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * 合并文件上传任务
 */
class CCPCompleteFileRequest extends Model{
    protected $_name = [
        "driveId" => "drive_id",
        "partInfoList" => "part_info_list",
        "uploadId" => "upload_id",
        "fileId" => "file_id",
    ];
    protected $_description = [
        "driveId" => "drive_id",
        "partInfoList" => "part_info_list",
        "uploadId" => "upload_id",
        "fileId" => "file_id",
    ];
    protected $_example = [
        "driveId" => "1",
        "fileId" => "5d5b846942cf94fa72324c14a4bda34e81da635d",
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
        "fileId" => "[a-z0-9]{1,50}",
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    protected $_maxLength = [
        "fileId" => 50,
    ];
    protected $_minLength = [
        "fileId" => 40,
    ];
    public $driveId;
    public $partInfoList;
    public $uploadId;
    public $fileId;
}
