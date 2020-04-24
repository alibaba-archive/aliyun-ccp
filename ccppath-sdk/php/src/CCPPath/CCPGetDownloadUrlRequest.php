<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCPPath;

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
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('fileId', $this->fileId, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9.-_]{1,50}');
        Model::validatePattern('fileName', $this->fileName, '.{1,1000}');
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateMinLength('fileId', $this->fileId, 40);
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
