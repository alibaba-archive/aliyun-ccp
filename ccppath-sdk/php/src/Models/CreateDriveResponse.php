<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * Create drive response.
 */
class CreateDriveResponse extends Model
{
    /**
     * @description Domain ID
     *
     * @example hz999
     *
     * @var string
     */
    public $domainId;

    /**
     * @description Drive ID
     *
     * @example 123
     *
     * @var string
     */
    public $driveId;
    protected $_name = [
        'domainId' => 'domain_id',
        'driveId'  => 'drive_id',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res              = [];
        $res['domain_id'] = $this->domainId;
        $res['drive_id']  = $this->driveId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateDriveResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }

        return $model;
    }
}
