<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * 获取文件上传URL
 */
class OSSGetUploadUrlRequest extends Model{
    protected $_name = [
        "contentMd5" => "content_md5",
        "driveId" => "drive_id",
        "partInfoList" => "part_info_list",
        "uploadId" => "upload_id",
        "filePath" => "file_path",
        "shareId" => "share_id",
    ];
    protected $_description = [
        "contentMd5" => "content_md5",
        "driveId" => "drive_id",
        "partInfoList" => "upload_part_list",
        "uploadId" => "upload_id",
        "filePath" => "file_path",
        "shareId" => "share_id",
    ];
    protected $_example = [
        "contentMd5" => "E10ADC3949BA59ABBE56E057F20F883E",
        "driveId" => "1",
        "partInfoList" => "",
        "uploadId" => "3920F2BE4D9446D6967E2ED505A97EFD",
        "filePath" => "/a/b/c.jpg",
        "shareId" => "1",
    ];
    protected $_maxLength = [
        "contentMd5" => 32,
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
        "shareId" => "[0-9]+",
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    public $contentMd5;
    public $driveId;
    public $partInfoList;
    public $uploadId;
    public $filePath;
    public $shareId;
}
