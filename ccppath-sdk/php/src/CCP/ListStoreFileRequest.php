<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * list store file.
 */
class ListStoreFileRequest extends Model
{
    public $limit;
    public $marker;
    public $parentFilePath;
    public $storeId;
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
    protected $_description = [
        'limit'          => 'limit',
        'marker'         => 'marker',
        'parentFilePath' => 'parent_file_path',
        'storeId'        => 'store_id',
        'type'           => 'type',
    ];
    protected $_example = [
        'limit'   => 50,
        'storeId' => 'xxx',
        'type'    => 'file',
    ];
    protected $_format = [
        'limit' => 'int64',
    ];
    protected $_maximum = [
        'limit' => 1000,
    ];
    protected $_minimum = [
        'limit' => 1,
    ];
    protected $_enum = [
        'type' => 'file, folder',
    ];
}
