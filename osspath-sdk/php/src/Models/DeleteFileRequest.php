<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * 删除文件请求
 */
class DeleteFileRequest extends Model
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
     * @var bool
     */
    public $permanently;

    /**
     * @var string
     */
    public $shareId;
    protected $_name = [
        'driveId'     => 'drive_id',
        'fileId'      => 'file_id',
        'filePath'    => 'file_path',
        'permanently' => 'permanently',
        'shareId'     => 'share_id',
    ];

    public function validate()
    {
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('fileId', $this->fileId, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9.-_]{1,50}');
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateMinLength('fileId', $this->fileId, 40);
    }

    public function toMap()
    {
        $res                = [];
        $res['drive_id']    = $this->driveId;
        $res['file_id']     = $this->fileId;
        $res['file_path']   = $this->filePath;
        $res['permanently'] = $this->permanently;
        $res['share_id']    = $this->shareId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteFileRequest
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
        if (isset($map['permanently'])) {
            $model->permanently = $map['permanently'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }

        return $model;
    }
}
