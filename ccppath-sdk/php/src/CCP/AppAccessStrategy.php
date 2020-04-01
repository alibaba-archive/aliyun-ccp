<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * *
 */
class AppAccessStrategy extends Model{
    protected $_name = [
        "effect" => "effect",
        "exceptAppIdList" => "except_app_id_list",
    ];
    protected $_items = [
        "exceptAppIdList" => "{"type":"string"}",
    ];
    public $effect;
    public $exceptAppIdList;
}
