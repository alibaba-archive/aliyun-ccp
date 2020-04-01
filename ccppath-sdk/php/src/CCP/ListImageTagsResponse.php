<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 展示标签集合.
 */
class ListImageTagsResponse extends Model
{
    /**
     * @var array
     */
    public $tags;
    protected $_name = [
        'tags' => 'tags',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res         = [];
        $res['tags'] = [];
        if (null !== $this->tags && \is_array($this->tags)) {
            $n = 0;
            foreach ($this->tags as $item) {
                $res['tags'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListImageTagsResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tags'])) {
            if (!empty($map['tags'])) {
                $model->tags = [];
                $n           = 0;
                foreach ($map['tags'] as $item) {
                    $model->tags[$n++] = null !== $item ? ImageTagResponse::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
