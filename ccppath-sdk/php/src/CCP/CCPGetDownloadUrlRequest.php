<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件下载地址的请求body.
 */
class CCPGetDownloadUrlRequest extends Model
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
     * @description file_id
     *
     * @var string
     */
    public $fileId;
    /**
     * @description file_name
     *
     * @example ccp.jpg
     *
     * @var string
     */
    public $fileName;
    protected $_name = [
        'driveId'   => 'drive_id',
        'expireSec' => 'expire_sec',
        'fileId'    => 'file_id',
        'fileName'  => 'file_name',
    ];
    protected $_default = [
        'expireSec' => 900,
    ];

    public function validate()
    {
        Model::validateField($this->driveId, 'required', true);
        Model::validateField($this->fileId, 'required', true);
        Model::validateField($this->driveId, 'pattern', '[0-9]+');
        Model::validateField($this->fileId, 'pattern', '[a-z0-9.-_]{1,50}');
        Model::validateField($this->fileName, 'pattern', '.{1,1000}');
        Model::validateField($this->fileId, 'maxLength', 50);
        Model::validateField($this->fileId, 'minLength', 40);
    }

    public function toMap()
    {
        $res               = [];
        $res['drive_id']   = $this->driveId;
        $res['expire_sec'] = $this->expireSec;
        $res['file_id']    = $this->fileId;
        $res['file_name']  = $this->fileName;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPGetDownloadUrlRequest
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
        if (isset($map['file_id'])) {
            $model->fileId = $map['file_id'];
        }
        if (isset($map['file_name'])) {
            $model->fileName = $map['file_name'];
        }

        return $model;
    }
}
