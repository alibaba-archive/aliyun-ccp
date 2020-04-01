<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 批处理.
 */
class CCPBatchRequest extends Model
{
    /**
     * @description Requests 请求合集
     *
     * @var array
     */
    public $requests;
    /**
     * @description 支持的资源类型
     *
     * @example "file"
     *
     * @var string
     */
    public $resource;
    protected $_name = [
        'requests' => 'requests',
        'resource' => 'resource',
    ];

    public function validate()
    {
        Model::validateField($this->requests, 'required', true);
        Model::validateField($this->resource, 'required', true);
    }

    public function toMap()
    {
        $res             = [];
        $res['requests'] = [];
        if (null !== $this->requests && \is_array($this->requests)) {
            $n = 0;
            foreach ($this->requests as $item) {
                $res['requests'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['resource'] = $this->resource;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPBatchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requests'])) {
            if (!empty($map['requests'])) {
                $model->requests = [];
                $n               = 0;
                foreach ($map['requests'] as $item) {
                    $model->requests[$n++] = null !== $item ? BatchSubRequest::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['resource'])) {
            $model->resource = $map['resource'];
        }

        return $model;
    }
}
