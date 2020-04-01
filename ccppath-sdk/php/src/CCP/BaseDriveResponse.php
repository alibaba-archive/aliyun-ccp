<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Base drive response.
 */
class BaseDriveResponse extends Model
{
    public $creator;
    public $description;
    public $domainId;
    public $driveId;
    public $driveName;
    public $driveType;
    public $owner;
    public $relativePath;
    public $status;
    public $storeId;
    public $totalSize;
    public $usedSize;
    protected $_name = [
        'creator'      => 'creator',
        'description'  => 'description',
        'domainId'     => 'domain_id',
        'driveId'      => 'drive_id',
        'driveName'    => 'drive_name',
        'driveType'    => 'drive_type',
        'owner'        => 'owner',
        'relativePath' => 'relative_path',
        'status'       => 'status',
        'storeId'      => 'store_id',
        'totalSize'    => 'total_size',
        'usedSize'     => 'used_size',
    ];
    protected $_description = [
        'creator'      => 'Drive 创建者',
        'description'  => 'Drive 备注信息',
        'domainId'     => 'Domain ID',
        'driveId'      => 'Drive ID',
        'driveName'    => 'Drive 名称',
        'driveType'    => 'Drive 类型',
        'owner'        => 'Drive 所有者',
        'relativePath' => 'Drive存储基于store的相对路径，domain的PathType为OSSPath时返回',
        'status'       => 'Drive 状态',
        'storeId'      => '存储 ID, domain的PathType为OSSPath时返回',
        'totalSize'    => 'Drive 空间总量',
        'usedSize'     => 'Drive 空间已使用量',
    ];
    protected $_example = [
        'creator'      => 'ccp',
        'description'  => 'ccp team drive',
        'domainId'     => 'hz999',
        'driveId'      => '123',
        'driveName'    => 'ccpdrive',
        'driveType'    => 'normal',
        'owner'        => 'ccp',
        'relativePath' => '/a/b/e/',
        'status'       => 'enabled',
        'storeId'      => '123',
        'totalSize'    => 102400,
        'usedSize'     => 1024,
    ];
    protected $_format = [
        'totalSize' => 'int64',
        'usedSize'  => 'int64',
    ];
}
