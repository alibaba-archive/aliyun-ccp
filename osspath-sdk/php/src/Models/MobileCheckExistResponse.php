<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class MobileCheckExistResponse extends Model
{
    /**
     * @description 当前手机号是否存在
     *
     * @example true
     *
     * @var bool
     */
    public $isExist;

    /**
     * @description 待查询的手机号
     *
     * @example 152*****341
     *
     * @var string
     */
    public $phoneNumber;
    protected $_name = [
        'isExist'     => 'is_exist',
        'phoneNumber' => 'phone_number',
    ];

    public function validate()
    {
        Model::validateRequired('isExist', $this->isExist, true);
        Model::validateRequired('phoneNumber', $this->phoneNumber, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['is_exist']     = $this->isExist;
        $res['phone_number'] = $this->phoneNumber;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MobileCheckExistResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['is_exist'])) {
            $model->isExist = $map['is_exist'];
        }
        if (isset($map['phone_number'])) {
            $model->phoneNumber = $map['phone_number'];
        }

        return $model;
    }
}
