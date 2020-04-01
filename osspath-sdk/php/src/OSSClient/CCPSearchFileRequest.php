<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 搜索文件元数据.
 */
class CCPSearchFileRequest extends Model
{
    /**
     * @description drive_id
     *
     * @example 1
     *
     * @var string
     */
    public $driveId;
    /**
     * @description image_thumbnail_process
     *
     * @example image/resize,m_fill,h_128,w_128,limit_0
     *
     * @var string
     */
    public $imageThumbnailProcess;
    /**
     * @description image_url_process
     *
     * @example image/resize,m_fill,h_128,w_128,limit_0
     *
     * @var string
     */
    public $imageUrlProcess;
    /**
     * @description limit
     *
     * @example 10
     *
     * @var int
     */
    public $limit;
    /**
     * @description Marker
     *
     * @example ""
     *
     * @var string
     */
    public $marker;
    /**
     * @description order_by
     *
     * @example size
     *
     * @var string
     */
    public $orderBy;
    /**
     * @description query
     *
     * @example not name=123
     *
     * @var string
     */
    public $query;
    /**
     * @description url_expire_sec
     *
     * @example 900
     *
     * @var int
     */
    public $urlExpireSec;
    /**
     * @description video_thumbnail_process
     * type:string
     * @example video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast
     *
     * @var string
     */
    public $videoThumbnailProcess;
    protected $_name = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
        'orderBy'               => 'order_by',
        'query'                 => 'query',
        'urlExpireSec'          => 'url_expire_sec',
        'videoThumbnailProcess' => 'video_thumbnail_process',
    ];
    protected $_default = [
        'limit'        => 50,
        'orderBy'      => 'updated_at',
        'urlExpireSec' => 900,
    ];

    public function validate()
    {
        Model::validateField($this->driveId, 'required', true);
        Model::validateField($this->driveId, 'pattern', '[0-9]+');
        Model::validateField($this->query, 'maxLength', 4096);
    }

    public function toMap()
    {
        $res                            = [];
        $res['drive_id']                = $this->driveId;
        $res['image_thumbnail_process'] = $this->imageThumbnailProcess;
        $res['image_url_process']       = $this->imageUrlProcess;
        $res['limit']                   = $this->limit;
        $res['marker']                  = $this->marker;
        $res['order_by']                = $this->orderBy;
        $res['query']                   = $this->query;
        $res['url_expire_sec']          = $this->urlExpireSec;
        $res['video_thumbnail_process'] = $this->videoThumbnailProcess;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPSearchFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['image_thumbnail_process'])) {
            $model->imageThumbnailProcess = $map['image_thumbnail_process'];
        }
        if (isset($map['image_url_process'])) {
            $model->imageUrlProcess = $map['image_url_process'];
        }
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['marker'])) {
            $model->marker = $map['marker'];
        }
        if (isset($map['order_by'])) {
            $model->orderBy = $map['order_by'];
        }
        if (isset($map['query'])) {
            $model->query = $map['query'];
        }
        if (isset($map['url_expire_sec'])) {
            $model->urlExpireSec = $map['url_expire_sec'];
        }
        if (isset($map['video_thumbnail_process'])) {
            $model->videoThumbnailProcess = $map['video_thumbnail_process'];
        }

        return $model;
    }
}
