<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 文件移动请求
 */
class CopyFileRequest extends Model
{
    public $driveId;
    public $fileId;
    public $filePath;
    public $newName;
    public $overwrite;
    public $shareId;
    public $toParentFileId;
    public $toParentFilePath;
    protected $_required = [
        'driveId'        => true,
        'fileId'         => true,
        'newName'        => true,
        'toParentFileId' => true,
    ];
    protected $_name = [
        'driveId'          => 'drive_id',
        'fileId'           => 'file_id',
        'filePath'         => 'file_path',
        'newName'          => 'new_name',
        'overwrite'        => 'overwrite',
        'shareId'          => 'share_id',
        'toParentFileId'   => 'to_parent_file_id',
        'toParentFilePath' => 'to_parent_file_path',
    ];
    protected $_description = [
        'driveId'   => 'drive_id',
        'fileId'    => 'file_id',
        'newName'   => 'new_name',
        'overwrite' => 'overwrite
type: boolean',
        'toParentFileId' => 'to_parent_file_id',
    ];
    protected $_example = [
        'driveId' => '1',
        'newName' => 'ccp.jpg',
    ];
    protected $_pattern = [
        'driveId'        => '[0-9]+',
        'fileId'         => '[a-z0-9.-_]{1,50}',
        'newName'        => '[a-zA-Z0-9.-]{1,1000}',
        'toParentFileId' => '[a-z0-9.-_]{1,50}',
    ];
    protected $_maxLength = [
        'fileId'         => 50,
        'toParentFileId' => 50,
    ];
    protected $_minLength = [
        'fileId'         => 40,
        'toParentFileId' => 40,
    ];
    protected $_default = [
        'overwrite' => 'false',
    ];
}
