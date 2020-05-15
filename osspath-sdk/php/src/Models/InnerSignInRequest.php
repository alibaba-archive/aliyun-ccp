<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class InnerSignInRequest extends Model
{
    /**
     * @var string
     */
    public $keyPairId;

    /**
     * @var string
     */
    public $password;

    /**
     * @var string
     */
    public $phoneNumber;

    /**
     * @var string
     */
    public $phoneRegion;

    /**
     * @var string
     */
    public $signInType;

    /**
     * @var string
     */
    public $smsCode;

    /**
     * @var string
     */
    public $smsCodeId;
    protected $_name = [
        'keyPairId'   => 'key_pair_id',
        'password'    => 'password',
        'phoneNumber' => 'phone_number',
        'phoneRegion' => 'phone_region',
        'signInType'  => 'sign_in_type',
        'smsCode'     => 'sms_code',
        'smsCodeId'   => 'sms_code_id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                 = [];
        $res['key_pair_id']  = $this->keyPairId;
        $res['password']     = $this->password;
        $res['phone_number'] = $this->phoneNumber;
        $res['phone_region'] = $this->phoneRegion;
        $res['sign_in_type'] = $this->signInType;
        $res['sms_code']     = $this->smsCode;
        $res['sms_code_id']  = $this->smsCodeId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InnerSignInRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['key_pair_id'])) {
            $model->keyPairId = $map['key_pair_id'];
        }
        if (isset($map['password'])) {
            $model->password = $map['password'];
        }
        if (isset($map['phone_number'])) {
            $model->phoneNumber = $map['phone_number'];
        }
        if (isset($map['phone_region'])) {
            $model->phoneRegion = $map['phone_region'];
        }
        if (isset($map['sign_in_type'])) {
            $model->signInType = $map['sign_in_type'];
        }
        if (isset($map['sms_code'])) {
            $model->smsCode = $map['sms_code'];
        }
        if (isset($map['sms_code_id'])) {
            $model->smsCodeId = $map['sms_code_id'];
        }

        return $model;
    }
}
