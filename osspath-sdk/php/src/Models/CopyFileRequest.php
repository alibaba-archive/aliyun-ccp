<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * 文件移动请求
 */
class CopyFileRequest extends Model
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
     * @description file_id
     *
     * @var string
     */
    public $fileId;

    /**
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
     * @var string
     */
    public $shareId;

    /**
     * @description to_parent_file_id
     *
     * @var string
     */
    public $toParentFileId;

    /**
     * @var string
     */
    public $toParentFilePath;
    protected $_name = [
        'driveId'          => 'drive_id',
        'fileId'           => 'file_id',
        'filePath'         => 'file_path',
        'newName'          => 'new_name',
        'overwrite'        => 'overwrite',
        'shareId'          => 'share_id',
        'toParentFileId'   => 'to_parent_file_id',
        'toParentFilePath' => 'to_parent_file_path',
    ];
    protected $_default = [
        'overwrite' => 'false',
    ];

    public function validate()
    {
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('fileId', $this->fileId, true);
        Model::validateRequired('newName', $this->newName, true);
        Model::validateRequired('toParentFileId', $this->toParentFileId, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9.-_]{1,50}');
        Model::validatePattern('newName', $this->newName, '[a-zA-Z0-9.-]{1,1000}');
        Model::validatePattern('toParentFileId', $this->toParentFileId, '[a-z0-9.-_]{1,50}');
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateMaxLength('toParentFileId', $this->toParentFileId, 50);
        Model::validateMinLength('fileId', $this->fileId, 40);
        Model::validateMinLength('toParentFileId', $this->toParentFileId, 40);
    }

    public function toMap()
    {
        $res                        = [];
        $res['drive_id']            = $this->driveId;
        $res['file_id']             = $this->fileId;
        $res['file_path']           = $this->filePath;
        $res['new_name']            = $this->newName;
        $res['overwrite']           = $this->overwrite;
        $res['share_id']            = $this->shareId;
        $res['to_parent_file_id']   = $this->toParentFileId;
        $res['to_parent_file_path'] = $this->toParentFilePath;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['file_id'])) {
            $model->fileId = $map['file_id'];
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
        if (isset($map['to_parent_file_id'])) {
            $model->toParentFileId = $map['to_parent_file_id'];
        }
        if (isset($map['to_parent_file_path'])) {
            $model->toParentFilePath = $map['to_parent_file_path'];
        }

        return $model;
    }
}
