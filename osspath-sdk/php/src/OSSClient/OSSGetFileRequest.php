<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件元数据.
 */
class OSSGetFileRequest extends Model
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
    public $filePath;
    /**
     * @description image_thumbnail_process
     * type:string
     * @example image/resize,w_200
     *
     * @var string
     */
    public $imageThumbnailProcess;
    /**
     * @description image_thumbnail_process
     * type:string
     * @example image/resize,w_200
     *
     * @var string
     */
    public $imageUrlProcess;
    /**
     * @description share_id
     *
     * @example 3d336314-63c8-4d96-bce0-17aefb6833b6
     *
     * @var string
     */
    public $shareId;
    /**
     * @description url_expire_sec
     *
     * @example 900
     *
     * @var int
     */
    public $urlExpireSec;
    protected $_name = [
        'driveId'               => 'drive_id',
        'filePath'              => 'file_path',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'shareId'               => 'share_id',
        'urlExpireSec'          => 'url_expire_sec',
    ];
    protected $_default = [
        'urlExpireSec' => 900,
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
        $res                            = [];
        $res['drive_id']                = $this->driveId;
        $res['file_path']               = $this->filePath;
        $res['image_thumbnail_process'] = $this->imageThumbnailProcess;
        $res['image_url_process']       = $this->imageUrlProcess;
        $res['share_id']                = $this->shareId;
        $res['url_expire_sec']          = $this->urlExpireSec;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSGetFileRequest
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
        if (isset($map['image_thumbnail_process'])) {
            $model->imageThumbnailProcess = $map['image_thumbnail_process'];
        }
        if (isset($map['image_url_process'])) {
            $model->imageUrlProcess = $map['image_url_process'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }
        if (isset($map['url_expire_sec'])) {
            $model->urlExpireSec = $map['url_expire_sec'];
        }

        return $model;
    }
}
