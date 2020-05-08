<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class GetAppResponse extends Model
{
    /**
     * @description App 拥有者
     *
     * @example 172***430
     *
     * @var string
     */
    public $aliOwnerId;

    /**
     * @description App ID
     *
     * @example cksaljkfiwasdn
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
     * @description App 秘钥
     *
     * @example sax***Js9
     *
     * @var string
     */
    public $appSecret;

    /**
     * @description App 创建时间
     *
     * @example "2019-08-31T12:58:31.137Z"
     *
     * @var string
     */
    public $createdAt;

    /**
     * @description App描述
     *
     * @example 测试专用
     *
     * @var string
     */
    public $description;

    /**
     * @description App图标
     *
     * @example https://app.com/logo.jpg
     *
     * @var string
     */
    public $logo;

    /**
     * @description App 提供方
     *
     * @example Alibaba Inc.
     *
     * @var string
     */
    public $provider;

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
     * @description App 屏幕截图
     *
     * @example http://app.com/screenshot_1.jpg
     *
     * @var array
     */
    public $screenshots;

    /**
     * @description App 当前阶段
     *
     * @example UnPublished
     *
     * @var string
     */
    public $stage;

    /**
     * @description App类型
     *
     * @example WebServer
     *
     * @var string
     */
    public $type;

    /**
     * @description App 修改时间
     *
     * @example "2019-08-31T12:58:31.137Z"
     *
     * @var string
     */
    public $updatedAt;
    protected $_name = [
        'aliOwnerId'  => 'ali_owner_id',
        'appId'       => 'app_id',
        'appName'     => 'app_name',
        'appSecret'   => 'app_secret',
        'createdAt'   => 'created_at',
        'description' => 'description',
        'logo'        => 'logo',
        'provider'    => 'provider',
        'redirectUri' => 'redirect_uri',
        'scope'       => 'scope',
        'screenshots' => 'screenshots',
        'stage'       => 'stage',
        'type'        => 'type',
        'updatedAt'   => 'updated_at',
    ];
    protected $_default = [
        'stage' => 'UnPublished,Pending,Published',
        'type'  => 'WebServer',
    ];

    public function validate()
    {
        Model::validateRequired('aliOwnerId', $this->aliOwnerId, true);
        Model::validateRequired('appId', $this->appId, true);
        Model::validateRequired('appName', $this->appName, true);
        Model::validateRequired('appSecret', $this->appSecret, true);
        Model::validateRequired('createdAt', $this->createdAt, true);
        Model::validateRequired('description', $this->description, true);
        Model::validateRequired('logo', $this->logo, true);
        Model::validateRequired('provider', $this->provider, true);
        Model::validateRequired('redirectUri', $this->redirectUri, true);
        Model::validateRequired('scope', $this->scope, true);
        Model::validateRequired('screenshots', $this->screenshots, true);
        Model::validateRequired('stage', $this->stage, true);
        Model::validateRequired('type', $this->type, true);
        Model::validateRequired('updatedAt', $this->updatedAt, true);
        Model::validateMaxLength('appName', $this->appName, 128);
        Model::validateMaxLength('description', $this->description, 128);
        Model::validateMinLength('appName', $this->appName, 1);
        Model::validateMinLength('description', $this->description, 0);
        Model::validatePattern('appName', $this->appName, '[0-9a-zA-Z]+');
    }

    public function toMap()
    {
        $res                 = [];
        $res['ali_owner_id'] = $this->aliOwnerId;
        $res['app_id']       = $this->appId;
        $res['app_name']     = $this->appName;
        $res['app_secret']   = $this->appSecret;
        $res['created_at']   = $this->createdAt;
        $res['description']  = $this->description;
        $res['logo']         = $this->logo;
        $res['provider']     = $this->provider;
        $res['redirect_uri'] = $this->redirectUri;
        $res['scope']        = [];
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }
        $res['screenshots'] = [];
        if (null !== $this->screenshots) {
            $res['screenshots'] = $this->screenshots;
        }
        $res['stage']      = $this->stage;
        $res['type']       = $this->type;
        $res['updated_at'] = $this->updatedAt;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAppResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ali_owner_id'])) {
            $model->aliOwnerId = $map['ali_owner_id'];
        }
        if (isset($map['app_id'])) {
            $model->appId = $map['app_id'];
        }
        if (isset($map['app_name'])) {
            $model->appName = $map['app_name'];
        }
        if (isset($map['app_secret'])) {
            $model->appSecret = $map['app_secret'];
        }
        if (isset($map['created_at'])) {
            $model->createdAt = $map['created_at'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['logo'])) {
            $model->logo = $map['logo'];
        }
        if (isset($map['provider'])) {
            $model->provider = $map['provider'];
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
        if (isset($map['screenshots'])) {
            if (!empty($map['screenshots'])) {
                $model->screenshots = [];
                $model->screenshots = $map['screenshots'];
            }
        }
        if (isset($map['stage'])) {
            $model->stage = $map['stage'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['updated_at'])) {
            $model->updatedAt = $map['updated_at'];
        }

        return $model;
    }
}
