<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 删除文件请求
 */
class OSSDeleteFileRequest extends Model
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
     * @var string
     */
    public $filePath;
    /**
     * @description permanently
     * type: false
     * @example false
     *
     * @var bool
     */
    public $permanently;
    /**
     * @description share_id
     *
     * @example 3d336314-63c8-4d96-bce0-17aefb6833b6
     *
     * @var string
     */
    public $shareId;
    protected $_name = [
        'driveId'     => 'drive_id',
        'filePath'    => 'file_path',
        'permanently' => 'permanently',
        'shareId'     => 'share_id',
    ];

    public function validate()
    {
        Model::validateField($this->driveId, 'pattern', '[0-9]+');
        Model::validateField($this->shareId, 'pattern', '[0-9a-zA-Z-]+');
        Model::validateField($this->filePath, 'required', true);
        Model::validateField($this->filePath, 'maxLength', 1000);
        Model::validateField($this->filePath, 'minLength', 1);
    }

    public function toMap()
    {
        $res                = [];
        $res['drive_id']    = $this->driveId;
        $res['file_path']   = $this->filePath;
        $res['permanently'] = $this->permanently;
        $res['share_id']    = $this->shareId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSDeleteFileRequest
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
        if (isset($map['permanently'])) {
            $model->permanently = $map['permanently'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }

        return $model;
    }
}
