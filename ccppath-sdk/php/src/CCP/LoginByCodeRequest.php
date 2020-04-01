<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class LoginByCodeRequest extends Model
{
    public $accessToken;
    public $appId;
    public $authCode;
    public $type;
    protected $_name = [
        'accessToken' => 'access_token',
        'appId'       => 'app_id',
        'authCode'    => 'auth_code',
        'type'        => 'type',
    ];
    protected $_description = [
        'accessToken' => '鉴权后返回的accessToken，淘宝登录需要此字段',
        'appId'       => 'App ID, 当前访问的App',
        'authCode'    => '鉴权后返回的AuthCode，支付宝登录需要此字段',
        'type'        => '鉴权类型，淘宝、支付宝',
    ];
    protected $_example = [
        'accessToken' => 'csaklidwasdhjwid',
        'appId'       => 'csaklidwasdhjwid',
        'authCode'    => 'csaklidwasdhjwid',
        'type'        => 'taobao',
    ];
    protected $_required = [
        'appId' => true,
        'type'  => true,
    ];
    protected $_enum = [
        'type' => 'taobao, alipay',
    ];
}
