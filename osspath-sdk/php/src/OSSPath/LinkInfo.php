<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class LinkInfo extends Model
{
    /**
     * @description 当前用户已存在的登录标识
     *
     * @example 15208345000
     *
     * @var string
     */
    public $identity;

    /**
     * @description 当前用户已存在的登录方式
     *
     * @example mobile
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'identity' => 'identity',
        'type'     => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res             = [];
        $res['identity'] = $this->identity;
        $res['type']     = $this->type;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LinkInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['identity'])) {
            $model->identity = $map['identity'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
