<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * List image face groups request.
 */
class ListImageFaceGroupsRequest extends Model
{
    public $driveId;
    public $limit;
    public $marker;
    protected $_required = [
        'driveId' => true,
    ];
    protected $_name = [
        'driveId' => 'drive_id',
        'limit'   => 'limit',
        'marker'  => 'marker',
    ];
    protected $_description = [
        'driveId' => 'Drive ID',
        'limit'   => '每页大小限制',
        'marker'  => '翻页标记',
    ];
    protected $_example = [
        'driveId' => '123',
        'limit'   => 10,
        'marker'  => 'marker',
    ];
    protected $_default = [
        'limit' => 100,
    ];
    protected $_format = [
        'limit' => 'int64',
    ];
    protected $_maximum = [
        'limit' => 100,
    ];
    protected $_minimum = [
        'limit' => 1,
    ];
}
