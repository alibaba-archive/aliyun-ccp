<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * Create share response.
 */
class CreateShareResponse extends Model
{
    /**
     * @description domain_id
     *
     * @example domain-1
     *
     * @var string
     */
    public $domainId;
    /**
     * @description share_id
     *
     * @example 3d336314-63c8-4d96-bce0-17aefb6833b6
     *
     * @var string
     */
    public $shareId;
    protected $_name = [
        'domainId' => 'domain_id',
        'shareId'  => 'share_id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res              = [];
        $res['domain_id'] = $this->domainId;
        $res['share_id']  = $this->shareId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateShareResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }

        return $model;
    }
}
