<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * *
 */
class BatchSubRequest extends Model{
    protected $_name = [
        "body" => "body",
        "headers" => "headers",
        "id" => "id",
        "method" => "method",
        "url" => "url",
    ];
    protected $_additionalProperties = [
        "body" => "{"type":"object"}",
        "headers" => "{"type":"string"}",
    ];
    protected $_description = [
        "body" => "body 子请求的请求参数 json 字符串，可参考对于子请求文档, 当指定了body 必须传headers ： "Content-Type" 对应的类型，目前子请求入参是"application/json"",
        "headers" => "headers 请求头，表示body传入数据的类型",
        "id" => "id 用于request 和 response关联， 不允许重复",
        "method" => "method",
        "url" => "url 子请求的api path路径， 可参考对于子请求文档",
    ];
    protected $_example = [
        "body" => "{"drive_id":"101","file_id":"xxxxxx"}",
        "headers" => "{"Content-Type":"application/json"}",
        "id" => ""1"",
        "method" => ""POST"",
        "url" => "/file/get",
    ];
    protected $_required = [
        "id" => true,
        "method" => true,
        "url" => true,
    ];
    protected $_enum = [
        "method" => "POST, GET, PUT, DELETE, HEAD",
    ];
    public $body;
    public $headers;
    public $id;
    public $method;
    public $url;
}
