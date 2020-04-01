<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Get user request.
 */
class GetUserRequest extends Model
{
    public $userId;
    protected $_name = [
        'userId' => 'user_id',
    ];
    protected $_description = [
        'userId' => '用户 ID, 使用ak方式访问，该项必传, access_token访问如果不传，默认取自己的user信息
example',
    ];
}
