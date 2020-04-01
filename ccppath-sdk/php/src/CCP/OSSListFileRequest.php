<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * list file request.
 */
class OSSListFileRequest extends Model
{
    public $driveId;
    public $imageThumbnailProcess;
    public $imageUrlProcess;
    public $limit;
    public $marker;
    public $parentFilePath;
    public $shareId;
    public $urlExpireSec;
    public $videoThumbnailProcess;
    protected $_name = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
        'parentFilePath'        => 'parent_file_path',
        'shareId'               => 'share_id',
        'urlExpireSec'          => 'url_expire_sec',
        'videoThumbnailProcess' => 'video_thumbnail_process',
    ];
    protected $_description = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
        'parentFilePath'        => 'ParentFilePath',
        'shareId'               => 'drive_id',
        'urlExpireSec'          => 'url_expire_sec',
        'videoThumbnailProcess' => 'video_thumbnail_process
type:string',
    ];
    protected $_example = [
        'driveId'               => '1',
        'imageThumbnailProcess' => 'image/resize,w_200',
        'imageUrlProcess'       => 'image/resize,w_200',
        'limit'                 => 10,
        'marker'                => 'NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg',
        'parentFilePath'        => '/a/b/c.jpg',
        'shareId'               => '1',
        'urlExpireSec'          => 900,
        'videoThumbnailProcess' => 'video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
        'limit'   => '[0-9]{1,3}',
        'shareId' => '[0-9]+',
    ];
    protected $_default = [
        'limit'        => 50,
        'urlExpireSec' => 900,
    ];
    protected $_format = [
        'limit'        => 'int64',
        'urlExpireSec' => 'int64',
    ];
    protected $_maximum = [
        'limit'        => 100,
        'urlExpireSec' => 14400,
    ];
    protected $_minimum = [
        'limit'        => 0,
        'urlExpireSec' => 10,
    ];
    protected $_required = [
        'parentFilePath' => true,
    ];
}
