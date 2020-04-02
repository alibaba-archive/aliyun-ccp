<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class MobileSendSmsCodeResponse extends Model
{
    /**
     * @description 短信验证码ID
     *
     * @example csjanwia
     *
     * @var string
     */
    public $smsCodeId;
    protected $_name = [
        'smsCodeId' => 'sms_code_id',
    ];

    public function validate()
    {
        Model::validateRequired('smsCodeId', $this->smsCodeId, true);
    }

    public function toMap()
    {
        $res                = [];
        $res['sms_code_id'] = $this->smsCodeId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MobileSendSmsCodeResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sms_code_id'])) {
            $model->smsCodeId = $map['sms_code_id'];
        }

        return $model;
    }
}
