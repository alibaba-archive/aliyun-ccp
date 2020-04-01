<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * *
 */
class CorsRule extends Model{
    protected $_name = [
        "allowedHeader" => "allowed_header",
        "allowedMethod" => "allowed_method",
        "allowedOrigin" => "allowed_origin",
        "exposeHeader" => "expose_header",
        "maxAgeSeconds" => "max_age_seconds",
    ];
    protected $_description = [
        "allowedHeader" => "AllowedHeader",
        "allowedMethod" => "AllowedMethod",
        "allowedOrigin" => "AllowedOrigin",
        "exposeHeader" => "ExposeHeader",
        "maxAgeSeconds" => "MaxAgeSeconds",
    ];
    protected $_example = [
        "allowedHeader" => "h*",
        "allowedMethod" => "PUT, GET",
        "allowedOrigin" => "*",
        "exposeHeader" => "ETag",
        "maxAgeSeconds" => 0,
    ];
    protected $_items = [
        "allowedHeader" => "{"type":"string"}",
        "allowedMethod" => "{"type":"string"}",
        "allowedOrigin" => "{"type":"string"}",
        "exposeHeader" => "{"type":"string"}",
    ];
    protected $_format = [
        "maxAgeSeconds" => "int64",
    ];
    public $allowedHeader;
    public $allowedMethod;
    public $allowedOrigin;
    public $exposeHeader;
    public $maxAgeSeconds;
}
