<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class AuthorizeRequest extends Model
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
     * @description 鉴权方式，目前支持ding,ram鉴权
     *
     * @example ding
     *
     * @var string
     */
    public $LoginType;

    /**
     * @description 回调地址, 此处填写创建App时填写的回调地址
     *
     * @example https://app.com/callback
     *
     * @var string
     */
    public $RedirectUri;

    /**
     * @description 返回类型, 只能填写code
     *
     * @example code
     *
     * @var string
     */
    public $ResponseType;

    /**
     * @description 申请的权限列表, 默认为所有权限
     *
     * @var array
     */
    public $Scope;

    /**
     * @description 用户自定义字段，会在鉴权成功后的callback带回
     *
     * @var string
     */
    public $State;
    protected $_name = [
        'ClientID'     => 'ClientID',
        'LoginType'    => 'LoginType',
        'RedirectUri'  => 'RedirectUri',
        'ResponseType' => 'ResponseType',
        'Scope'        => 'Scope',
        'State'        => 'State',
    ];
    protected $_default = [
        'LoginType' => 'ding',
    ];

    public function validate()
    {
        Model::validateRequired('ClientID', $this->ClientID, true);
        Model::validateRequired('RedirectUri', $this->RedirectUri, true);
        Model::validateRequired('ResponseType', $this->ResponseType, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['ClientID']     = $this->ClientID;
        $res['LoginType']    = $this->LoginType;
        $res['RedirectUri']  = $this->RedirectUri;
        $res['ResponseType'] = $this->ResponseType;
        $res['Scope']        = [];
        if (null !== $this->Scope) {
            $res['Scope'] = $this->Scope;
        }
        $res['State'] = $this->State;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AuthorizeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ClientID'])) {
            $model->ClientID = $map['ClientID'];
        }
        if (isset($map['LoginType'])) {
            $model->LoginType = $map['LoginType'];
        }
        if (isset($map['RedirectUri'])) {
            $model->RedirectUri = $map['RedirectUri'];
        }
        if (isset($map['ResponseType'])) {
            $model->ResponseType = $map['ResponseType'];
        }
        if (isset($map['Scope'])) {
            if (!empty($map['Scope'])) {
                $model->Scope = [];
                $model->Scope = $map['Scope'];
            }
        }
        if (isset($map['State'])) {
            $model->State = $map['State'];
        }

        return $model;
    }
}
