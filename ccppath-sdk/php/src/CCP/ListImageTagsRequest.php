<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * List image tags request.
 */
class ListImageTagsRequest extends Model
{
    public $driveId;
    public $imageThumbnailProcess;
    protected $_required = [
        'driveId' => true,
    ];
    protected $_name = [
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
    ];
    protected $_description = [
        'driveId'               => 'Drive ID',
        'imageThumbnailProcess' => 'image_thumbnail_process
type:string',
    ];
    protected $_example = [
        'driveId'               => '123',
        'imageThumbnailProcess' => 'image/resize,w_200',
    ];
}
