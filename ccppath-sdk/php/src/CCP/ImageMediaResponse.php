<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class ImageMediaResponse extends Model
{
    public $height;
    public $time;
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
    protected $_description = [
        'height' => 'height',
        'time'   => 'time',
        'width'  => 'width',
    ];
    protected $_example = [
        'height' => 720,
        'width'  => 1024,
    ];
    protected $_format = [
        'height' => 'int64',
        'time'   => 'date-time',
        'width'  => 'int64',
    ];
}
