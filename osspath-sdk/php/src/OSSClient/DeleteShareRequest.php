<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * delete share request.
 */
class DeleteShareRequest extends Model
{
    /**
     * @description share_id
     *
     * @example 3d336314-63c8-4d96-bce0-17aefb6833b6
     *
     * @var string
     */
    public $shareId;
    protected $_name = [
        'shareId' => 'share_id',
    ];

    public function validate()
    {
        Model::validateField($this->shareId, 'required', true);
    }

    public function toMap()
    {
        $res             = [];
        $res['share_id'] = $this->shareId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteShareRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }

        return $model;
    }
}
