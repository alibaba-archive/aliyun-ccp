<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 文件移动请求
 */
class CCPMoveFileRequest extends Model
{
    public $driveId;
    public $newName;
    public $overwrite;
    public $fileId;
    public $toParentFileId;
    protected $_name = [
        'driveId'        => 'drive_id',
        'newName'        => 'new_name',
        'overwrite'      => 'overwrite',
        'fileId'         => 'file_id',
        'toParentFileId' => 'to_parent_file_id',
    ];
    protected $_description = [
        'driveId'   => 'drive_id',
        'newName'   => 'new_name',
        'overwrite' => 'overwrite
type: boolean',
        'fileId'         => 'file_id',
        'toParentFileId' => 'to_parent_file_id',
    ];
    protected $_example = [
        'driveId'        => '1',
        'newName'        => 'ccp.jpg',
        'overwrite'      => 'false',
        'fileId'         => '5d5b846942cf94fa72324c14a4bda34e81da635d',
        'toParentFileId' => 'root',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
        'newName' => '.{1,1000}',
        'fileId'  => '[a-z0-9.-_]{1,50}',
    ];
    protected $_default = [
        'overwrite' => 'false',
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
