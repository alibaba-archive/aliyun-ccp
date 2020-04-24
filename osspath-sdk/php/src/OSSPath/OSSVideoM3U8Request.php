<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * 获取视频的m3u8文件.
 */
class OSSVideoM3U8Request extends Model
{
    /**
     * @description definition
     *
     * @example Original
     *
     * @var string
     */
    public $definition;

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
     * @example 60
     *
     * @var int
     */
    public $expireSec;

    /**
     * @description file_path
     *
     * @example /a/b/c.mp4
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

    /**
     * @description sign_token
     *
     * @example a8swq28ue21has22das213eds
     *
     * @var string
     */
    public $signToken;
    protected $_name = [
        'definition' => 'definition',
        'driveId'    => 'drive_id',
        'expireSec'  => 'expire_sec',
        'filePath'   => 'file_path',
        'shareId'    => 'share_id',
        'signToken'  => 'sign_token',
    ];
    protected $_default = [
        'definition' => 'Original',
        'expireSec'  => 60,
    ];

    public function validate()
    {
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('shareId', $this->shareId, '[0-9a-zA-Z-]+');
        Model::validateRequired('filePath', $this->filePath, true);
        Model::validateRequired('signToken', $this->signToken, true);
        Model::validateMaxLength('filePath', $this->filePath, 1000);
        Model::validateMinLength('filePath', $this->filePath, 1);
    }

    public function toMap()
    {
        $res               = [];
        $res['definition'] = $this->definition;
        $res['drive_id']   = $this->driveId;
        $res['expire_sec'] = $this->expireSec;
        $res['file_path']  = $this->filePath;
        $res['share_id']   = $this->shareId;
        $res['sign_token'] = $this->signToken;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSVideoM3U8Request
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['definition'])) {
            $model->definition = $map['definition'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['expire_sec'])) {
            $model->expireSec = $map['expire_sec'];
        }
        if (isset($map['file_path'])) {
            $model->filePath = $map['file_path'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }
        if (isset($map['sign_token'])) {
            $model->signToken = $map['sign_token'];
        }

        return $model;
    }
}
