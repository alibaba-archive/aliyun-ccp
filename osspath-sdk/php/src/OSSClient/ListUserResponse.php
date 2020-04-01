<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * List user response.
 */
class ListUserResponse extends Model
{
    /**
     * @var array
     */
    public $items;
    /**
     * @description 翻页标记
     *
     * @example nextmarker
     *
     * @var string
     */
    public $nextMarker;
    protected $_name = [
        'items'      => 'items',
        'nextMarker' => 'next_marker',
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
        $res['next_marker'] = $this->nextMarker;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListUserResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['items'])) {
            if (!empty($map['items'])) {
                $model->items = [];
                $n            = 0;
                foreach ($map['items'] as $item) {
                    $model->items[$n++] = null !== $item ? BaseUserResponse::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['next_marker'])) {
            $model->nextMarker = $map['next_marker'];
        }

        return $model;
    }
}
