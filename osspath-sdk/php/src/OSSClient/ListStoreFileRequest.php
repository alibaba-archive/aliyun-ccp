<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * list store file.
 */
class ListStoreFileRequest extends Model
{
    /**
     * @description limit
     *
     * @example 50
     *
     * @var int
     */
    public $limit;
    /**
     * @description marker
     *
     * @var string
     */
    public $marker;
    /**
     * @description parent_file_path
     *
     * @var string
     */
    public $parentFilePath;
    /**
     * @description store_id
     *
     * @example xxx
     *
     * @var string
     */
    public $storeId;
    /**
     * @description type
     *
     * @example file
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'limit'          => 'limit',
        'marker'         => 'marker',
        'parentFilePath' => 'parent_file_path',
        'storeId'        => 'store_id',
        'type'           => 'type',
    ];
    protected $_default = [
        'limit' => 100,
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                     = [];
        $res['limit']            = $this->limit;
        $res['marker']           = $this->marker;
        $res['parent_file_path'] = $this->parentFilePath;
        $res['store_id']         = $this->storeId;
        $res['type']             = $this->type;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListStoreFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['marker'])) {
            $model->marker = $map['marker'];
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
