<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * 文件拷贝 response.
 */
class OSSCopyFileResponse extends Model
{
    /**
     * @description async_task_id
     *
     * @example 000e89fb-cf8f-11e9-8ab4-b6e980803a3b
     *
     * @var string
     */
    public $asyncTaskId;

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
     * @description drive_id
     *
     * @example test001
     *
     * @var string
     */
    public $shareId;
    protected $_name = [
        'asyncTaskId' => 'async_task_id',
        'domainId'    => 'domain_id',
        'driveId'     => 'drive_id',
        'filePath'    => 'file_path',
        'shareId'     => 'share_id',
    ];

    public function validate()
    {
        Model::validatePattern('domainId', $this->domainId, '[a-z0-9A-Z-]+');
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('shareId', $this->shareId, '[a-z0-9A-Z]+');
    }

    public function toMap()
    {
        $res                  = [];
        $res['async_task_id'] = $this->asyncTaskId;
        $res['domain_id']     = $this->domainId;
        $res['drive_id']      = $this->driveId;
        $res['file_path']     = $this->filePath;
        $res['share_id']      = $this->shareId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSCopyFileResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['async_task_id'])) {
            $model->asyncTaskId = $map['async_task_id'];
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
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }

        return $model;
    }
}
