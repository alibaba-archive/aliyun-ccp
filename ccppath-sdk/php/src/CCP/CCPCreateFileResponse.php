<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\UploadPartInfo;

/**
 * Create file response
 */
class CCPCreateFileResponse extends Model{
    protected $_name = [
        "domainId" => "domain_id",
        "driveId" => "drive_id",
        "fileId" => "file_id",
        "parentFileId" => "parent_file_id",
        "partInfoList" => "part_info_list",
        "rapidUpload" => "rapid_upload",
        "type" => "type",
        "uploadId" => "upload_id",
    ];
    protected $_description = [
        "domainId" => "domain_id",
        "driveId" => "drive_id",
        "fileId" => "file_id",
        "parentFileId" => "parent_file_id",
        "partInfoList" => "part_info_list",
        "rapidUpload" => "rapid_upload
type: boolean",
        "type" => "type",
        "uploadId" => "upload_id",
    ];
    protected $_example = [
        "domainId" => "domain",
        "driveId" => "1",
        "fileId" => "5d79206586bb5dd69fb34c349282718146c55da7",
        "parentFileId" => "root",
        "partInfoList" => "[",
        "rapidUpload" => "false",
        "type" => "file",
        "uploadId" => "C9DCFE5A82644AC7A02DB74C30C934A6",
    ];
    protected $_maxLength = [
        "domainId" => 50,
        "fileId" => 50,
        "parentFileId" => 50,
    ];
    protected $_minLength = [
        "domainId" => 40,
        "fileId" => 40,
        "parentFileId" => 40,
    ];
    protected $_pattern = [
        "domainId" => "[a-z0-9]{1, 50}",
        "driveId" => "[0-9]+",
        "fileId" => "[a-z0-9]{1, 50}",
        "parentFileId" => "[a-z0-9]{1, 50}",
    ];
    protected $_items = [
        "partInfoList" => "{"$ref":"#/definitions/UploadPartInfo"}",
    ];
    protected $_enum = [
        "type" => "file, folder",
    ];
    public $domainId;
    public $driveId;
    public $fileId;
    public $parentFileId;
    public $partInfoList;
    public $rapidUpload;
    public $type;
    public $uploadId;
}
