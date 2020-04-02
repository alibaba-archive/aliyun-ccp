<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 批量删除文件 response.
 */
class OSSDeleteFilesResponse extends Model
{
    /**
     * @description deleted_file_id_list
     *
     * @example
     *
     * @var array
     */
    public $deletedFileIdList;
    /**
     * @description domain_id
     *
     * @example test001
     *
     * @var string
     */
    public $domainId;
    /**
     * @description drive_id
     *
     * @example 1
     *
     * @var string
     */
    public $driveId;
    /**
     * @description share_id
     *
     * @example 1
     *
     * @var string
     */
    public $shareId;
    protected $_name = [
        'deletedFileIdList' => 'deleted_file_id_list',
        'domainId'          => 'domain_id',
        'driveId'           => 'drive_id',
        'shareId'           => 'share_id',
    ];

    public function validate()
    {
        Model::validatePattern('domainId', $this->domainId, '[a-z0-9A-Z]+');
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('shareId', $this->shareId, '[0-9]+');
    }

    public function toMap()
    {
        $res                         = [];
        $res['deleted_file_id_list'] = [];
        if (null !== $this->deletedFileIdList) {
            $res['deleted_file_id_list'] = $this->deletedFileIdList;
        }
        $res['domain_id'] = $this->domainId;
        $res['drive_id']  = $this->driveId;
        $res['share_id']  = $this->shareId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSDeleteFilesResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deleted_file_id_list'])) {
            if (!empty($map['deleted_file_id_list'])) {
                $model->deletedFileIdList = [];
                $model->deletedFileIdList = $map['deleted_file_id_list'];
            }
        }
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }

        return $model;
    }
}
