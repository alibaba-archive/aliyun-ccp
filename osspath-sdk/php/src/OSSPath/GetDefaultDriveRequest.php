<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * Get default drive request.
 */
class GetDefaultDriveRequest extends Model
{
    /**
     * @description 用户ID
     *
     * @example abc
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'userId' => 'user_id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res            = [];
        $res['user_id'] = $this->userId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDefaultDriveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['user_id'])) {
            $model->userId = $map['user_id'];
        }

        return $model;
    }
}
