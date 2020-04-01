<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

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
        Model::validateField($this->driveId, 'required', true);
        Model::validateField($this->fileId, 'required', true);
        Model::validateField($this->driveId, 'pattern', '[0-9]+');
        Model::validateField($this->fileId, 'pattern', '[a-z0-9.-_]{1,50}');
        Model::validateField($this->fileId, 'maxLength', 50);
        Model::validateField($this->fileId, 'minLength', 40);
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
