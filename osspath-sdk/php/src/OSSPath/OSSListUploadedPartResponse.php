<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * 获取签名 response.
 */
class OSSListUploadedPartResponse extends Model
{
    /**
     * @description file_path
     *
     * @example /a/b/c.jpg
     *
     * @var string
     */
    public $filePath;

    /**
     * @description next_part_number_marker
     *
     * @example 4
     *
     * @var string
     */
    public $nextPartNumberMarker;

    /**
     * @description upload_id
     *
     * @example F3C25CDFA5C74ECB8DE32672F6211FD4
     *
     * @var string
     */
    public $uploadId;

    /**
     * @description uploaded_parts
     *
     * @example
     *
     * @var array
     */
    public $uploadedParts;
    protected $_name = [
        'filePath'             => 'file_path',
        'nextPartNumberMarker' => 'next_part_number_marker',
        'uploadId'             => 'upload_id',
        'uploadedParts'        => 'uploaded_parts',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                            = [];
        $res['file_path']               = $this->filePath;
        $res['next_part_number_marker'] = $this->nextPartNumberMarker;
        $res['upload_id']               = $this->uploadId;
        $res['uploaded_parts']          = [];
        if (null !== $this->uploadedParts && \is_array($this->uploadedParts)) {
            $n = 0;
            foreach ($this->uploadedParts as $item) {
                $res['uploaded_parts'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSListUploadedPartResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['file_path'])) {
            $model->filePath = $map['file_path'];
        }
        if (isset($map['next_part_number_marker'])) {
            $model->nextPartNumberMarker = $map['next_part_number_marker'];
        }
        if (isset($map['upload_id'])) {
            $model->uploadId = $map['upload_id'];
        }
        if (isset($map['uploaded_parts'])) {
            if (!empty($map['uploaded_parts'])) {
                $model->uploadedParts = [];
                $n                    = 0;
                foreach ($map['uploaded_parts'] as $item) {
                    $model->uploadedParts[$n++] = null !== $item ? UploadPartInfo::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
