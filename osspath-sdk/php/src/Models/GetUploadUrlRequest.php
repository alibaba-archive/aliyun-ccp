<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件上传URL.
 */
class GetUploadUrlRequest extends Model
{
    /**
     * @description content_md5
     *
     * @var string
     */
    public $contentMd5;

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
     * @var string
     */
    public $fileId;

    /**
     * @var string
     */
    public $filePath;

    /**
     * @description upload_part_list
     *
     * @var array
     */
    public $partInfoList;

    /**
     * @var string
     */
    public $shareId;

    /**
     * @description upload_id
     *
     * @var string
     */
    public $uploadId;
    protected $_name = [
        'contentMd5'   => 'content_md5',
        'driveId'      => 'drive_id',
        'fileId'       => 'file_id',
        'filePath'     => 'file_path',
        'partInfoList' => 'part_info_list',
        'shareId'      => 'share_id',
        'uploadId'     => 'upload_id',
    ];

    public function validate()
    {
        Model::validateMaxLength('contentMd5', $this->contentMd5, 32);
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('fileId', $this->fileId, true);
        Model::validateRequired('uploadId', $this->uploadId, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9]{1,50}');
        Model::validateMinLength('fileId', $this->fileId, 40);
    }

    public function toMap()
    {
        $res                   = [];
        $res['content_md5']    = $this->contentMd5;
        $res['drive_id']       = $this->driveId;
        $res['file_id']        = $this->fileId;
        $res['file_path']      = $this->filePath;
        $res['part_info_list'] = [];
        if (null !== $this->partInfoList && \is_array($this->partInfoList)) {
            $n = 0;
            foreach ($this->partInfoList as $item) {
                $res['part_info_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['share_id']  = $this->shareId;
        $res['upload_id'] = $this->uploadId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUploadUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content_md5'])) {
            $model->contentMd5 = $map['content_md5'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['file_id'])) {
            $model->fileId = $map['file_id'];
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
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }
        if (isset($map['upload_id'])) {
            $model->uploadId = $map['upload_id'];
        }

        return $model;
    }
}
