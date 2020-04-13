<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\MGMTClient\MGMTClient;

use AlibabaCloud\Tea\Model;

class GetCorsRuleListRequest extends Model
{
    /**
     * @description domain ID
     *
     * @example sz100
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
     * @return GetCorsRuleListRequest
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
