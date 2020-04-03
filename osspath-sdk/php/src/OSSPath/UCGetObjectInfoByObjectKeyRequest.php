<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * UCGetObjectInfoByObjectKeyRequest.
 */
class UCGetObjectInfoByObjectKeyRequest extends Model
{
    /**
     * @var string
     */
    public $objectKey;
    protected $_name = [
        'objectKey' => 'object_key',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res               = [];
        $res['object_key'] = $this->objectKey;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UCGetObjectInfoByObjectKeyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['object_key'])) {
            $model->objectKey = $map['object_key'];
        }

        return $model;
    }
}
