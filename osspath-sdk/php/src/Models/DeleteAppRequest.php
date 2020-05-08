<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class DeleteAppRequest extends Model
{
    /**
     * @description App ID
     *
     * @example CNMrhxwPJHAReExa
     *
     * @var string
     */
    public $appId;
    protected $_name = [
        'appId' => 'app_id',
    ];

    public function validate()
    {
        Model::validateRequired('appId', $this->appId, true);
    }

    public function toMap()
    {
        $res           = [];
        $res['app_id'] = $this->appId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['app_id'])) {
            $model->appId = $map['app_id'];
        }

        return $model;
    }
}
