<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * list file request.
 */
class BaseListFileRequest extends Model
{
    public $driveId;
    public $imageThumbnailProcess;
    public $imageUrlProcess;
    public $limit;
    public $marker;
    public $videoThumbnailProcess;
    protected $_name = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
        'videoThumbnailProcess' => 'video_thumbnail_process',
    ];
    protected $_description = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
        'videoThumbnailProcess' => 'video_thumbnail_process
type:string',
    ];
    protected $_example = [
        'driveId'               => '1',
        'imageThumbnailProcess' => 'image/resize,w_200',
        'imageUrlProcess'       => 'image/resize,w_200',
        'limit'                 => 10,
        'marker'                => 'NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg',
        'videoThumbnailProcess' => 'video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
        'limit'   => '[0-9]{1,3}',
    ];
    protected $_default = [
        'limit' => 50,
    ];
    protected $_format = [
        'limit' => 'int64',
    ];
    protected $_maximum = [
        'limit' => 100,
    ];
    protected $_minimum = [
        'limit' => 0,
    ];
}
