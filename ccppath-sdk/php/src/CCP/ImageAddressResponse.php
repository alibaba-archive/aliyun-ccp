<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class ImageAddressResponse extends Model
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
        'count'    => '聚类地点计数',
        'coverUrl' => '聚类地点封面图片地址',
        'name'     => '聚类地点名称',
    ];
    protected $_example = [
        'count'    => 1,
        'coverUrl' => 'http://imm-dev-wmt/tags/05.jpg?x-oss-process=xxx',
        'name'     => '杭州',
    ];
    protected $_format = [
        'count' => 'int64',
    ];
}
