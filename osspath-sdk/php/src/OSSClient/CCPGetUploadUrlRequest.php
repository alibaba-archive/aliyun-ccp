<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件上传URL.
 */
class CCPGetUploadUrlRequest extends Model
{
    /**
     * @description content_md5
     *
     * @example E10ADC3949BA59ABBE56E057F20F883E
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
     * @description upload_part_list
     *
     * @example
     *
     * @var array
     */
    public $partInfoList;
    /**
     * @description upload_id
     *
     * @example 3920F2BE4D9446D6967E2ED505A97EFD
     *
     * @var string
     */
    public $uploadId;
    /**
     * @description file_id
     *
     * @example 5d5b846942cf94fa72324c14a4bda34e81da635d
     *
     * @var string
     */
    public $fileId;
    protected $_name = [
        'contentMd5'   => 'content_md5',
        'driveId'      => 'drive_id',
        'partInfoList' => 'part_info_list',
        'uploadId'     => 'upload_id',
        'fileId'       => 'file_id',
    ];

    public function validate()
    {
        Model::validateField($this->contentMd5, 'maxLength', 32);
        Model::validateField($this->fileId, 'maxLength', 50);
        Model::validateField($this->driveId, 'pattern', '[0-9]+');
        Model::validateField($this->fileId, 'pattern', '[a-z0-9]{1,50}');
        Model::validateField($this->fileId, 'minLength', 40);
    }

    public function toMap()
    {
        $res                   = [];
        $res['content_md5']    = $this->contentMd5;
        $res['drive_id']       = $this->driveId;
        $res['part_info_list'] = [];
        if (null !== $this->partInfoList && \is_array($this->partInfoList)) {
            $n = 0;
            foreach ($this->partInfoList as $item) {
                $res['part_info_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['upload_id'] = $this->uploadId;
        $res['file_id']   = $this->fileId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPGetUploadUrlRequest
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
        if (isset($map['file_id'])) {
            $model->fileId = $map['file_id'];
        }

        return $model;
    }
}
