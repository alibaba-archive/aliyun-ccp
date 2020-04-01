<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件下载地址的请求body.
 */
class GetDownloadUrlRequest extends Model
{
    public $driveId;
    public $expireSec;
    public $fileId;
    public $fileName;
    public $filePath;
    public $shareId;
    protected $_required = [
        'driveId' => true,
        'fileId'  => true,
    ];
    protected $_name = [
        'driveId'   => 'drive_id',
        'expireSec' => 'expire_sec',
        'fileId'    => 'file_id',
        'fileName'  => 'file_name',
        'filePath'  => 'file_path',
        'shareId'   => 'share_id',
    ];
    protected $_description = [
        'driveId'   => 'drive_id',
        'expireSec' => 'expire_sec',
        'fileId'    => 'file_id',
        'fileName'  => 'file_name',
    ];
    protected $_example = [
        'driveId'   => '1',
        'expireSec' => 15,
        'fileName'  => 'ccp.jpg',
    ];
    protected $_pattern = [
        'driveId'  => '[0-9]+',
        'fileId'   => '[a-z0-9.-_]{1,50}',
        'fileName' => '[a-zA-Z0-9.-]{1,1000}',
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
        'expireSec' => 0,
    ];
    protected $_maxLength = [
        'fileId' => 50,
    ];
    protected $_minLength = [
        'fileId' => 40,
    ];
}
