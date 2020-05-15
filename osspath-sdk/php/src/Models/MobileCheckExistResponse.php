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

    /**
     * @description 国家编号，默认86，不需要填+号，直接填数字
     *
     * @example 86
     *
     * @var string
     */
    public $phoneRegion;
    protected $_name = [
        'isExist'     => 'is_exist',
        'phoneNumber' => 'phone_number',
        'phoneRegion' => 'phone_region',
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
        $res['phone_region'] = $this->phoneRegion;

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
        if (isset($map['phone_region'])) {
            $model->phoneRegion = $map['phone_region'];
        }

        return $model;
    }
}
