<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 搜索文件元数据
 */
class CCPSearchFileRequest extends Model{
    protected $_required = [
        "driveId" => true,
    ];
    protected $_name = [
        "driveId" => "drive_id",
        "imageThumbnailProcess" => "image_thumbnail_process",
        "imageUrlProcess" => "image_url_process",
        "limit" => "limit",
        "marker" => "marker",
        "orderBy" => "order_by",
        "query" => "query",
        "urlExpireSec" => "url_expire_sec",
        "videoThumbnailProcess" => "video_thumbnail_process",
    ];
    protected $_description = [
        "driveId" => "drive_id",
        "imageThumbnailProcess" => "image_thumbnail_process",
        "imageUrlProcess" => "image_url_process",
        "limit" => "limit",
        "marker" => "Marker",
        "orderBy" => "order_by",
        "query" => "query",
        "urlExpireSec" => "url_expire_sec",
        "videoThumbnailProcess" => "video_thumbnail_process
type:string",
    ];
    protected $_example = [
        "driveId" => "1",
        "imageThumbnailProcess" => "image/resize,m_fill,h_128,w_128,limit_0",
        "imageUrlProcess" => "image/resize,m_fill,h_128,w_128,limit_0",
        "limit" => 10,
        "marker" => """",
        "orderBy" => "size",
        "query" => "not name=123",
        "urlExpireSec" => 900,
        "videoThumbnailProcess" => "video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast",
    ];
    protected $_pattern = [
        "driveId" => "[0-9]+",
    ];
    protected $_default = [
        "limit" => 50,
        "orderBy" => "updated_at",
        "urlExpireSec" => 900,
    ];
    protected $_format = [
        "limit" => "int32",
        "urlExpireSec" => "int64",
    ];
    protected $_maximum = [
        "limit" => 100,
        "urlExpireSec" => 14400,
    ];
    protected $_minimum = [
        "limit" => 1,
        "urlExpireSec" => 10,
    ];
    protected $_enum = [
        "orderBy" => "name, created_at, updated_at, size",
    ];
    protected $_maxLength = [
        "query" => 4096,
    ];
    public $driveId;
    public $imageThumbnailProcess;
    public $imageUrlProcess;
    public $limit;
    public $marker;
    public $orderBy;
    public $query;
    public $urlExpireSec;
    public $videoThumbnailProcess;
}
