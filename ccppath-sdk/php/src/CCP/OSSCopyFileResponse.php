<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 文件拷贝 response.
 */
class OSSCopyFileResponse extends Model
{
    public $asyncTaskId;
    public $domainId;
    public $driveId;
    public $filePath;
    public $shareId;
    protected $_name = [
        'asyncTaskId' => 'async_task_id',
        'domainId'    => 'domain_id',
        'driveId'     => 'drive_id',
        'filePath'    => 'file_path',
        'shareId'     => 'share_id',
    ];
    protected $_description = [
        'asyncTaskId' => 'async_task_id',
        'domainId'    => 'domain_id',
        'driveId'     => 'drive_id',
        'filePath'    => 'file_path',
        'shareId'     => 'drive_id',
    ];
    protected $_example = [
        'asyncTaskId' => '000e89fb-cf8f-11e9-8ab4-b6e980803a3b',
        'domainId'    => 'test001',
        'driveId'     => '1',
        'filePath'    => '/a/b/c.jpg',
        'shareId'     => 'test001',
    ];
    protected $_pattern = [
        'domainId' => '[a-z0-9A-Z-]+',
        'driveId'  => '[0-9]+',
        'shareId'  => '[a-z0-9A-Z]+',
    ];
}
