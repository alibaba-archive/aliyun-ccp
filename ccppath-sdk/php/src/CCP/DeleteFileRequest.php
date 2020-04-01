<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 删除文件请求
 */
class DeleteFileRequest extends Model
{
    public $driveId;
    public $fileId;
    public $filePath;
    public $permanently;
    public $shareId;
    protected $_required = [
        'driveId' => true,
        'fileId'  => true,
    ];
    protected $_name = [
        'driveId'     => 'drive_id',
        'fileId'      => 'file_id',
        'filePath'    => 'file_path',
        'permanently' => 'permanently',
        'shareId'     => 'share_id',
    ];
    protected $_description = [
        'driveId' => 'drive_id',
        'fileId'  => 'file_id',
    ];
    protected $_example = [
        'driveId' => '1',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
        'fileId'  => '[a-z0-9.-_]{1,50}',
    ];
    protected $_maxLength = [
        'fileId' => 50,
    ];
    protected $_minLength = [
        'fileId' => 40,
    ];
}
