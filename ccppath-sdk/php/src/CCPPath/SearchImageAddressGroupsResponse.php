<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCPPath;

use AlibabaCloud\Tea\Model;

/**
 * 展示地点分组列表.
 */
class SearchImageAddressGroupsResponse extends Model
{
    /**
     * @var array
     */
    public $items;
    protected $_name = [
        'items' => 'items',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res          = [];
        $res['items'] = [];
        if (null !== $this->items && \is_array($this->items)) {
            $n = 0;
            foreach ($this->items as $item) {
                $res['items'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchImageAddressGroupsResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['items'])) {
            if (!empty($map['items'])) {
                $model->items = [];
                $n            = 0;
                foreach ($map['items'] as $item) {
                    $model->items[$n++] = null !== $item ? ImageAddressResponse::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
