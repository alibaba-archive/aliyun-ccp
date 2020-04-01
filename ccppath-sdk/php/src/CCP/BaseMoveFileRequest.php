<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 文件移动请求
 */
class BaseMoveFileRequest extends Model
{
    public $driveId;
    public $newName;
    public $overwrite;
    protected $_required = [
        'driveId' => true,
    ];
    protected $_name = [
        'driveId'   => 'drive_id',
        'newName'   => 'new_name',
        'overwrite' => 'overwrite',
    ];
    protected $_description = [
        'driveId'   => 'drive_id',
        'newName'   => 'new_name',
        'overwrite' => 'overwrite
type: boolean',
    ];
    protected $_example = [
        'driveId'   => '1',
        'newName'   => 'ccp.jpg',
        'overwrite' => 'false',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
        'newName' => '.{1,1000}',
    ];
    protected $_default = [
        'overwrite' => 'false',
    ];
}
