<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * 文件移动请求
 */
class BaseMoveFileRequest extends Model
{
    /**
     * @description drive_id
     *
     * @example 1
     *
     * @var string
     */
    public $driveId;

    /**
     * @description new_name
     *
     * @example ccp.jpg
     *
     * @var string
     */
    public $newName;

    /**
     * @description overwrite
     * type: boolean
     * @example false
     *
     * @var bool
     */
    public $overwrite;
    protected $_name = [
        'driveId'   => 'drive_id',
        'newName'   => 'new_name',
        'overwrite' => 'overwrite',
    ];
    protected $_default = [
        'overwrite' => 'false',
    ];

    public function validate()
    {
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validateMaximum('newName', $this->newName, 1024);
        Model::validateMinimum('newName', $this->newName, 1);
    }

    public function toMap()
    {
        $res              = [];
        $res['drive_id']  = $this->driveId;
        $res['new_name']  = $this->newName;
        $res['overwrite'] = $this->overwrite;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BaseMoveFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['new_name'])) {
            $model->newName = $map['new_name'];
        }
        if (isset($map['overwrite'])) {
            $model->overwrite = $map['overwrite'];
        }

        return $model;
    }
}
