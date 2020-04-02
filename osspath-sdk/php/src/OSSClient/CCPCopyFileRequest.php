<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 文件拷贝.
 */
class CCPCopyFileRequest extends Model
{
    /**
     * @description auto_rename
     * type: boolean
     * @example false
     *
     * @var bool
     */
    public $autoRename;
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
     * @example 5d5b846942cf94fa72324c14a4bda34e81da635d
     *
     * @var string
     */
    public $fileId;
    /**
     * @description new_name
     *
     * @example ccp.jpg
     *
     * @var string
     */
    public $newName;
    /**
     * @description to_drive_id
     *
     * @example 1
     *
     * @var string
     */
    public $toDriveId;
    /**
     * @description to_parent_file_id
     *
     * @example root
     *
     * @var string
     */
    public $toParentFileId;
    protected $_name = [
        'autoRename'     => 'auto_rename',
        'driveId'        => 'drive_id',
        'fileId'         => 'file_id',
        'newName'        => 'new_name',
        'toDriveId'      => 'to_drive_id',
        'toParentFileId' => 'to_parent_file_id',
    ];
    protected $_default = [
        'autoRename' => 'false',
    ];

    public function validate()
    {
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('fileId', $this->fileId, true);
        Model::validateRequired('toParentFileId', $this->toParentFileId, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9.-_]{1,50}');
        Model::validatePattern('toDriveId', $this->toDriveId, '[0-9]+');
        Model::validatePattern('toParentFileId', $this->toParentFileId, '[a-z0-9.-_]{1,50}');
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateMaxLength('toParentFileId', $this->toParentFileId, 50);
        Model::validateMinLength('fileId', $this->fileId, 40);
        Model::validateMinLength('toParentFileId', $this->toParentFileId, 40);
    }

    public function toMap()
    {
        $res                      = [];
        $res['auto_rename']       = $this->autoRename;
        $res['drive_id']          = $this->driveId;
        $res['file_id']           = $this->fileId;
        $res['new_name']          = $this->newName;
        $res['to_drive_id']       = $this->toDriveId;
        $res['to_parent_file_id'] = $this->toParentFileId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPCopyFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['auto_rename'])) {
            $model->autoRename = $map['auto_rename'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['file_id'])) {
            $model->fileId = $map['file_id'];
        }
        if (isset($map['new_name'])) {
            $model->newName = $map['new_name'];
        }
        if (isset($map['to_drive_id'])) {
            $model->toDriveId = $map['to_drive_id'];
        }
        if (isset($map['to_parent_file_id'])) {
            $model->toParentFileId = $map['to_parent_file_id'];
        }

        return $model;
    }
}
