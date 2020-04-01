<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Get photo count request.
 */
class GetImageCountRequest extends Model
{
    public $driveId;
    protected $_name = [
        'driveId' => 'drive_id',
    ];
    protected $_description = [
        'driveId' => 'drive_id',
    ];
    protected $_example = [
        'driveId' => '1',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
    ];
}
