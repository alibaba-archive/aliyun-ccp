<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class StreamInfo extends Model
{
    /**
     * @description content_hash
     *
     * @example 7C4A8D09CA3762AF61E59520943DC26494F8941B
     *
     * @var string
     */
    public $contentHash;

    /**
     * @description content_hash_name
     *
     * @example sha1
     *
     * @var string
     */
    public $contentHashName;

    /**
     * @description ContentMd5
     *
     * @example E10ADC3949BA59ABBE56E057F20F883E
     *
     * @var string
     */
    public $contentMd5;

    /**
     * @description part_info_list
     *
     * @var array
     */
    public $partInfoList;

    /**
     * @description pre_hash
     *
     * @example E10ADC3949BA59ABBE56E057F20F883E
     *
     * @var string
     */
    public $preHash;

    /**
     * @description Size
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'contentHash'     => 'content_hash',
        'contentHashName' => 'content_hash_name',
        'contentMd5'      => 'content_md5',
        'partInfoList'    => 'part_info_list',
        'preHash'         => 'pre_hash',
        'size'            => 'size',
    ];

    public function validate()
    {
        Model::validateRequired('contentMd5', $this->contentMd5, true);
        Model::validateRequired('size', $this->size, true);
    }

    public function toMap()
    {
        $res                      = [];
        $res['content_hash']      = $this->contentHash;
        $res['content_hash_name'] = $this->contentHashName;
        $res['content_md5']       = $this->contentMd5;
        $res['part_info_list']    = [];
        if (null !== $this->partInfoList && \is_array($this->partInfoList)) {
            $n = 0;
            foreach ($this->partInfoList as $item) {
                $res['part_info_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['pre_hash'] = $this->preHash;
        $res['size']     = $this->size;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StreamInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content_hash'])) {
            $model->contentHash = $map['content_hash'];
        }
        if (isset($map['content_hash_name'])) {
            $model->contentHashName = $map['content_hash_name'];
        }
        if (isset($map['content_md5'])) {
            $model->contentMd5 = $map['content_md5'];
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
        if (isset($map['pre_hash'])) {
            $model->preHash = $map['pre_hash'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
