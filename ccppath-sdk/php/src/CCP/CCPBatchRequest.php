<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\BatchSubRequest;

/**
 * 批处理
 */
class CCPBatchRequest extends Model{
    protected $_required = [
        "requests" => true,
        "resource" => true,
    ];
    protected $_name = [
        "requests" => "requests",
        "resource" => "resource",
    ];
    protected $_description = [
        "requests" => "Requests 请求合集",
        "resource" => "支持的资源类型",
    ];
    protected $_items = [
        "requests" => "{"$ref":"#/definitions/BatchSubRequest"}",
    ];
    protected $_example = [
        "resource" => ""file"",
    ];
    public $requests;
    public $resource;
}
