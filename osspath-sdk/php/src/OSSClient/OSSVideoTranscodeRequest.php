<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 启动视频转码请求
 */
class OSSVideoTranscodeRequest extends Model
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
     * @example /a/b/c.mp4
     *
     * @var string
     */
    public $filePath;
    /**
     * @description hls_time
     *
     * @example 10
     *
     * @var int
     */
    public $hlsTime;
    /**
     * @description remarks
     *
     * @example {"userID":"xxx"}
     *
     * @var string
     */
    public $remarks;
    /**
     * @description share_id
     *
     * @example 3d336314-63c8-4d96-bce0-17aefb6833b6
     *
     * @var string
     */
    public $shareId;
    /**
     * @description transcode
     *
     * @example true
     *
     * @var bool
     */
    public $transcode;
    protected $_name = [
        'driveId'   => 'drive_id',
        'filePath'  => 'file_path',
        'hlsTime'   => 'hls_time',
        'remarks'   => 'remarks',
        'shareId'   => 'share_id',
        'transcode' => 'transcode',
    ];
    protected $_default = [
        'transcode' => 'false',
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
        $res              = [];
        $res['drive_id']  = $this->driveId;
        $res['file_path'] = $this->filePath;
        $res['hls_time']  = $this->hlsTime;
        $res['remarks']   = $this->remarks;
        $res['share_id']  = $this->shareId;
        $res['transcode'] = $this->transcode;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSVideoTranscodeRequest
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
        if (isset($map['hls_time'])) {
            $model->hlsTime = $map['hls_time'];
        }
        if (isset($map['remarks'])) {
            $model->remarks = $map['remarks'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }
        if (isset($map['transcode'])) {
            $model->transcode = $map['transcode'];
        }

        return $model;
    }
}
