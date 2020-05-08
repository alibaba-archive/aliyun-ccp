<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件安全地址的请求body.
 */
class OSSGetSecureUrlRequest extends Model
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
     * @description expire_sec 单位秒
     *
     * @example 60
     *
     * @var int
     */
    public $expireSec;

    /**
     * @description file_path
     *
     * @example /a/b/c.jpg
     *
     * @var string
     */
    public $filePath;

    /**
     * @description secure_ip
     *
     * @example 192.168.1.1/24
     *
     * @var string
     */
    public $secureIp;

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
        'filePath'  => 'file_path',
        'secureIp'  => 'secure_ip',
        'shareId'   => 'share_id',
    ];
    protected $_default = [
        'expireSec' => 60,
    ];

    public function validate()
    {
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('shareId', $this->shareId, '[0-9a-zA-Z-]+');
        Model::validateRequired('filePath', $this->filePath, true);
        Model::validateMaxLength('filePath', $this->filePath, 1000);
        Model::validateMinLength('filePath', $this->filePath, 1);
    }

    public function toMap()
    {
        $res               = [];
        $res['drive_id']   = $this->driveId;
        $res['expire_sec'] = $this->expireSec;
        $res['file_path']  = $this->filePath;
        $res['secure_ip']  = $this->secureIp;
        $res['share_id']   = $this->shareId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSGetSecureUrlRequest
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
        if (isset($map['file_path'])) {
            $model->filePath = $map['file_path'];
        }
        if (isset($map['secure_ip'])) {
            $model->secureIp = $map['secure_ip'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }

        return $model;
    }
}
