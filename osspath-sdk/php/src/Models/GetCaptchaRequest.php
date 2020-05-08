<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class GetCaptchaRequest extends Model
{
    /**
     * @description App ID, 当前访问的App
     *
     * @example csaklidwasdhjwid
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
     * @return GetCaptchaRequest
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
