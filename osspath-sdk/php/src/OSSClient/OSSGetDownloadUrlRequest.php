<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件下载地址的请求body.
 */
class OSSGetDownloadUrlRequest extends Model
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
     * @description expire_sec
     *
     * @example 15
     *
     * @var int
     */
    public $expireSec;
    /**
     * @description file_name
     *
     * @example ccp.jpg
     *
     * @var string
     */
    public $fileName;
    /**
     * @description file_path
     *
     * @example /a/b/c.jpg
     *
     * @var string
     */
    public $filePath;
    /**
     * @description share_id
     *
     * @example 3d336314-63c8-4d96-bce0-17aefb6833b6
     *
     * @var string
     */
    public $shareId;
    protected $_name = [
        'driveId'   => 'drive_id',
        'expireSec' => 'expire_sec',
        'fileName'  => 'file_name',
        'filePath'  => 'file_path',
        'shareId'   => 'share_id',
    ];
    protected $_default = [
        'expireSec' => 900,
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
        $res               = [];
        $res['drive_id']   = $this->driveId;
        $res['expire_sec'] = $this->expireSec;
        $res['file_name']  = $this->fileName;
        $res['file_path']  = $this->filePath;
        $res['share_id']   = $this->shareId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSGetDownloadUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['expire_sec'])) {
            $model->expireSec = $map['expire_sec'];
        }
        if (isset($map['file_name'])) {
            $model->fileName = $map['file_name'];
        }
        if (isset($map['file_path'])) {
            $model->filePath = $map['file_path'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }

        return $model;
    }
}
