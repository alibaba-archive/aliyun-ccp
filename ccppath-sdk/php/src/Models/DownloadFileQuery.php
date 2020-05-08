<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class DownloadFileQuery extends Model
{
    /**
     * @description drive id
     *
     * @example 1
     *
     * @var string
     */
    public $DriveID;

    /**
     * @description file id
     *
     * @example 5d79206586bb5dd69fb34c349282718146c55da7
     *
     * @var string
     */
    public $FileID;

    /**
     * @description image_thumbnail_process
     *
     * @example image/resize,m_fill,h_128,w_128,limit_0
     *
     * @var string
     */
    public $ImageThumbnailProcess;

    /**
     * @description video_thumbnail_process
     * type:string
     * @example video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast
     *
     * @var string
     */
    public $VideoThumbnailProcess;
    protected $_name = [
        'DriveID'               => 'DriveID',
        'FileID'                => 'FileID',
        'ImageThumbnailProcess' => 'ImageThumbnailProcess',
        'VideoThumbnailProcess' => 'VideoThumbnailProcess',
    ];

    public function validate()
    {
        Model::validateRequired('DriveID', $this->DriveID, true);
        Model::validateRequired('FileID', $this->FileID, true);
    }

    public function toMap()
    {
        $res                          = [];
        $res['DriveID']               = $this->DriveID;
        $res['FileID']                = $this->FileID;
        $res['ImageThumbnailProcess'] = $this->ImageThumbnailProcess;
        $res['VideoThumbnailProcess'] = $this->VideoThumbnailProcess;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DownloadFileQuery
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['DriveID'])) {
            $model->DriveID = $map['DriveID'];
        }
        if (isset($map['FileID'])) {
            $model->FileID = $map['FileID'];
        }
        if (isset($map['ImageThumbnailProcess'])) {
            $model->ImageThumbnailProcess = $map['ImageThumbnailProcess'];
        }
        if (isset($map['VideoThumbnailProcess'])) {
            $model->VideoThumbnailProcess = $map['VideoThumbnailProcess'];
        }

        return $model;
    }
}
