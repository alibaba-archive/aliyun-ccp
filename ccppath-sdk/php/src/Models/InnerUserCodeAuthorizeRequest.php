<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class InnerUserCodeAuthorizeRequest extends Model
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
     * @return InnerUserCodeAuthorizeRequest
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
