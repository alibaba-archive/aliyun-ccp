<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * complete file request
 */
class OSSCompleteFileRequest extends Model{
    protected $_name = [
        "driveId" => "drive_id",
        "partInfoList" => "part_info_list",
        "uploadId" => "upload_id",
        "filePath" => "file_path",
        "shareId" => "share_id",
    ];
    protected $_description = [
        "driveId" => "drive_id",
        "partInfoList" => "part_info_list",
        "uploadId" => "upload_id",
    ];
    protected $_example = [
        "driveId" => "1",
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    public $driveId;
    public $partInfoList;
    public $uploadId;
    public $filePath;
    public $shareId;
}
