<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * get domain request.
 */
class GetDomainRequest extends Model
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
