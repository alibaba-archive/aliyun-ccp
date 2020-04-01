<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\BaseCCPFileResponse;

/**
 * List file response
 */
class CCPListFileResponse extends Model{
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
        "nextMarker" => "NWQ1YmI4MjA0ZGU1ZWNjYzAzODM0ZDVkODlkMWJiMzcyNzM1NTU4OA",
    ];
    protected $_items = [
        "items" => "{"$ref":"#/definitions/BaseCCPFileResponse"}",
    ];
    protected $_maxItems = [
        "items" => 100,
    ];
    public $items;
    public $nextMarker;
}
