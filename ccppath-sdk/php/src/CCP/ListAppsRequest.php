<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class ListAppsRequest extends Model
{
    public $limit;
    public $marker;
    protected $_name = [
        'limit'  => 'limit',
        'marker' => 'marker',
    ];
    protected $_default = [
        'limit' => 50,
    ];
    protected $_description = [
        'limit'  => '返回结果数据',
        'marker' => '下次查询游标',
    ];
    protected $_example = [
        'limit'  => 100,
        'marker' => 'ncsajnsalsa=',
    ];
    protected $_format = [
        'limit' => 'int32',
    ];
    protected $_maximum = [
        'limit' => 100,
    ];
    protected $_minimum = [
        'limit' => 1,
    ];
}
