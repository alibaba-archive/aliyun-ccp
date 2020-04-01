<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * list domain request.
 */
class ListDomainsRequest extends Model
{
    public $limit;
    public $marker;
    protected $_name = [
        'limit'  => 'limit',
        'marker' => 'marker',
    ];
    protected $_description = [
        'limit'  => '分页大小',
        'marker' => '查询游标',
    ];
    protected $_example = [
        'limit'  => 100,
        'marker' => 'abcd',
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
