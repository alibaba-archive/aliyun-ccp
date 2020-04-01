<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\BaseUserResponse;

/**
 * List user response
 */
class ListUserResponse extends Model{
    protected $_name = [
        "items" => "items",
        "nextMarker" => "next_marker",
    ];
    protected $_items = [
        "items" => "{"$ref":"#/definitions/BaseUserResponse"}",
    ];
    protected $_description = [
        "nextMarker" => "翻页标记",
    ];
    protected $_example = [
        "nextMarker" => "nextmarker",
    ];
    public $items;
    public $nextMarker;
}
