<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class CorsRule extends Model
{
    /**
     * @description AllowedHeader
     *
     * @example h*
     *
     * @var array
     */
    public $allowedHeader;
    /**
     * @description AllowedMethod
     *
     * @example PUT, GET
     *
     * @var array
     */
    public $allowedMethod;
    /**
     * @description AllowedOrigin
     *
     * @example *
     *
     * @var array
     */
    public $allowedOrigin;
    /**
     * @description ExposeHeader
     *
     * @example ETag
     *
     * @var array
     */
    public $exposeHeader;
    /**
     * @description MaxAgeSeconds
     *
     * @example 0
     *
     * @var int
     */
    public $maxAgeSeconds;
    protected $_name = [
        'allowedHeader' => 'allowed_header',
        'allowedMethod' => 'allowed_method',
        'allowedOrigin' => 'allowed_origin',
        'exposeHeader'  => 'expose_header',
        'maxAgeSeconds' => 'max_age_seconds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                   = [];
        $res['allowed_header'] = [];
        if (null !== $this->allowedHeader) {
            $res['allowed_header'] = $this->allowedHeader;
        }
        $res['allowed_method'] = [];
        if (null !== $this->allowedMethod) {
            $res['allowed_method'] = $this->allowedMethod;
        }
        $res['allowed_origin'] = [];
        if (null !== $this->allowedOrigin) {
            $res['allowed_origin'] = $this->allowedOrigin;
        }
        $res['expose_header'] = [];
        if (null !== $this->exposeHeader) {
            $res['expose_header'] = $this->exposeHeader;
        }
        $res['max_age_seconds'] = $this->maxAgeSeconds;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CorsRule
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allowed_header'])) {
            if (!empty($map['allowed_header'])) {
                $model->allowedHeader = [];
                $model->allowedHeader = $map['allowed_header'];
            }
        }
        if (isset($map['allowed_method'])) {
            if (!empty($map['allowed_method'])) {
                $model->allowedMethod = [];
                $model->allowedMethod = $map['allowed_method'];
            }
        }
        if (isset($map['allowed_origin'])) {
            if (!empty($map['allowed_origin'])) {
                $model->allowedOrigin = [];
                $model->allowedOrigin = $map['allowed_origin'];
            }
        }
        if (isset($map['expose_header'])) {
            if (!empty($map['expose_header'])) {
                $model->exposeHeader = [];
                $model->exposeHeader = $map['expose_header'];
            }
        }
        if (isset($map['max_age_seconds'])) {
            $model->maxAgeSeconds = $map['max_age_seconds'];
        }

        return $model;
    }
}
