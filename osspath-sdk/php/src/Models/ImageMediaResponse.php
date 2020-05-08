<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class ImageMediaResponse extends Model
{
    /**
     * @description height
     *
     * @example 720
     *
     * @var int
     */
    public $height;

    /**
     * @description time
     *
     * @var string
     */
    public $time;

    /**
     * @description width
     *
     * @example 1024
     *
     * @var int
     */
    public $width;
    protected $_name = [
        'height' => 'height',
        'time'   => 'time',
        'width'  => 'width',
    ];
    protected $_default = [
        'height' => 0,
        'width'  => 0,
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res           = [];
        $res['height'] = $this->height;
        $res['time']   = $this->time;
        $res['width']  = $this->width;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ImageMediaResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['height'])) {
            $model->height = $map['height'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }
        if (isset($map['width'])) {
            $model->width = $map['width'];
        }

        return $model;
    }
}
