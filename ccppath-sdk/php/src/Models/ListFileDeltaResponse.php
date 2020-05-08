<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * list file op response.
 */
class ListFileDeltaResponse extends Model
{
    /**
     * @description cursor
     *
     * @example abc
     *
     * @var string
     */
    public $cursor;

    /**
     * @description has_more
     *
     * @example false
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description items
     *
     * @example
     *
     * @var array
     */
    public $items;
    protected $_name = [
        'cursor'  => 'cursor',
        'hasMore' => 'has_more',
        'items'   => 'items',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res             = [];
        $res['cursor']   = $this->cursor;
        $res['has_more'] = $this->hasMore;
        $res['items']    = [];
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
     * @return ListFileDeltaResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['has_more'])) {
            $model->hasMore = $map['has_more'];
        }
        if (isset($map['items'])) {
            if (!empty($map['items'])) {
                $model->items = [];
                $n            = 0;
                foreach ($map['items'] as $item) {
                    $model->items[$n++] = null !== $item ? FileDeltaResponse::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
