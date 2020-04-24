<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCPPath;

use AlibabaCloud\Tea\Model;

class ImageAddressResponse extends Model
{
    /**
     * @var Address
     */
    public $addressDetail;

    /**
     * @description 聚类地点计数
     *
     * @example 1
     *
     * @var int
     */
    public $count;

    /**
     * @description 聚类地点封面图片地址
     *
     * @example http://imm-dev-wmt/tags/05.jpg?x-oss-process=xxx
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @description 经纬度
     *
     * @example 39.21211,101.32111
     *
     * @var string
     */
    public $location;

    /**
     * @description 聚类地点名称
     *
     * @example 杭州
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'addressDetail' => 'address_detail',
        'count'         => 'count',
        'coverUrl'      => 'cover_url',
        'location'      => 'location',
        'name'          => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                   = [];
        $res['address_detail'] = null !== $this->addressDetail ? $this->addressDetail->toMap() : null;
        $res['count']          = $this->count;
        $res['cover_url']      = $this->coverUrl;
        $res['location']       = $this->location;
        $res['name']           = $this->name;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ImageAddressResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address_detail'])) {
            $model->addressDetail = Address::fromMap($map['address_detail']);
        }
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['cover_url'])) {
            $model->coverUrl = $map['cover_url'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
