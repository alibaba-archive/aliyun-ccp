<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class SetStoreCorsRequest extends Model
{
    /**
     * @var CorsRule
     */
    public $corsRule;

    /**
     * @description domain ID
     *
     * @example sz100
     *
     * @var string
     */
    public $domainId;

    /**
     * @description store ID
     *
     * @example cdjaksbwuiqbxuiassd
     *
     * @var string
     */
    public $storeId;
    protected $_name = [
        'corsRule' => 'cors_rule',
        'domainId' => 'domain_id',
        'storeId'  => 'store_id',
    ];

    public function validate()
    {
        Model::validateRequired('corsRule', $this->corsRule, true);
        Model::validateRequired('domainId', $this->domainId, true);
        Model::validateRequired('storeId', $this->storeId, true);
    }

    public function toMap()
    {
        $res              = [];
        $res['cors_rule'] = null !== $this->corsRule ? $this->corsRule->toMap() : null;
        $res['domain_id'] = $this->domainId;
        $res['store_id']  = $this->storeId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetStoreCorsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cors_rule'])) {
            $model->corsRule = CorsRule::fromMap($map['cors_rule']);
        }
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['store_id'])) {
            $model->storeId = $map['store_id'];
        }

        return $model;
    }
}
