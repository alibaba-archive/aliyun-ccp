<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 文件移动请求
 */
class OSSMoveFileRequest extends Model
{
    public $driveId;
    public $filePath;
    public $newName;
    public $overwrite;
    public $shareId;
    public $toParentFilePath;
    protected $_required = [
        'driveId' => true,
        'newName' => true,
    ];
    protected $_name = [
        'driveId'          => 'drive_id',
        'filePath'         => 'file_path',
        'newName'          => 'new_name',
        'overwrite'        => 'overwrite',
        'shareId'          => 'share_id',
        'toParentFilePath' => 'to_parent_file_path',
    ];
    protected $_description = [
        'driveId'   => 'drive_id',
        'filePath'  => 'file_path',
        'newName'   => 'new_name',
        'overwrite' => 'overwrite
type: boolean',
        'shareId'          => 'share_id',
        'toParentFilePath' => 'file_path',
    ];
    protected $_example = [
        'driveId'          => '1',
        'filePath'         => '/a/b/c.jpg',
        'newName'          => 'ccp.jpg',
        'shareId'          => '3d336314-63c8-4d96-bce0-17aefb6833b6',
        'toParentFilePath' => '/a/b/c/',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
        'shareId' => '[0-9a-zA-z-]+',
    ];
    protected $_default = [
        'overwrite' => 'false',
    ];
}
