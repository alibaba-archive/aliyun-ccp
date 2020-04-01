<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\ImageAddressResponse;

/**
 * 展示标签集合
 */
class ListImageAddressGroupsResponse extends Model{
    protected $_name = [
        "items" => "items",
        "nextMarker" => "next_marker",
    ];
    protected $_items = [
        "items" => "{"$ref":"#/definitions/ImageAddressResponse"}",
    ];
    public $items;
    public $nextMarker;
}
