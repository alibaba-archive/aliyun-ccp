<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class ListAppsRequest extends Model
{
    /**
     * @description 返回结果数据
     *
     * @example 100
     *
     * @var int
     */
    public $limit;
    /**
     * @description 下次查询游标
     *
     * @example ncsajnsalsa=
     *
     * @var string
     */
    public $marker;
    protected $_name = [
        'limit'  => 'limit',
        'marker' => 'marker',
    ];
    protected $_default = [
        'limit' => 50,
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
     * @return ListAppsRequest
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
