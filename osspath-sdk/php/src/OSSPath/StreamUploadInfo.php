<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class StreamUploadInfo extends Model
{
    /**
     * @description part_info_list
     *
     * @example [
     *
     * @var array
     */
    public $partInfoList;

    /**
     * @description pre_rapid_upload
     * type: boolean
     * @example false
     *
     * @var bool
     */
    public $preRapidUpload;

    /**
     * @description rapid_upload
     * type: boolean
     * @example false
     *
     * @var bool
     */
    public $rapidUpload;

    /**
     * @description upload_id
     *
     * @example C9DCFE5A82644AC7A02DB74C30C934A6
     *
     * @var string
     */
    public $uploadId;
    protected $_name = [
        'partInfoList'   => 'part_info_list',
        'preRapidUpload' => 'pre_rapid_upload',
        'rapidUpload'    => 'rapid_upload',
        'uploadId'       => 'upload_id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                   = [];
        $res['part_info_list'] = [];
        if (null !== $this->partInfoList && \is_array($this->partInfoList)) {
            $n = 0;
            foreach ($this->partInfoList as $item) {
                $res['part_info_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['pre_rapid_upload'] = $this->preRapidUpload;
        $res['rapid_upload']     = $this->rapidUpload;
        $res['upload_id']        = $this->uploadId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StreamUploadInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['part_info_list'])) {
            if (!empty($map['part_info_list'])) {
                $model->partInfoList = [];
                $n                   = 0;
                foreach ($map['part_info_list'] as $item) {
                    $model->partInfoList[$n++] = null !== $item ? UploadPartInfo::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['pre_rapid_upload'])) {
            $model->preRapidUpload = $map['pre_rapid_upload'];
        }
        if (isset($map['rapid_upload'])) {
            $model->rapidUpload = $map['rapid_upload'];
        }
        if (isset($map['upload_id'])) {
            $model->uploadId = $map['upload_id'];
        }

        return $model;
    }
}
