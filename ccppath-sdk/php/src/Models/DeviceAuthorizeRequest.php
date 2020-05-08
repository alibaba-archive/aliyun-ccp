<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class DeviceAuthorizeRequest extends Model
{
    /**
     * @description Client ID, 此处填写创建App时返回的AppID
     *
     * @example aksjoiajsoias
     *
     * @var string
     */
    public $ClientID;

    /**
     * @description 设备信息，用于用户识别设备
     *
     * @var string
     */
    public $DeviceInfo;

    /**
     * @description 设备名，实现方需保证不同设备的设备名不重复（推荐用硬件名称+硬件型号作为设备名）
     *
     * @var string
     */
    public $DeviceName;

    /**
     * @description 鉴权方式，目前支持ding,ram鉴权
     *
     * @example ding
     *
     * @var string
     */
    public $LoginType;

    /**
     * @description 申请的权限列表, 默认为所有权限
     *
     * @var array
     */
    public $Scope;
    protected $_name = [
        'ClientID'   => 'ClientID',
        'DeviceInfo' => 'DeviceInfo',
        'DeviceName' => 'DeviceName',
        'LoginType'  => 'LoginType',
        'Scope'      => 'Scope',
    ];
    protected $_default = [
        'LoginType' => 'ding',
    ];

    public function validate()
    {
        Model::validateRequired('ClientID', $this->ClientID, true);
        Model::validateRequired('DeviceName', $this->DeviceName, true);
    }

    public function toMap()
    {
        $res               = [];
        $res['ClientID']   = $this->ClientID;
        $res['DeviceInfo'] = $this->DeviceInfo;
        $res['DeviceName'] = $this->DeviceName;
        $res['LoginType']  = $this->LoginType;
        $res['Scope']      = [];
        if (null !== $this->Scope) {
            $res['Scope'] = $this->Scope;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeviceAuthorizeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ClientID'])) {
            $model->ClientID = $map['ClientID'];
        }
        if (isset($map['DeviceInfo'])) {
            $model->DeviceInfo = $map['DeviceInfo'];
        }
        if (isset($map['DeviceName'])) {
            $model->DeviceName = $map['DeviceName'];
        }
        if (isset($map['LoginType'])) {
            $model->LoginType = $map['LoginType'];
        }
        if (isset($map['Scope'])) {
            if (!empty($map['Scope'])) {
                $model->Scope = [];
                $model->Scope = $map['Scope'];
            }
        }

        return $model;
    }
}
