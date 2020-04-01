<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Delete drive request.
 */
class DeleteDriveRequest extends Model
{
    public $driveId;
    protected $_required = [
        'driveId' => true,
    ];
    protected $_name = [
        'driveId' => 'drive_id',
    ];
    protected $_description = [
        'driveId' => 'Drive ID',
    ];
    protected $_example = [
        'driveId' => '123',
    ];
}
