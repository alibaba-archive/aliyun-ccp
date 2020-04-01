<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\LinkInfoResponse;

/**
 * *
 */
class LinkInfoListResponse extends Model{
    protected $_required = [
        "items" => true,
    ];
    protected $_name = [
        "items" => "items",
    ];
    protected $_description = [
        "items" => "items",
    ];
    protected $_example = [
        "items" => "",
    ];
    protected $_items = [
        "items" => "{"$ref":"#/definitions/LinkInfoResponse"}",
    ];
    public $items;
}
