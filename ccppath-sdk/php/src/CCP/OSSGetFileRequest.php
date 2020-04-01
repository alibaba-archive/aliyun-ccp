<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件元数据.
 */
class OSSGetFileRequest extends Model
{
    public $driveId;
    public $filePath;
    public $imageThumbnailProcess;
    public $imageUrlProcess;
    public $shareId;
    public $urlExpireSec;
    protected $_name = [
        'driveId'               => 'drive_id',
        'filePath'              => 'file_path',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'shareId'               => 'share_id',
        'urlExpireSec'          => 'url_expire_sec',
    ];
    protected $_description = [
        'driveId'               => 'drive_id',
        'filePath'              => 'file_id',
        'imageThumbnailProcess' => 'image_thumbnail_process
type:string',
        'imageUrlProcess' => 'image_thumbnail_process
type:string',
        'shareId'      => 'share_id',
        'urlExpireSec' => 'url_expire_sec',
    ];
    protected $_example = [
        'driveId'               => '1',
        'imageThumbnailProcess' => 'image/resize,w_200',
        'imageUrlProcess'       => 'image/resize,w_200',
        'shareId'               => '3d336314-63c8-4d96-bce0-17aefb6833b6',
        'urlExpireSec'          => 900,
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
    protected $_default = [
        'urlExpireSec' => 900,
    ];
    protected $_format = [
        'urlExpireSec' => 'int64',
    ];
    protected $_maximum = [
        'urlExpireSec' => 14400,
    ];
    protected $_minimum = [
        'urlExpireSec' => 10,
    ];
}
