<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * List image address groups request.
 */
class ListImageAddressGroupsRequest extends Model
{
    public $driveId;
    public $imageThumbnailProcess;
    public $limit;
    public $marker;
    protected $_required = [
        'driveId' => true,
    ];
    protected $_name = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
    ];
    protected $_description = [
        'driveId'               => 'Drive ID',
        'imageThumbnailProcess' => 'image_thumbnail_process
type:string',
        'limit'  => '每页大小限制',
        'marker' => '翻页标记',
    ];
    protected $_example = [
        'driveId'               => '123',
        'imageThumbnailProcess' => 'image/resize,w_200',
        'limit'                 => 10,
        'marker'                => 'marker',
    ];
    protected $_default = [
        'limit' => 100,
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
