<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 下载文件请求body.
 */
class DownloadRequest extends Model
{
    /**
     * @description drive_id
     *
     * @example 1
     *
     * @var string
     */
    public $DriveID;
    /**
     * @description file_id
     *
     * @var string
     */
    public $FileID;
    /**
     * @description image_process
     *
     * @example image/resize,w_200
     *
     * @var string
     */
    public $ImageProcess;
    /**
     * @var string
     */
    public $ShareID;
    protected $_name = [
        'DriveID'      => 'DriveID',
        'FileID'       => 'FileID',
        'ImageProcess' => 'ImageProcess',
        'ShareID'      => 'ShareID',
    ];

    public function validate()
    {
        Model::validateRequired('DriveID', $this->DriveID, true);
        Model::validateRequired('FileID', $this->FileID, true);
        Model::validatePattern('DriveID', $this->DriveID, '[0-9]+');
        Model::validatePattern('FileID', $this->FileID, '[a-z0-9.-_]{1,50}');
        Model::validateMaxLength('FileID', $this->FileID, 50);
        Model::validateMinLength('FileID', $this->FileID, 40);
    }

    public function toMap()
    {
        $res                 = [];
        $res['DriveID']      = $this->DriveID;
        $res['FileID']       = $this->FileID;
        $res['ImageProcess'] = $this->ImageProcess;
        $res['ShareID']      = $this->ShareID;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DownloadRequest
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
        if (isset($map['ImageProcess'])) {
            $model->ImageProcess = $map['ImageProcess'];
        }
        if (isset($map['ShareID'])) {
            $model->ShareID = $map['ShareID'];
        }

        return $model;
    }
}
