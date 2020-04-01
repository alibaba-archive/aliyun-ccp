<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * create drive request.
 */
class CreateDriveRequest extends Model
{
    public $default;
    public $description;
    public $driveName;
    public $driveType;
    public $encryptMode;
    public $owner;
    public $relativePath;
    public $status;
    public $storeId;
    public $totalSize;
    protected $_name = [
        'default'      => 'default',
        'description'  => 'description',
        'driveName'    => 'drive_name',
        'driveType'    => 'drive_type',
        'encryptMode'  => 'encrypt_mode',
        'owner'        => 'owner',
        'relativePath' => 'relative_path',
        'status'       => 'status',
        'storeId'      => 'store_id',
        'totalSize'    => 'total_size',
    ];
    protected $_default = [
        'default'   => 'false',
        'driveType' => 'normal',
        'status'    => 'enabled',
        'totalSize' => -1,
    ];
    protected $_description = [
        'default'      => '是否默认drive, 只允许设置一个默认drive',
        'description'  => '描述信息',
        'driveName'    => 'Drive 名称',
        'driveType'    => 'Drive类型',
        'owner'        => '所属者',
        'relativePath' => 'domain的PathType为OSSPath时必选。 Drive存储基于store的相对路径',
        'status'       => '状态',
        'storeId'      => 'StoreID , domain的PathType为OSSPath时必选',
        'totalSize'    => '总大小,单位Byte [如果设置 -1 代表不限制]',
    ];
    protected $_example = [
        'default'      => 'true',
        'description'  => 'ccp team drive',
        'driveName'    => 'ccpdrive',
        'driveType'    => 'normal',
        'owner'        => 'ccp-001',
        'relativePath' => '/d/e/f/',
        'status'       => 'enabled',
        'storeId'      => 'store_id',
        'totalSize'    => 1024,
    ];
    protected $_maximum = [
        'description' => 1024,
        'driveName'   => 1024,
    ];
    protected $_required = [
        'driveName' => true,
        'owner'     => true,
    ];
    protected $_enum = [
        'driveType' => 'normal, large',
        'status'    => 'disabled, enabled',
    ];
    protected $_format = [
        'totalSize' => 'int64',
    ];
}
