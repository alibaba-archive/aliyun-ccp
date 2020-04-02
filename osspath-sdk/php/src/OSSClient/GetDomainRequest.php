<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * get domain request.
 */
class GetDomainRequest extends Model
{
    /**
     * @description Domain ID
     *
     * @example sz111
     *
     * @var string
     */
    public $domainId;
    protected $_name = [
        'domainId' => 'domain_id',
    ];

    public function validate()
    {
        Model::validateRequired('domainId', $this->domainId, true);
    }

    public function toMap()
    {
        $res              = [];
        $res['domain_id'] = $this->domainId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDomainRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }

        return $model;
    }
}
