<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * list share request.
 */
class ListShareRequest extends Model
{
    /**
     * @description creator
     *
     * @example tom
     *
     * @var string
     */
    public $creator;
    /**
     * @example 1
     *
     * @var string
     */
    public $driveId;
    /**
     * @description limit
     *
     * @example 50
     *
     * @var int
     */
    public $limit;
    /**
     * @description marker
     *
     * @var string
     */
    public $marker;
    /**
     * @description Owner
     *
     * @example jack
     *
     * @var string
     */
    public $owner;
    /**
     * @description share_file_path
     *
     * @example /a/b/
     *
     * @var string
     */
    public $shareFilePath;
    protected $_name = [
        'creator'       => 'creator',
        'driveId'       => 'drive_id',
        'limit'         => 'limit',
        'marker'        => 'marker',
        'owner'         => 'owner',
        'shareFilePath' => 'share_file_path',
    ];

    public function validate()
    {
        Model::validateField($this->driveId, 'pattern', '[0-9]+');
        Model::validateField($this->limit, 'required', true);
    }

    public function toMap()
    {
        $res                    = [];
        $res['creator']         = $this->creator;
        $res['drive_id']        = $this->driveId;
        $res['limit']           = $this->limit;
        $res['marker']          = $this->marker;
        $res['owner']           = $this->owner;
        $res['share_file_path'] = $this->shareFilePath;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListShareRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['marker'])) {
            $model->marker = $map['marker'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
        }
        if (isset($map['share_file_path'])) {
            $model->shareFilePath = $map['share_file_path'];
        }

        return $model;
    }
}
