<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 删除文件请求
 */
class OSSDeleteFileRequest extends Model
{
    public $driveId;
    public $filePath;
    public $permanently;
    public $shareId;
    protected $_name = [
        'driveId'     => 'drive_id',
        'filePath'    => 'file_path',
        'permanently' => 'permanently',
        'shareId'     => 'share_id',
    ];
    protected $_description = [
        'driveId'     => 'drive_id',
        'filePath'    => 'file_path',
        'permanently' => 'permanently
type: false',
        'shareId' => 'share_id',
    ];
    protected $_example = [
        'driveId'     => '1',
        'permanently' => 'false',
        'shareId'     => '3d336314-63c8-4d96-bce0-17aefb6833b6',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
        'shareId' => '[0-9a-zA-z-]+',
    ];
    protected $_required = [
        'filePath' => true,
    ];
    protected $_maxLength = [
        'filePath' => 1000,
    ];
    protected $_minLength = [
        'filePath' => 1,
    ];
}
