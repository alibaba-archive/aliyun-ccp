<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 批量删除文件请求
 */
class CCPDeleteFilesRequest extends Model
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
     * @description file_id_list
     *
     * @example
     *
     * @var array
     */
    public $fileIdList;
    protected $_name = [
        'driveId'    => 'drive_id',
        'fileIdList' => 'file_id_list',
    ];

    public function validate()
    {
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('fileIdList', $this->fileIdList, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
    }

    public function toMap()
    {
        $res                 = [];
        $res['drive_id']     = $this->driveId;
        $res['file_id_list'] = [];
        if (null !== $this->fileIdList) {
            $res['file_id_list'] = $this->fileIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPDeleteFilesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['file_id_list'])) {
            if (!empty($map['file_id_list'])) {
                $model->fileIdList = [];
                $model->fileIdList = $map['file_id_list'];
            }
        }

        return $model;
    }
}
