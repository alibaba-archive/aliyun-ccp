<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件下载地址的请求body.
 */
class OSSGetDownloadUrlRequest extends Model
{
    public $driveId;
    public $expireSec;
    public $fileName;
    public $filePath;
    public $shareId;
    protected $_name = [
        'driveId'   => 'drive_id',
        'expireSec' => 'expire_sec',
        'fileName'  => 'file_name',
        'filePath'  => 'file_path',
        'shareId'   => 'share_id',
    ];
    protected $_description = [
        'driveId'   => 'drive_id',
        'expireSec' => 'expire_sec',
        'fileName'  => 'file_name',
        'filePath'  => 'file_path',
        'shareId'   => 'share_id',
    ];
    protected $_example = [
        'driveId'   => '1',
        'expireSec' => 15,
        'fileName'  => 'ccp.jpg',
        'filePath'  => '/a/b/c.jpg',
        'shareId'   => '3d336314-63c8-4d96-bce0-17aefb6833b6',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
        'shareId' => '[0-9a-z-]+',
    ];
    protected $_default = [
        'expireSec' => 900,
    ];
    protected $_format = [
        'expireSec' => 'int64',
    ];
    protected $_maximum = [
        'expireSec' => 14400,
    ];
    protected $_minimum = [
        'expireSec' => 10,
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
