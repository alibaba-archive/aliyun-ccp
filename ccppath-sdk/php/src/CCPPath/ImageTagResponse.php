<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCPPath;

use AlibabaCloud\Tea\Model;

class ImageTagResponse extends Model
{
    /**
     * @description 聚类标签计数
     *
     * @example 1
     *
     * @var int
     */
    public $count;
    /**
     * @description 聚类标签封面图片地址
     *
     * @example http://imm-dev-wmt/tags/05.jpg?x-oss-process=xxx
     *
     * @var string
     */
    public $coverUrl;
    /**
     * @description 聚类标签名称
     *
     * @example 篮球
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'count'    => 'count',
        'coverUrl' => 'cover_url',
        'name'     => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res              = [];
        $res['count']     = $this->count;
        $res['cover_url'] = $this->coverUrl;
        $res['name']      = $this->name;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ImageTagResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['cover_url'])) {
            $model->coverUrl = $map['cover_url'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
