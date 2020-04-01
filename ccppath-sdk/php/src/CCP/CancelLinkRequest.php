<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class CancelLinkRequest extends Model
{
    public $temporaryToken;
    protected $_required = [
        'temporaryToken' => true,
    ];
    protected $_name = [
        'temporaryToken' => 'temporary_token',
    ];
    protected $_description = [
        'temporaryToken' => '待绑定的临时token，此token只能访问绑定、取消绑定接口',
    ];
    protected $_example = [
        'temporaryToken' => 'ey***s=',
    ];
}
