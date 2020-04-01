<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * batch operation response.
 */
class CCPBatchResponse extends Model
{
    /**
     * @description responses 返回结果合集
     *
     * @var array
     */
    public $responses;
    protected $_name = [
        'responses' => 'responses',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res              = [];
        $res['responses'] = [];
        if (null !== $this->responses && \is_array($this->responses)) {
            $n = 0;
            foreach ($this->responses as $item) {
                $res['responses'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPBatchResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['responses'])) {
            if (!empty($map['responses'])) {
                $model->responses = [];
                $n                = 0;
                foreach ($map['responses'] as $item) {
                    $model->responses[$n++] = null !== $item ? BatchSubResponse::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
