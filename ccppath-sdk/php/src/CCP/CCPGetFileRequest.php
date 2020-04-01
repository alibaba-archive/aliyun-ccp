<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件元数据.
 */
class CCPGetFileRequest extends Model
{
    public $driveId;
    public $fileId;
    public $imageThumbnailProcess;
    public $imageUrlProcess;
    public $urlExpireSec;
    public $videoThumbnailProcess;
    protected $_required = [
        'driveId' => true,
        'fileId'  => true,
    ];
    protected $_name = [
        'driveId'               => 'drive_id',
        'fileId'                => 'file_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'urlExpireSec'          => 'url_expire_sec',
        'videoThumbnailProcess' => 'video_thumbnail_process',
    ];
    protected $_description = [
        'driveId'               => 'drive_id',
        'fileId'                => 'file_id',
        'imageThumbnailProcess' => 'image_thumbnail_process
type:string',
        'imageUrlProcess' => 'image_thumbnail_process
type:string',
        'urlExpireSec'          => 'url_expire_sec',
        'videoThumbnailProcess' => 'video_thumbnail_process
type:string',
    ];
    protected $_example = [
        'driveId'               => '1',
        'fileId'                => '5d5b846942cf94fa72324c14a4bda34e81da635d',
        'imageThumbnailProcess' => 'image/resize,w_200',
        'imageUrlProcess'       => 'image/crop,w_100,h_100/rounded-corners,r_10/format,png',
        'urlExpireSec'          => 900,
        'videoThumbnailProcess' => 'video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast',
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
