<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class UpdateAppRequest extends Model
{
    /**
     * @description App ID
     *
     * @example CNMrhxwPJHAReExa
     *
     * @var string
     */
    public $appId;
    /**
     * @description App名称
     *
     * @example 图片分享应用
     *
     * @var string
     */
    public $appName;
    /**
     * @description App描述
     *
     * @example 测试专用
     *
     * @var string
     */
    public $description;
    /**
     * @description 是否是domain私有App
     *
     * @example false
     *
     * @var bool
     */
    public $isThirdParty;
    /**
     * @description App图标
     *
     * @example https://app.com/logo.jpg
     *
     * @var string
     */
    public $logo;
    /**
     * @description App回调地址
     *
     * @example https://app.com/callback
     *
     * @var string
     */
    public $redirectUri;
    /**
     * @description App权限列表
     *
     * @var array
     */
    public $scope;
    /**
     * @description App类型
     *
     * @example WebServer
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'appId'        => 'app_id',
        'appName'      => 'app_name',
        'description'  => 'description',
        'isThirdParty' => 'is_third_party',
        'logo'         => 'logo',
        'redirectUri'  => 'redirect_uri',
        'scope'        => 'scope',
        'type'         => 'type',
    ];
    protected $_default = [
        'type' => 'WebServer',
    ];

    public function validate()
    {
        Model::validateField($this->appId, 'required', true);
        Model::validateField($this->appName, 'required', true);
        Model::validateField($this->isThirdParty, 'required', true);
        Model::validateField($this->logo, 'required', true);
        Model::validateField($this->redirectUri, 'required', true);
        Model::validateField($this->scope, 'required', true);
        Model::validateField($this->type, 'required', true);
        Model::validateField($this->appName, 'maxLength', 128);
        Model::validateField($this->description, 'maxLength', 128);
        Model::validateField($this->appName, 'minLength', 1);
        Model::validateField($this->description, 'minLength', 0);
        Model::validateField($this->appName, 'pattern', '[0-9a-zA-Z]+');
    }

    public function toMap()
    {
        $res                   = [];
        $res['app_id']         = $this->appId;
        $res['app_name']       = $this->appName;
        $res['description']    = $this->description;
        $res['is_third_party'] = $this->isThirdParty;
        $res['logo']           = $this->logo;
        $res['redirect_uri']   = $this->redirectUri;
        $res['scope']          = [];
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }
        $res['type'] = $this->type;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['app_id'])) {
            $model->appId = $map['app_id'];
        }
        if (isset($map['app_name'])) {
            $model->appName = $map['app_name'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['is_third_party'])) {
            $model->isThirdParty = $map['is_third_party'];
        }
        if (isset($map['logo'])) {
            $model->logo = $map['logo'];
        }
        if (isset($map['redirect_uri'])) {
            $model->redirectUri = $map['redirect_uri'];
        }
        if (isset($map['scope'])) {
            if (!empty($map['scope'])) {
                $model->scope = [];
                $model->scope = $map['scope'];
            }
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
