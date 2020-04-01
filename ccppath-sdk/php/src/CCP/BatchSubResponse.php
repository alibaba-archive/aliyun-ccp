<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * *
 */
class BatchSubResponse extends Model{
    protected $_name = [
        "body" => "body",
        "id" => "id",
        "status" => "status",
    ];
    protected $_additionalProperties = [
        "body" => "{"type":"object"}",
    ];
    protected $_description = [
        "body" => "body 子请求的返回结果，可参考对于子请求文档 json 字符串",
        "id" => "id 请求带过来的id, 可以跟 request 进行关联",
        "status" => "status 子请求的返回状态码，可参考对于子请求文档",
    ];
    protected $_example = [
        "body" => "{"drive_id":"101","file_id":"xxxxxx"}",
        "id" => ""1"",
        "status" => 200,
    ];
    protected $_format = [
        "status" => "int64",
    ];
    public $body;
    public $id;
    public $status;
}
