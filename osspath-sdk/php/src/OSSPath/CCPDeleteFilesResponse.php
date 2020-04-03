<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * 批量删除文件 response.
 */
class CCPDeleteFilesResponse extends Model
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
    protected $_name = [
        'deletedFileIdList' => 'deleted_file_id_list',
        'domainId'          => 'domain_id',
        'driveId'           => 'drive_id',
    ];

    public function validate()
    {
        Model::validatePattern('domainId', $this->domainId, '[a-z0-9A-Z]+');
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPDeleteFilesResponse
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

        return $model;
    }
}
