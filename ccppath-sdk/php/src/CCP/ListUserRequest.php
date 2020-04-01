<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * List user request.
 */
class ListUserRequest extends Model
{
    public $limit;
    public $marker;
    protected $_name = [
        'limit'  => 'limit',
        'marker' => 'marker',
    ];
    protected $_default = [
        'limit' => 100,
    ];
    protected $_description = [
        'limit'  => '每页大小限制',
        'marker' => '翻页标记',
    ];
    protected $_example = [
        'limit'  => 10,
        'marker' => 'marker',
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
