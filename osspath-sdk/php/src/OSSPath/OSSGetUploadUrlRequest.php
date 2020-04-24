<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件上传URL.
 */
class OSSGetUploadUrlRequest extends Model
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
     * @description file_path
     *
     * @example /a/b/c.jpg
     *
     * @var string
     */
    public $filePath;

    /**
     * @description share_id
     *
     * @example 1
     *
     * @var string
     */
    public $shareId;
    protected $_name = [
        'contentMd5'   => 'content_md5',
        'driveId'      => 'drive_id',
        'partInfoList' => 'part_info_list',
        'uploadId'     => 'upload_id',
        'filePath'     => 'file_path',
        'shareId'      => 'share_id',
    ];

    public function validate()
    {
        Model::validateMaxLength('contentMd5', $this->contentMd5, 32);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('shareId', $this->shareId, '[0-9a-zA-Z-]+');
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
        $res['file_path'] = $this->filePath;
        $res['share_id']  = $this->shareId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSGetUploadUrlRequest
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
        if (isset($map['file_path'])) {
            $model->filePath = $map['file_path'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }

        return $model;
    }
}
