<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * create drive request.
 */
class CreateDriveRequest extends Model
{
    /**
     * @description 是否默认drive, 只允许设置一个默认drive
     *
     * @example true
     *
     * @var bool
     */
    public $default;
    /**
     * @description 描述信息
     *
     * @example ccp team drive
     *
     * @var string
     */
    public $description;
    /**
     * @description Drive 名称
     *
     * @example ccpdrive
     *
     * @var string
     */
    public $driveName;
    /**
     * @description Drive类型
     *
     * @example normal
     *
     * @var string
     */
    public $driveType;
    /**
     * @var string
     */
    public $encryptMode;
    /**
     * @description 所属者
     *
     * @example ccp-001
     *
     * @var string
     */
    public $owner;
    /**
     * @description domain的PathType为OSSPath时必选。 Drive存储基于store的相对路径
     *
     * @example /d/e/f/
     *
     * @var string
     */
    public $relativePath;
    /**
     * @description 状态
     *
     * @example enabled
     *
     * @var string
     */
    public $status;
    /**
     * @description StoreID , domain的PathType为OSSPath时必选
     *
     * @example store_id
     *
     * @var string
     */
    public $storeId;
    /**
     * @description 总大小,单位Byte [如果设置 -1 代表不限制]
     *
     * @example 1024
     *
     * @var int
     */
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

    public function validate()
    {
        Model::validateRequired('driveName', $this->driveName, true);
        Model::validateRequired('owner', $this->owner, true);
    }

    public function toMap()
    {
        $res                  = [];
        $res['default']       = $this->default;
        $res['description']   = $this->description;
        $res['drive_name']    = $this->driveName;
        $res['drive_type']    = $this->driveType;
        $res['encrypt_mode']  = $this->encryptMode;
        $res['owner']         = $this->owner;
        $res['relative_path'] = $this->relativePath;
        $res['status']        = $this->status;
        $res['store_id']      = $this->storeId;
        $res['total_size']    = $this->totalSize;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateDriveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['default'])) {
            $model->default = $map['default'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['drive_name'])) {
            $model->driveName = $map['drive_name'];
        }
        if (isset($map['drive_type'])) {
            $model->driveType = $map['drive_type'];
        }
        if (isset($map['encrypt_mode'])) {
            $model->encryptMode = $map['encrypt_mode'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
        }
        if (isset($map['relative_path'])) {
            $model->relativePath = $map['relative_path'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['store_id'])) {
            $model->storeId = $map['store_id'];
        }
        if (isset($map['total_size'])) {
            $model->totalSize = $map['total_size'];
        }

        return $model;
    }
}
