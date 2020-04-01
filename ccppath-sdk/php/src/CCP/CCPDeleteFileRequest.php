<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 删除文件请求
 */
class CCPDeleteFileRequest extends Model
{
    public $driveId;
    public $fileId;
    public $permanently;
    protected $_required = [
        'driveId' => true,
        'fileId'  => true,
    ];
    protected $_name = [
        'driveId'     => 'drive_id',
        'fileId'      => 'file_id',
        'permanently' => 'permanently',
    ];
    protected $_description = [
        'driveId'     => 'drive_id',
        'fileId'      => 'file_id',
        'permanently' => 'permanently
type: false',
    ];
    protected $_example = [
        'driveId'     => '1',
        'fileId'      => '5d792010669a1dd91087479e8071c9ae212065cc',
        'permanently' => 'false',
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
    protected $_default = [
        'permanently' => 'false',
    ];
}
