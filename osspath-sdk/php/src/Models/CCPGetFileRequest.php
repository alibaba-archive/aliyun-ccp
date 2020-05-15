<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件元数据.
 */
class CCPGetFileRequest extends Model
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
     * @example 5d5b846942cf94fa72324c14a4bda34e81da635d
     *
     * @var string
     */
    public $fileId;

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
     * @example image/crop,w_100,h_100/rounded-corners,r_10/format,png
     *
     * @var string
     */
    public $imageUrlProcess;

    /**
     * @description url_expire_sec
     *
     * @example 900
     *
     * @var int
     */
    public $urlExpireSec;

    /**
     * @description video_thumbnail_process
     * type:string
     * @example video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast
     *
     * @var string
     */
    public $videoThumbnailProcess;
    protected $_name = [
        'driveId'               => 'drive_id',
        'fileId'                => 'file_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'urlExpireSec'          => 'url_expire_sec',
        'videoThumbnailProcess' => 'video_thumbnail_process',
    ];
    protected $_default = [
        'urlExpireSec' => 900,
    ];

    public function validate()
    {
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('fileId', $this->fileId, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9.-_]{1,50}');
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateMinLength('fileId', $this->fileId, 40);
        Model::validateMaximum('urlExpireSec', $this->urlExpireSec, 14400);
        Model::validateMinimum('urlExpireSec', $this->urlExpireSec, 10);
    }

    public function toMap()
    {
        $res                            = [];
        $res['drive_id']                = $this->driveId;
        $res['file_id']                 = $this->fileId;
        $res['image_thumbnail_process'] = $this->imageThumbnailProcess;
        $res['image_url_process']       = $this->imageUrlProcess;
        $res['url_expire_sec']          = $this->urlExpireSec;
        $res['video_thumbnail_process'] = $this->videoThumbnailProcess;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPGetFileRequest
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
        if (isset($map['image_thumbnail_process'])) {
            $model->imageThumbnailProcess = $map['image_thumbnail_process'];
        }
        if (isset($map['image_url_process'])) {
            $model->imageUrlProcess = $map['image_url_process'];
        }
        if (isset($map['url_expire_sec'])) {
            $model->urlExpireSec = $map['url_expire_sec'];
        }
        if (isset($map['video_thumbnail_process'])) {
            $model->videoThumbnailProcess = $map['video_thumbnail_process'];
        }

        return $model;
    }
}
