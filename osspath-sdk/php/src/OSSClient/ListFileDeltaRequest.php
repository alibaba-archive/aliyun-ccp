<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 获取增量文件操作记录.
 */
class ListFileDeltaRequest extends Model
{
    /**
     * @description cursor 游标
     *
     * @example abc
     *
     * @var string
     */
    public $cursor;
    /**
     * @description drive_id
     *
     * @example 1
     *
     * @var string
     */
    public $driveId;
    /**
     * @description limit
     * default 100
     * @example 100
     *
     * @var int
     */
    public $limit;
    protected $_name = [
        'cursor'  => 'cursor',
        'driveId' => 'drive_id',
        'limit'   => 'limit',
    ];

    public function validate()
    {
        Model::validateField($this->driveId, 'required', true);
        Model::validateField($this->driveId, 'pattern', '[0-9]+');
    }

    public function toMap()
    {
        $res             = [];
        $res['cursor']   = $this->cursor;
        $res['drive_id'] = $this->driveId;
        $res['limit']    = $this->limit;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListFileDeltaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }

        return $model;
    }
}
