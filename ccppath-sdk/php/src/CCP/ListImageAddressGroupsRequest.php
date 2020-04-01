<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * List image address groups request.
 */
class ListImageAddressGroupsRequest extends Model
{
    /**
     * @description Drive ID
     *
     * @example 123
     *
     * @var string
     */
    public $driveId;
    /**
     * @description image_thumbnail_process
     * type:string
     * @example image/resize,w_200
     *
     * @var string
     */
    public $imageThumbnailProcess;
    /**
     * @description 每页大小限制
     *
     * @example 10
     *
     * @var int
     */
    public $limit;
    /**
     * @description 翻页标记
     *
     * @example marker
     *
     * @var string
     */
    public $marker;
    protected $_name = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
    ];
    protected $_default = [
        'limit' => 100,
    ];

    public function validate()
    {
        Model::validateField($this->driveId, 'required', true);
    }

    public function toMap()
    {
        $res                            = [];
        $res['drive_id']                = $this->driveId;
        $res['image_thumbnail_process'] = $this->imageThumbnailProcess;
        $res['limit']                   = $this->limit;
        $res['marker']                  = $this->marker;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListImageAddressGroupsRequest
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
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['marker'])) {
            $model->marker = $map['marker'];
        }

        return $model;
    }
}
