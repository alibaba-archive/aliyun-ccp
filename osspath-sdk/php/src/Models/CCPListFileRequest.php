<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * 列举文件.
 */
class CCPListFileRequest extends Model
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
     * @example image/resize,w_200
     *
     * @var string
     */
    public $imageThumbnailProcess;

    /**
     * @description image_url_process
     *
     * @example image/resize,w_200
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
     * @description marker
     *
     * @example NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg
     *
     * @var string
     */
    public $marker;

    /**
     * @description video_thumbnail_process
     * type:string
     * @example video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast
     *
     * @var string
     */
    public $videoThumbnailProcess;

    /**
     * @description starred
     *
     * @example false
     *
     * @var bool
     */
    public $Starred;

    /**
     * @description all
     *
     * @example false
     *
     * @var bool
     */
    public $all;

    /**
     * @description category
     *
     * @example image
     *
     * @var string
     */
    public $category;

    /**
     * @description fields
     *
     * @example *
     *
     * @var string
     */
    public $fields;

    /**
     * @description order_by
     *
     * @example name
     *
     * @var string
     */
    public $orderBy;

    /**
     * @description order_direction
     *
     * @example ASC
     *
     * @var string
     */
    public $orderDirection;

    /**
     * @description ParentFileID
     *
     * @example root
     *
     * @var string
     */
    public $parentFileId;

    /**
     * @description status
     *
     * @example available
     *
     * @var string
     */
    public $status;

    /**
     * @description type
     *
     * @example file
     *
     * @var string
     */
    public $type;

    /**
     * @description url_expire_sec
     *
     * @example 900
     *
     * @var int
     */
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
        'fields'                => 'fields',
        'orderBy'               => 'order_by',
        'orderDirection'        => 'order_direction',
        'parentFileId'          => 'parent_file_id',
        'status'                => 'status',
        'type'                  => 'type',
        'urlExpireSec'          => 'url_expire_sec',
    ];
    protected $_default = [
        'limit'        => 50,
        'all'          => 'true',
        'status'       => 'available',
        'urlExpireSec' => 900,
    ];

    public function validate()
    {
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('limit', $this->limit, '[0-9]{1,3}');
        Model::validatePattern('parentFileId', $this->parentFileId, '[a-z0-9.-_]{1,50}');
        Model::validateMaximum('limit', $this->limit, 100);
        Model::validateMaximum('urlExpireSec', $this->urlExpireSec, 14400);
        Model::validateMinimum('limit', $this->limit, 0);
        Model::validateMinimum('urlExpireSec', $this->urlExpireSec, 10);
        Model::validateMaxLength('parentFileId', $this->parentFileId, 50);
        Model::validateMinLength('parentFileId', $this->parentFileId, 40);
    }

    public function toMap()
    {
        $res                            = [];
        $res['drive_id']                = $this->driveId;
        $res['image_thumbnail_process'] = $this->imageThumbnailProcess;
        $res['image_url_process']       = $this->imageUrlProcess;
        $res['limit']                   = $this->limit;
        $res['marker']                  = $this->marker;
        $res['video_thumbnail_process'] = $this->videoThumbnailProcess;
        $res['Starred']                 = $this->Starred;
        $res['all']                     = $this->all;
        $res['category']                = $this->category;
        $res['fields']                  = $this->fields;
        $res['order_by']                = $this->orderBy;
        $res['order_direction']         = $this->orderDirection;
        $res['parent_file_id']          = $this->parentFileId;
        $res['status']                  = $this->status;
        $res['type']                    = $this->type;
        $res['url_expire_sec']          = $this->urlExpireSec;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPListFileRequest
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
        if (isset($map['video_thumbnail_process'])) {
            $model->videoThumbnailProcess = $map['video_thumbnail_process'];
        }
        if (isset($map['Starred'])) {
            $model->Starred = $map['Starred'];
        }
        if (isset($map['all'])) {
            $model->all = $map['all'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['fields'])) {
            $model->fields = $map['fields'];
        }
        if (isset($map['order_by'])) {
            $model->orderBy = $map['order_by'];
        }
        if (isset($map['order_direction'])) {
            $model->orderDirection = $map['order_direction'];
        }
        if (isset($map['parent_file_id'])) {
            $model->parentFileId = $map['parent_file_id'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['url_expire_sec'])) {
            $model->urlExpireSec = $map['url_expire_sec'];
        }

        return $model;
    }
}
