<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\ImageTagResponse;

/**
 * 展示标签集合
 */
class ListImageTagsResponse extends Model{
    protected $_name = [
        "tags" => "tags",
    ];
    protected $_items = [
        "tags" => "{"$ref":"#/definitions/ImageTagResponse"}",
    ];
    public $tags;
}
