<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\StoreFile;

/**
 * List storage file
 */
class ListStoreFileResponse extends Model{
    protected $_name = [
        "items" => "items",
        "nextMarker" => "next_marker",
    ];
    protected $_description = [
        "items" => "items
file list",
    ];
    protected $_example = [
        "items" => "",
    ];
    protected $_items = [
        "items" => "{"$ref":"#/definitions/StoreFile"}",
    ];
    public $items;
    public $nextMarker;
}
