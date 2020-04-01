<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 批量删除文件 response
 */
class OSSDeleteFilesResponse extends Model{
    protected $_name = [
        "deletedFileIdList" => "deleted_file_id_list",
        "domainId" => "domain_id",
        "driveId" => "drive_id",
        "shareId" => "share_id",
    ];
    protected $_description = [
        "deletedFileIdList" => "deleted_file_id_list",
        "domainId" => "domain_id",
        "driveId" => "drive_id",
        "shareId" => "share_id",
    ];
    protected $_example = [
        "deletedFileIdList" => "",
        "domainId" => "test001",
        "driveId" => "1",
        "shareId" => "1",
    ];
    protected $_items = [
        "deletedFileIdList" => "{"type":"string"}",
    ];
    protected $_pattern = [
        "domainId" => "[a-z0-9A-Z]+",
        "driveId" => "[0-9]+",
        "shareId" => "[0-9]+",
    ];
    public $deletedFileIdList;
    public $domainId;
    public $driveId;
    public $shareId;
}
