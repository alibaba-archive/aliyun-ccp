<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 删除文件请求
 */
class CCPDeleteFileRequest extends Model
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
     * @example 5d792010669a1dd91087479e8071c9ae212065cc
     *
     * @var string
     */
    public $fileId;
    /**
     * @description permanently
     * type: false
     * @example false
     *
     * @var bool
     */
    public $permanently;
    protected $_name = [
        'driveId'     => 'drive_id',
        'fileId'      => 'file_id',
        'permanently' => 'permanently',
    ];
    protected $_default = [
        'permanently' => 'false',
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
        $res['permanently'] = $this->permanently;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPDeleteFileRequest
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
        if (isset($map['permanently'])) {
            $model->permanently = $map['permanently'];
        }

        return $model;
    }
}
