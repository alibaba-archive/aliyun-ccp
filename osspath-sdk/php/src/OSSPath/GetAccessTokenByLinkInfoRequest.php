<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class GetAccessTokenByLinkInfoRequest extends Model
{
    /**
     * @description 唯一身份标识
     *
     * @example 15208333333
     *
     * @var string
     */
    public $identity;
    /**
     * @description 认证类型
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
        Model::validateRequired('identity', $this->identity, true);
        Model::validateRequired('type', $this->type, true);
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
     * @return GetAccessTokenByLinkInfoRequest
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
