<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class InnerSignInResponse extends Model
{
    /**
     * @var string
     */
    public $goto;
    protected $_name = [
        'goto' => 'goto',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res         = [];
        $res['goto'] = $this->goto;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InnerSignInResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['goto'])) {
            $model->goto = $map['goto'];
        }

        return $model;
    }
}
