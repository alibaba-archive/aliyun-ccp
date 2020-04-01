<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * *
 */
class CreateAppRequest extends Model{
    protected $_required = [
        "appName" => true,
        "logo" => true,
        "scope" => true,
        "type" => true,
    ];
    protected $_name = [
        "appName" => "app_name",
        "description" => "description",
        "isThirdParty" => "is_third_party",
        "logo" => "logo",
        "redirectUri" => "redirect_uri",
        "scope" => "scope",
        "type" => "type",
    ];
    protected $_description = [
        "appName" => "App名称",
        "description" => "App描述",
        "isThirdParty" => "是否是domain私有App",
        "logo" => "App图标",
        "redirectUri" => "App回调地址",
        "scope" => "App权限列表",
        "type" => "App类型",
    ];
    protected $_example = [
        "appName" => "图片分享应用",
        "description" => "测试专用",
        "isThirdParty" => "false",
        "logo" => "https://app.com/logo.jpg",
        "redirectUri" => "https://app.com/callback",
        "type" => "WebServer",
    ];
    protected $_maxLength = [
        "appName" => 128,
        "description" => 128,
    ];
    protected $_minLength = [
        "appName" => 1,
        "description" => 0,
    ];
    protected $_default = [
        "isThirdParty" => "false",
        "type" => "WebServer",
    ];
    protected $_enum = [
        "scope" => "FILE.ALL, SHARE.ALL, STORAGEFILE.ALL, STORAGE.ALL, DRIVE.ALL, USER.ALL",
        "type" => "WebServer, WebBrowser, Native",
    ];
    protected $_items = [
        "scope" => "{"type":"string"}",
    ];
    public $appName;
    public $description;
    public $isThirdParty;
    public $logo;
    public $redirectUri;
    public $scope;
    public $type;
}
