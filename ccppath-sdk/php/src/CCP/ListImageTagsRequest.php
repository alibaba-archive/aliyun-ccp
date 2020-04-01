<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * List image tags request.
 */
class ListImageTagsRequest extends Model
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
    protected $_name = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListImageTagsRequest
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

        return $model;
    }
}
