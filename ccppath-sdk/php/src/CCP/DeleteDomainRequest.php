<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * delete domain request.
 */
class DeleteDomainRequest extends Model
{
    public $domainId;
    protected $_required = [
        'domainId' => true,
    ];
    protected $_name = [
        'domainId' => 'domain_id',
    ];
    protected $_description = [
        'domainId' => 'Domain ID',
    ];
    protected $_example = [
        'domainId' => 'sz111',
    ];
}
