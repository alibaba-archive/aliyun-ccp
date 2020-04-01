<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 批量删除文件请求
 */
class CCPDeleteFilesRequest extends Model{
    protected $_required = [
        "driveId" => true,
        "fileIdList" => true,
    ];
    protected $_name = [
        "driveId" => "drive_id",
        "fileIdList" => "file_id_list",
    ];
    protected $_description = [
        "driveId" => "drive_id",
        "fileIdList" => "file_id_list",
    ];
    protected $_example = [
        "driveId" => "1",
        "fileIdList" => "",
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
    ];
    protected $_items = [
        "fileIdList" => "{"type":"string"}",
    ];
    protected $_maxItems = [
        "fileIdList" => 100,
    ];
    public $driveId;
    public $fileIdList;
}
