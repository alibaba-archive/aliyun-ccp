<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件安全地址的请求body.
 */
class OSSGetSecureUrlRequest extends Model
{
    public $driveId;
    public $expireSec;
    public $filePath;
    public $secureIp;
    public $shareId;
    protected $_name = [
        'driveId'   => 'drive_id',
        'expireSec' => 'expire_sec',
        'filePath'  => 'file_path',
        'secureIp'  => 'secure_ip',
        'shareId'   => 'share_id',
    ];
    protected $_description = [
        'driveId'   => 'drive_id',
        'expireSec' => 'expire_sec 单位秒',
        'filePath'  => 'file_path',
        'secureIp'  => 'secure_ip',
        'shareId'   => 'share_id',
    ];
    protected $_example = [
        'driveId'   => '1',
        'expireSec' => 60,
        'filePath'  => '/a/b/c.jpg',
        'secureIp'  => '192.168.1.1/24',
        'shareId'   => '3d336314-63c8-4d96-bce0-17aefb6833b6',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
        'shareId' => '[0-9a-z-]+',
    ];
    protected $_default = [
        'expireSec' => 60,
    ];
    protected $_format = [
        'expireSec' => 'int64',
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
