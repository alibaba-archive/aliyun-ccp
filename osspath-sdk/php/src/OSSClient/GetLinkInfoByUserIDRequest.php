<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class GetLinkInfoByUserIDRequest extends Model
{
    /**
     * @description user ID
     *
     * @example 123987123617823
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'userId' => 'user_id',
    ];

    public function validate()
    {
        Model::validateField($this->userId, 'required', true);
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
     * @return GetLinkInfoByUserIDRequest
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
