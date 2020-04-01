<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * Delete drive request.
 */
class DeleteDriveRequest extends Model
{
    /**
     * @description Drive ID
     *
     * @example 123
     *
     * @var string
     */
    public $driveId;
    protected $_name = [
        'driveId' => 'drive_id',
    ];

    public function validate()
    {
        Model::validateField($this->driveId, 'required', true);
    }

    public function toMap()
    {
        $res             = [];
        $res['drive_id'] = $this->driveId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteDriveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }

        return $model;
    }
}
