<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * list domain cors response.
 */
class ListDomainCORSRuleResponse extends Model
{
    /**
     * @description cors rule 列表
     *
     * @var array
     */
    public $corsRuleList;

    /**
     * @description Domain ID
     *
     * @example sz111
     *
     * @var string
     */
    public $domainId;
    protected $_name = [
        'corsRuleList' => 'cors_rule_list',
        'domainId'     => 'domain_id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                   = [];
        $res['cors_rule_list'] = [];
        if (null !== $this->corsRuleList && \is_array($this->corsRuleList)) {
            $n = 0;
            foreach ($this->corsRuleList as $item) {
                $res['cors_rule_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['domain_id'] = $this->domainId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListDomainCORSRuleResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cors_rule_list'])) {
            if (!empty($map['cors_rule_list'])) {
                $model->corsRuleList = [];
                $n                   = 0;
                foreach ($map['cors_rule_list'] as $item) {
                    $model->corsRuleList[$n++] = null !== $item ? CorsRule::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }

        return $model;
    }
}
