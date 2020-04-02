<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Get drive request.
 */
class GetDriveRequest extends Model
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
        Model::validateRequired('driveId', $this->driveId, true);
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
     * @return GetDriveRequest
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
