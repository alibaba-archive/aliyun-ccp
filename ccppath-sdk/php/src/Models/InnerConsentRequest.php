<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class InnerConsentRequest extends Model
{
    /**
     * @var string
     */
    public $UserCode;
    protected $_name = [
        'UserCode' => 'UserCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res             = [];
        $res['UserCode'] = $this->UserCode;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InnerConsentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['UserCode'])) {
            $model->UserCode = $map['UserCode'];
        }

        return $model;
    }
}
