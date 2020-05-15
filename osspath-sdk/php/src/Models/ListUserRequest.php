<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * List user request.
 */
class ListUserRequest extends Model
{
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
        'limit'  => 'limit',
        'marker' => 'marker',
    ];
    protected $_default = [
        'limit' => 100,
    ];

    public function validate()
    {
        Model::validateMaximum('limit', $this->limit, 100);
        Model::validateMinimum('limit', $this->limit, 1);
    }

    public function toMap()
    {
        $res           = [];
        $res['limit']  = $this->limit;
        $res['marker'] = $this->marker;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['marker'])) {
            $model->marker = $map['marker'];
        }

        return $model;
    }
}
