<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Delete user request.
 */
class DeleteUserRequest extends Model
{
    public $userId;
    protected $_required = [
        'userId' => true,
    ];
    protected $_name = [
        'userId' => 'user_id',
    ];
    protected $_description = [
        'userId' => '用户 ID',
    ];
    protected $_example = [
        'userId' => 'ccpuserid',
    ];
}
