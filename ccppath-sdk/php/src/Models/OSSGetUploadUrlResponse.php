<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * Get UploadUrl Response.
 */
class OSSGetUploadUrlResponse extends Model
{
    /**
     * @description created_at
     *
     * @example 2019-09-11T16:34:36.977Z
     *
     * @var string
     */
    public $createAt;

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
     * @description file_path
     *
     * @example /a/b/c.jpg
     *
     * @var string
     */
    public $filePath;

    /**
     * @description part_info_list
     *
     * @example
     *
     * @var array
     */
    public $partInfoList;

    /**
     * @description upload_id
     *
     * @example F3C25CDFA5C74ECB8DE32672F6211FD4
     *
     * @var string
     */
    public $uploadId;
    protected $_name = [
        'createAt'     => 'create_at',
        'domainId'     => 'domain_id',
        'driveId'      => 'drive_id',
        'filePath'     => 'file_path',
        'partInfoList' => 'part_info_list',
        'uploadId'     => 'upload_id',
    ];

    public function validate()
    {
        Model::validatePattern('domainId', $this->domainId, '[a-z0-9A-Z]+');
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
    }

    public function toMap()
    {
        $res                   = [];
        $res['create_at']      = $this->createAt;
        $res['domain_id']      = $this->domainId;
        $res['drive_id']       = $this->driveId;
        $res['file_path']      = $this->filePath;
        $res['part_info_list'] = [];
        if (null !== $this->partInfoList && \is_array($this->partInfoList)) {
            $n = 0;
            foreach ($this->partInfoList as $item) {
                $res['part_info_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['upload_id'] = $this->uploadId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSGetUploadUrlResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['create_at'])) {
            $model->createAt = $map['create_at'];
        }
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['file_path'])) {
            $model->filePath = $map['file_path'];
        }
        if (isset($map['part_info_list'])) {
            if (!empty($map['part_info_list'])) {
                $model->partInfoList = [];
                $n                   = 0;
                foreach ($map['part_info_list'] as $item) {
                    $model->partInfoList[$n++] = null !== $item ? UploadPartInfo::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['upload_id'])) {
            $model->uploadId = $map['upload_id'];
        }

        return $model;
    }
}
