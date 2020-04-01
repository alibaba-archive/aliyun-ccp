<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class RemoveStoreRequest extends Model
{
    public $domainId;
    public $storeId;
    protected $_required = [
        'domainId' => true,
        'storeId'  => true,
    ];
    protected $_name = [
        'domainId' => 'domain_id',
        'storeId'  => 'store_id',
    ];
    protected $_description = [
        'domainId' => 'domain ID',
        'storeId'  => 'store ID',
    ];
    protected $_example = [
        'domainId' => 'sz100',
        'storeId'  => 'cdjaksbwuiqbxuiassd',
    ];
}
