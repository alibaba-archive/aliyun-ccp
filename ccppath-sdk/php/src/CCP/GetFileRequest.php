<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件元数据.
 */
class GetFileRequest extends Model
{
    public $driveId;
    public $fileId;
    public $filePath;
    public $imageThumbnailProcess;
    public $imageUrlProcess;
    public $shareId;
    protected $_required = [
        'driveId' => true,
        'fileId'  => true,
    ];
    protected $_name = [
        'driveId'               => 'drive_id',
        'fileId'                => 'file_id',
        'filePath'              => 'file_path',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'shareId'               => 'share_id',
    ];
    protected $_description = [
        'driveId'               => 'drive_id',
        'fileId'                => 'file_id',
        'imageThumbnailProcess' => 'image_thumbnail_process
type:string',
        'imageUrlProcess' => 'image_thumbnail_process
type:string',
    ];
    protected $_example = [
        'driveId'               => '1',
        'imageThumbnailProcess' => 'image/resize,w_200',
        'imageUrlProcess'       => 'image/resize,w_200',
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
}
