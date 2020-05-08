<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class CreateAppRequest extends Model
{
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
        'appName'      => 'app_name',
        'description'  => 'description',
        'isThirdParty' => 'is_third_party',
        'logo'         => 'logo',
        'redirectUri'  => 'redirect_uri',
        'scope'        => 'scope',
        'type'         => 'type',
    ];
    protected $_default = [
        'isThirdParty' => 'false',
        'type'         => 'WebServer',
    ];

    public function validate()
    {
        Model::validateRequired('appName', $this->appName, true);
        Model::validateRequired('logo', $this->logo, true);
        Model::validateRequired('scope', $this->scope, true);
        Model::validateRequired('type', $this->type, true);
        Model::validateMaxLength('appName', $this->appName, 128);
        Model::validateMaxLength('description', $this->description, 128);
        Model::validateMinLength('appName', $this->appName, 1);
        Model::validateMinLength('description', $this->description, 0);
    }

    public function toMap()
    {
        $res                   = [];
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
     * @return CreateAppRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
