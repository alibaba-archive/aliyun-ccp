<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\BaseDriveResponse;

/**
 * list drive response
 */
class ListDriveResponse extends Model{
    protected $_name = [
        "items" => "items",
        "nextMarker" => "next_marker",
    ];
    protected $_description = [
        "items" => "Drive 列表",
        "nextMarker" => "翻页标记",
    ];
    protected $_items = [
        "items" => "{"$ref":"#/definitions/BaseDriveResponse"}",
    ];
    protected $_example = [
        "nextMarker" => "marker",
    ];
    public $items;
    public $nextMarker;
}
