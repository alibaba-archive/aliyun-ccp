<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * 更新人脸分组信息结果.
 */
class UpdateFaceGroupInfoResponse extends Model
{
    /**
     * @description drive_id
     *
     * @example "101"
     *
     * @var string
     */
    public $driveId;

    /**
     * @description group_id
     *
     * @example "group-aas11002ddeac"
     *
     * @var string
     */
    public $groupId;
    protected $_name = [
        'driveId' => 'drive_id',
        'groupId' => 'group_id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res             = [];
        $res['drive_id'] = $this->driveId;
        $res['group_id'] = $this->groupId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFaceGroupInfoResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['group_id'])) {
            $model->groupId = $map['group_id'];
        }

        return $model;
    }
}
