<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Update drive request.
 */
class UpdateDriveRequest extends Model
{
    public $description;
    public $driveId;
    public $driveName;
    public $encryptDataAccess;
    public $encryptMode;
    public $status;
    public $totalSize;
    protected $_name = [
        'description'       => 'description',
        'driveId'           => 'drive_id',
        'driveName'         => 'drive_name',
        'encryptDataAccess' => 'encrypt_data_access',
        'encryptMode'       => 'encrypt_mode',
        'status'            => 'status',
        'totalSize'         => 'total_size',
    ];
    protected $_description = [
        'description'       => '描述信息',
        'driveId'           => 'Drive ID',
        'driveName'         => 'Drive 名称',
        'encryptDataAccess' => '授权访问加密数据',
        'encryptMode'       => '加密模式',
        'status'            => '状态',
        'totalSize'         => '总大小,单位Byte [如果设置 -1 代表不限制]',
    ];
    protected $_example = [
        'description'       => 'ccp team drive',
        'driveId'           => '123',
        'driveName'         => 'ccpdrive',
        'encryptDataAccess' => 'true',
        'encryptMode'       => 'server',
        'status'            => 'enabled',
        'totalSize'         => 1024,
    ];
    protected $_maximum = [
        'description' => 1024,
        'driveName'   => 1024,
    ];
    protected $_required = [
        'driveId' => true,
    ];
    protected $_default = [
        'encryptDataAccess' => 'false',
        'status'            => 'enabled',
        'totalSize'         => 0,
    ];
    protected $_enum = [
        'status' => 'disabled, enabled',
    ];
    protected $_format = [
        'totalSize' => 'int64',
    ];
}
