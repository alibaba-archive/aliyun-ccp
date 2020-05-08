<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * List image face groups request.
 */
class ListImageFaceGroupsRequest extends Model
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
        'driveId' => 'drive_id',
        'limit'   => 'limit',
        'marker'  => 'marker',
    ];
    protected $_default = [
        'limit' => 100,
    ];

    public function validate()
    {
        Model::validateRequired('driveId', $this->driveId, true);
    }

    public function toMap()
    {
        $res             = [];
        $res['drive_id'] = $this->driveId;
        $res['limit']    = $this->limit;
        $res['marker']   = $this->marker;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListImageFaceGroupsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
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
