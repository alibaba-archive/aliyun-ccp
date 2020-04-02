<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class CancelLinkRequest extends Model
{
    /**
     * @description 待绑定的临时token，此token只能访问绑定、取消绑定接口
     *
     * @example ey***s=
     *
     * @var string
     */
    public $temporaryToken;
    protected $_name = [
        'temporaryToken' => 'temporary_token',
    ];

    public function validate()
    {
        Model::validateRequired('temporaryToken', $this->temporaryToken, true);
    }

    public function toMap()
    {
        $res                    = [];
        $res['temporary_token'] = $this->temporaryToken;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CancelLinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['temporary_token'])) {
            $model->temporaryToken = $map['temporary_token'];
        }

        return $model;
    }
}
