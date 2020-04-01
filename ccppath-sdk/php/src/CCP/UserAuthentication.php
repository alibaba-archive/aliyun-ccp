<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class UserAuthentication extends Model
{
    /**
     * @description 认证类型
     *
     * @example mobile
     *
     * @var string
     */
    public $AuthenticationType;
    /**
     * @description 创建时间
     *
     * @example 1556163159820
     *
     * @var int
     */
    public $CreatedAt;
    /**
     * @description 详情
     *
     * @example {name:abc}
     *
     * @var string
     */
    public $Detail;
    /**
     * @description Domain ID
     *
     * @example 5000
     *
     * @var string
     */
    public $DomainID;
    /**
     * @description 唯一身份标识
     *
     * @example 15208345000
     *
     * @var string
     */
    public $Identity;
    /**
     * @description 最后登录时间
     *
     * @example 1556163159820
     *
     * @var int
     */
    public $LastLoginTime;
    /**
     * @description 状态
     *
     * @example normal
     *
     * @var string
     */
    public $Status;
    /**
     * @description 用户ID
     *
     * @example 00016a587b62b50003deea299a4f5b50
     *
     * @var string
     */
    public $UserID;
    protected $_name = [
        'AuthenticationType' => 'AuthenticationType',
        'CreatedAt'          => 'CreatedAt',
        'Detail'             => 'Detail',
        'DomainID'           => 'DomainID',
        'Identity'           => 'Identity',
        'LastLoginTime'      => 'LastLoginTime',
        'Status'             => 'Status',
        'UserID'             => 'UserID',
    ];

    public function validate()
    {
        Model::validateField($this->AuthenticationType, 'required', true);
        Model::validateField($this->CreatedAt, 'required', true);
        Model::validateField($this->Detail, 'required', true);
        Model::validateField($this->DomainID, 'required', true);
        Model::validateField($this->Identity, 'required', true);
        Model::validateField($this->LastLoginTime, 'required', true);
        Model::validateField($this->Status, 'required', true);
        Model::validateField($this->UserID, 'required', true);
    }

    public function toMap()
    {
        $res                       = [];
        $res['AuthenticationType'] = $this->AuthenticationType;
        $res['CreatedAt']          = $this->CreatedAt;
        $res['Detail']             = $this->Detail;
        $res['DomainID']           = $this->DomainID;
        $res['Identity']           = $this->Identity;
        $res['LastLoginTime']      = $this->LastLoginTime;
        $res['Status']             = $this->Status;
        $res['UserID']             = $this->UserID;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UserAuthentication
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['AuthenticationType'])) {
            $model->AuthenticationType = $map['AuthenticationType'];
        }
        if (isset($map['CreatedAt'])) {
            $model->CreatedAt = $map['CreatedAt'];
        }
        if (isset($map['Detail'])) {
            $model->Detail = $map['Detail'];
        }
        if (isset($map['DomainID'])) {
            $model->DomainID = $map['DomainID'];
        }
        if (isset($map['Identity'])) {
            $model->Identity = $map['Identity'];
        }
        if (isset($map['LastLoginTime'])) {
            $model->LastLoginTime = $map['LastLoginTime'];
        }
        if (isset($map['Status'])) {
            $model->Status = $map['Status'];
        }
        if (isset($map['UserID'])) {
            $model->UserID = $map['UserID'];
        }

        return $model;
    }
}
