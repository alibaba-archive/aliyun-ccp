<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\BaseShareResponse;

/**
 * List share response
 */
class ListShareResponse extends Model{
    protected $_name = [
        "items" => "items",
        "nextMarker" => "next_marker",
    ];
    protected $_description = [
        "items" => "items",
        "nextMarker" => "next_marker",
    ];
    protected $_example = [
        "items" => "",
    ];
    protected $_items = [
        "items" => "{"$ref":"#/definitions/BaseShareResponse"}",
    ];
    public $items;
    public $nextMarker;
}
