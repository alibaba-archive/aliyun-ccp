<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 文件移动请求
 */
class OSSMoveFileRequest extends Model
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
     * @description file_path
     *
     * @example /a/b/c.jpg
     *
     * @var string
     */
    public $filePath;
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
     * @var bool
     */
    public $overwrite;
    /**
     * @description share_id
     *
     * @example 3d336314-63c8-4d96-bce0-17aefb6833b6
     *
     * @var string
     */
    public $shareId;
    /**
     * @description file_path
     *
     * @example /a/b/c/
     *
     * @var string
     */
    public $toParentFilePath;
    protected $_name = [
        'driveId'          => 'drive_id',
        'filePath'         => 'file_path',
        'newName'          => 'new_name',
        'overwrite'        => 'overwrite',
        'shareId'          => 'share_id',
        'toParentFilePath' => 'to_parent_file_path',
    ];
    protected $_default = [
        'overwrite' => 'false',
    ];

    public function validate()
    {
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('shareId', $this->shareId, '[0-9a-zA-Z-]+');
        Model::validateRequired('newName', $this->newName, true);
    }

    public function toMap()
    {
        $res                        = [];
        $res['drive_id']            = $this->driveId;
        $res['file_path']           = $this->filePath;
        $res['new_name']            = $this->newName;
        $res['overwrite']           = $this->overwrite;
        $res['share_id']            = $this->shareId;
        $res['to_parent_file_path'] = $this->toParentFilePath;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSMoveFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['file_path'])) {
            $model->filePath = $map['file_path'];
        }
        if (isset($map['new_name'])) {
            $model->newName = $map['new_name'];
        }
        if (isset($map['overwrite'])) {
            $model->overwrite = $map['overwrite'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }
        if (isset($map['to_parent_file_path'])) {
            $model->toParentFilePath = $map['to_parent_file_path'];
        }

        return $model;
    }
}
