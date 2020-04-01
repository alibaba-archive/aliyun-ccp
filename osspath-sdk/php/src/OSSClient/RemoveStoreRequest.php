<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class RemoveStoreRequest extends Model
{
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
        'domainId' => 'domain_id',
        'storeId'  => 'store_id',
    ];

    public function validate()
    {
        Model::validateField($this->domainId, 'required', true);
        Model::validateField($this->storeId, 'required', true);
    }

    public function toMap()
    {
        $res              = [];
        $res['domain_id'] = $this->domainId;
        $res['store_id']  = $this->storeId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveStoreRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['store_id'])) {
            $model->storeId = $map['store_id'];
        }

        return $model;
    }
}
