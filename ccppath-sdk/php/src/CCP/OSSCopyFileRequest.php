<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * copy file request.
 */
class OSSCopyFileRequest extends Model
{
    public $driveId;
    public $filePath;
    public $newName;
    public $overwrite;
    public $shareId;
    public $toDriveId;
    public $toParentFilePath;
    public $toShareId;
    protected $_name = [
        'driveId'          => 'drive_id',
        'filePath'         => 'file_path',
        'newName'          => 'new_name',
        'overwrite'        => 'overwrite',
        'shareId'          => 'share_id',
        'toDriveId'        => 'to_drive_id',
        'toParentFilePath' => 'to_parent_file_path',
        'toShareId'        => 'to_share_id',
    ];
    protected $_description = [
        'driveId'   => 'drive_id',
        'filePath'  => 'file_path',
        'newName'   => 'new_name',
        'overwrite' => 'overwrite
type: boolean',
        'shareId'          => 'share_id',
        'toDriveId'        => 'to_drive_id',
        'toParentFilePath' => 'to_parent_file_path',
        'toShareId'        => 'share_id',
    ];
    protected $_example = [
        'driveId'          => '1',
        'filePath'         => '/a/b/c.jpg',
        'newName'          => 'ccp.jpg',
        'shareId'          => '3d336314-63c8-4d96-bce0-17aefb6833b6',
        'toDriveId'        => '1',
        'toParentFilePath' => '/a/b/c/',
        'toShareId'        => '3d336314-63c8-4d96-bce0-17aefb6833b6',
    ];
    protected $_pattern = [
        'driveId'   => '[0-9]+',
        'newName'   => '[a-zA-Z0-9.-]{1,1000}',
        'shareId'   => '[0-9a-zA-z-]+',
        'toDriveId' => '[0-9]+',
    ];
    protected $_default = [
        'overwrite' => 'false',
    ];
    protected $_required = [
        'toDriveId'        => true,
        'toParentFilePath' => true,
    ];
}
