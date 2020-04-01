<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 列举文件.
 */
class CCPListFileRequest extends Model
{
    public $driveId;
    public $imageThumbnailProcess;
    public $imageUrlProcess;
    public $limit;
    public $marker;
    public $videoThumbnailProcess;
    public $Starred;
    public $all;
    public $category;
    public $orderBy;
    public $orderDirection;
    public $parentFileId;
    public $status;
    public $type;
    public $urlExpireSec;
    protected $_name = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
        'videoThumbnailProcess' => 'video_thumbnail_process',
        'Starred'               => 'Starred',
        'all'                   => 'all',
        'category'              => 'category',
        'orderBy'               => 'order_by',
        'orderDirection'        => 'order_direction',
        'parentFileId'          => 'parent_file_id',
        'status'                => 'status',
        'type'                  => 'type',
        'urlExpireSec'          => 'url_expire_sec',
    ];
    protected $_description = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
        'videoThumbnailProcess' => 'video_thumbnail_process
type:string',
        'Starred'        => 'starred',
        'all'            => 'all',
        'category'       => 'category',
        'orderBy'        => 'order_by',
        'orderDirection' => 'order_direction',
        'parentFileId'   => 'ParentFileID',
        'status'         => 'status',
        'type'           => 'type',
        'urlExpireSec'   => 'url_expire_sec',
    ];
    protected $_example = [
        'driveId'               => '1',
        'imageThumbnailProcess' => 'image/resize,w_200',
        'imageUrlProcess'       => 'image/resize,w_200',
        'limit'                 => 10,
        'marker'                => 'NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg',
        'videoThumbnailProcess' => 'video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast',
        'Starred'               => 'false',
        'all'                   => 'false',
        'category'              => 'image',
        'orderBy'               => 'name',
        'orderDirection'        => 'ASC',
        'parentFileId'          => 'root',
        'status'                => 'available',
        'type'                  => 'file',
        'urlExpireSec'          => 900,
    ];
    protected $_pattern = [
        'driveId'      => '[0-9]+',
        'limit'        => '[0-9]{1,3}',
        'parentFileId' => '[a-z0-9.-_]{1,50}',
    ];
    protected $_default = [
        'limit'        => 50,
        'all'          => 'true',
        'status'       => 'available',
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
    protected $_enum = [
        'Starred'        => 'false, true',
        'all'            => 'false, true',
        'category'       => 'image, video, music, doc, other',
        'orderBy'        => 'update_time, name',
        'orderDirection' => 'ASC, DESC',
        'status'         => 'uploading, available',
        'type'           => 'file, folder',
    ];
    protected $_maxLength = [
        'parentFileId' => 50,
    ];
    protected $_minLength = [
        'parentFileId' => 40,
    ];
}
