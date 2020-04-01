<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class ImageTagResponse extends Model
{
    public $count;
    public $coverUrl;
    public $name;
    protected $_name = [
        'count'    => 'count',
        'coverUrl' => 'cover_url',
        'name'     => 'name',
    ];
    protected $_description = [
        'count'    => '聚类标签计数',
        'coverUrl' => '聚类标签封面图片地址',
        'name'     => '聚类标签名称',
    ];
    protected $_example = [
        'count'    => 1,
        'coverUrl' => 'http://imm-dev-wmt/tags/05.jpg?x-oss-process=xxx',
        'name'     => '篮球',
    ];
    protected $_format = [
        'count' => 'int64',
    ];
}
