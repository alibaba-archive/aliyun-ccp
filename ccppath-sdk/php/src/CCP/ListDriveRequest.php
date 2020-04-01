<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * List drive request.
 */
class ListDriveRequest extends Model
{
    public $limit;
    public $marker;
    public $owner;
    protected $_name = [
        'limit'  => 'limit',
        'marker' => 'marker',
        'owner'  => 'owner',
    ];
    protected $_default = [
        'limit' => 100,
    ];
    protected $_description = [
        'limit'  => '每页大小限制',
        'marker' => '翻页标记, 接口返回的标记值',
        'owner'  => '所属者',
    ];
    protected $_example = [
        'limit'  => 10,
        'marker' => 'marker',
        'owner'  => 'abc',
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
