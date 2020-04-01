<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 文件拷贝 response.
 */
class CCPCopyFileResponse extends Model
{
    public $asyncTaskId;
    public $domainId;
    public $driveId;
    public $fileId;
    protected $_name = [
        'asyncTaskId' => 'async_task_id',
        'domainId'    => 'domain_id',
        'driveId'     => 'drive_id',
        'fileId'      => 'file_id',
    ];
    protected $_description = [
        'asyncTaskId' => 'async_task_id',
        'domainId'    => 'DomainID',
        'driveId'     => 'drive_id',
        'fileId'      => 'file_id',
    ];
    protected $_example = [
        'asyncTaskId' => '000e89fb-cf8f-11e9-8ab4-b6e980803a3b',
        'domainId'    => 'test001',
        'driveId'     => '1',
        'fileId'      => '5d5b846942cf94fa72324c14a4bda34e81da635d',
    ];
    protected $_pattern = [
        'domainId' => '[a-z0-9A-Z]+',
        'driveId'  => '[0-9]+',
        'fileId'   => '[a-z0-9]{1, 50}',
    ];
    protected $_maxLength = [
        'fileId' => 50,
    ];
    protected $_minLength = [
        'fileId' => 40,
    ];
}
