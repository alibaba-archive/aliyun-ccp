<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\ImageFaceGroupResponse;

/**
 * 展示人脸分组集合
 */
class ListImageFaceGroupsResponse extends Model{
    protected $_name = [
        "items" => "items",
        "nextMarker" => "next_marker",
    ];
    protected $_items = [
        "items" => "{"$ref":"#/definitions/ImageFaceGroupResponse"}",
    ];
    public $items;
    public $nextMarker;
}
