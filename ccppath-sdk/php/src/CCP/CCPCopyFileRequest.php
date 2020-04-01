<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 文件拷贝.
 */
class CCPCopyFileRequest extends Model
{
    public $autoRename;
    public $driveId;
    public $fileId;
    public $newName;
    public $toDriveId;
    public $toParentFileId;
    protected $_name = [
        'autoRename'     => 'auto_rename',
        'driveId'        => 'drive_id',
        'fileId'         => 'file_id',
        'newName'        => 'new_name',
        'toDriveId'      => 'to_drive_id',
        'toParentFileId' => 'to_parent_file_id',
    ];
    protected $_default = [
        'autoRename' => 'false',
    ];
    protected $_description = [
        'autoRename' => 'auto_rename
type: boolean',
        'driveId'        => 'drive_id',
        'fileId'         => 'file_id',
        'newName'        => 'new_name',
        'toDriveId'      => 'to_drive_id',
        'toParentFileId' => 'to_parent_file_id',
    ];
    protected $_example = [
        'autoRename'     => 'false',
        'driveId'        => '1',
        'fileId'         => '5d5b846942cf94fa72324c14a4bda34e81da635d',
        'newName'        => 'ccp.jpg',
        'toDriveId'      => '1',
        'toParentFileId' => 'root',
    ];
    protected $_required = [
        'driveId'        => true,
        'fileId'         => true,
        'toParentFileId' => true,
    ];
    protected $_pattern = [
        'driveId'        => '[0-9]+',
        'fileId'         => '[a-z0-9.-_]{1,50}',
        'newName'        => '.{1,1000}',
        'toDriveId'      => '[0-9]+',
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
}
