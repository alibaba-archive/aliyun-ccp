<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * *
 */
class SetStoreCorsRequest extends Model{
    protected $_required = [
        "corsRule" => true,
        "domainId" => true,
        "storeId" => true,
    ];
    protected $_name = [
        "corsRule" => "cors_rule",
        "domainId" => "domain_id",
        "storeId" => "store_id",
    ];
    protected $_$ref = [
        "corsRule" => "#/definitions/CorsRule",
    ];
    protected $_description = [
        "domainId" => "domain ID",
        "storeId" => "store ID",
    ];
    protected $_example = [
        "domainId" => "sz100",
        "storeId" => "cdjaksbwuiqbxuiassd",
    ];
    public $corsRule;
    public $domainId;
    public $storeId;
}
