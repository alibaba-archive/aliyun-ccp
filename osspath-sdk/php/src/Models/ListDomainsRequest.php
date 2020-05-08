<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * list domain request.
 */
class ListDomainsRequest extends Model
{
    /**
     * @description 分页大小
     *
     * @example 100
     *
     * @var int
     */
    public $limit;

    /**
     * @description 查询游标
     *
     * @example abcd
     *
     * @var string
     */
    public $marker;
    protected $_name = [
        'limit'  => 'limit',
        'marker' => 'marker',
    ];

    public function validate()
    {
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
     * @return ListDomainsRequest
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
