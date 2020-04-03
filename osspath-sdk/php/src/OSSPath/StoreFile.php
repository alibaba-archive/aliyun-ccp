<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class StoreFile extends Model
{
    /**
     * @var string
     */
    public $domainId;
    /**
     * @var string
     */
    public $name;
    /**
     * @var string
     */
    public $parentFilePath;
    /**
     * @var string
     */
    public $storeId;
    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'domainId'       => 'domain_id',
        'name'           => 'name',
        'parentFilePath' => 'parent_file_path',
        'storeId'        => 'store_id',
        'type'           => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                     = [];
        $res['domain_id']        = $this->domainId;
        $res['name']             = $this->name;
        $res['parent_file_path'] = $this->parentFilePath;
        $res['store_id']         = $this->storeId;
        $res['type']             = $this->type;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StoreFile
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parent_file_path'])) {
            $model->parentFilePath = $map['parent_file_path'];
        }
        if (isset($map['store_id'])) {
            $model->storeId = $map['store_id'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
