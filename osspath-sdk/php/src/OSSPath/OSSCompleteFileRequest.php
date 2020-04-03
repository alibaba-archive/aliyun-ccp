<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * complete file request.
 */
class OSSCompleteFileRequest extends Model
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
     * @description part_info_list
     *
     * @var array
     */
    public $partInfoList;
    /**
     * @description upload_id
     *
     * @var string
     */
    public $uploadId;
    /**
     * @var string
     */
    public $filePath;
    /**
     * @var string
     */
    public $shareId;
    protected $_name = [
        'driveId'      => 'drive_id',
        'partInfoList' => 'part_info_list',
        'uploadId'     => 'upload_id',
        'filePath'     => 'file_path',
        'shareId'      => 'share_id',
    ];

    public function validate()
    {
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
    }

    public function toMap()
    {
        $res                   = [];
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
     * @return OSSCompleteFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
