<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 获取云照片个数结果.
 */
class GetImageCountResponse extends Model
{
    /**
     * @description image_count
     *
     * @example 1
     *
     * @var int
     */
    public $imageCount;
    protected $_name = [
        'imageCount' => 'image_count',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                = [];
        $res['image_count'] = $this->imageCount;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetImageCountResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['image_count'])) {
            $model->imageCount = $map['image_count'];
        }

        return $model;
    }
}
