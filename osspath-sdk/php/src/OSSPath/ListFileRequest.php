<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * list file request.
 */
class ListFileRequest extends Model
{
    /**
     * @description all
     *
     * @var bool
     */
    public $all;

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
     * @var string
     */
    public $imageThumbnailProcess;

    /**
     * @description image_url_process
     *
     * @var string
     */
    public $imageUrlProcess;

    /**
     * @description limit
     *
     * @var int
     */
    public $limit;

    /**
     * @description marker
     *
     * @var string
     */
    public $marker;

    /**
     * @description ParentFileID
     *
     * @var string
     */
    public $parentFileId;

    /**
     * @var string
     */
    public $parentFilePath;

    /**
     * @var string
     */
    public $shareId;

    /**
     * @description status
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'all'                   => 'all',
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
        'parentFileId'          => 'parent_file_id',
        'parentFilePath'        => 'parent_file_path',
        'shareId'               => 'share_id',
        'status'                => 'status',
    ];
    protected $_default = [
        'limit' => 50,
    ];

    public function validate()
    {
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('parentFileId', $this->parentFileId, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('limit', $this->limit, '[0-9]{1,3}');
        Model::validatePattern('parentFileId', $this->parentFileId, '[a-z0-9.-_]{1,50}');
        Model::validateMaxLength('parentFileId', $this->parentFileId, 50);
        Model::validateMinLength('parentFileId', $this->parentFileId, 40);
    }

    public function toMap()
    {
        $res                            = [];
        $res['all']                     = $this->all;
        $res['drive_id']                = $this->driveId;
        $res['image_thumbnail_process'] = $this->imageThumbnailProcess;
        $res['image_url_process']       = $this->imageUrlProcess;
        $res['limit']                   = $this->limit;
        $res['marker']                  = $this->marker;
        $res['parent_file_id']          = $this->parentFileId;
        $res['parent_file_path']        = $this->parentFilePath;
        $res['share_id']                = $this->shareId;
        $res['status']                  = $this->status;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['all'])) {
            $model->all = $map['all'];
        }
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
        if (isset($map['parent_file_id'])) {
            $model->parentFileId = $map['parent_file_id'];
        }
        if (isset($map['parent_file_path'])) {
            $model->parentFilePath = $map['parent_file_path'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
