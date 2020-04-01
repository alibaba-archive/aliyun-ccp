<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * 获取文件上传URL
 */
class CCPGetUploadUrlRequest extends Model{
    protected $_name = [
        "contentMd5" => "content_md5",
        "driveId" => "drive_id",
        "partInfoList" => "part_info_list",
        "uploadId" => "upload_id",
        "fileId" => "file_id",
    ];
    protected $_description = [
        "contentMd5" => "content_md5",
        "driveId" => "drive_id",
        "partInfoList" => "upload_part_list",
        "uploadId" => "upload_id",
        "fileId" => "file_id",
    ];
    protected $_example = [
        "contentMd5" => "E10ADC3949BA59ABBE56E057F20F883E",
        "driveId" => "1",
        "partInfoList" => "",
        "uploadId" => "3920F2BE4D9446D6967E2ED505A97EFD",
        "fileId" => "5d5b846942cf94fa72324c14a4bda34e81da635d",
    ];
    protected $_maxLength = [
        "contentMd5" => 32,
        "fileId" => 50,
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
        "fileId" => "[a-z0-9]{1,50}",
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    protected $_minLength = [
        "fileId" => 40,
    ];
    public $contentMd5;
    public $driveId;
    public $partInfoList;
    public $uploadId;
    public $fileId;
}
