<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\BatchSubResponse;

/**
 * batch operation response
 */
class CCPBatchResponse extends Model{
    protected $_name = [
        "responses" => "responses",
    ];
    protected $_description = [
        "responses" => "responses 返回结果合集",
    ];
    protected $_items = [
        "responses" => "{"$ref":"#/definitions/BatchSubResponse"}",
    ];
    public $responses;
}
