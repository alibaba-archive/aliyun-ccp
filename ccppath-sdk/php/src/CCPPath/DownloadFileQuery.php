<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCPPath;

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
     * @description image process
     *
     * @example image/resize,w_200
     *
     * @var string
     */
    public $ImageProcess;
    protected $_name = [
        'DriveID'      => 'DriveID',
        'FileID'       => 'FileID',
        'ImageProcess' => 'ImageProcess',
    ];

    public function validate()
    {
        Model::validateRequired('DriveID', $this->DriveID, true);
        Model::validateRequired('FileID', $this->FileID, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['DriveID']      = $this->DriveID;
        $res['FileID']       = $this->FileID;
        $res['ImageProcess'] = $this->ImageProcess;

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
        if (isset($map['ImageProcess'])) {
            $model->ImageProcess = $map['ImageProcess'];
        }

        return $model;
    }
}
