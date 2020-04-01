<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class TokenRequest extends Model
{
    public $appId;
    public $grantType;
    public $refreshToken;
    protected $_required = [
        'appId'        => true,
        'grantType'    => true,
        'refreshToken' => true,
    ];
    protected $_name = [
        'appId'        => 'app_id',
        'grantType'    => 'grant_type',
        'refreshToken' => 'refresh_token',
    ];
    protected $_description = [
        'appId'        => 'App ID, 当前访问的App',
        'grantType'    => '只能填refresh_token',
        'refreshToken' => 'refresh token, 登录时返回的',
    ];
    protected $_example = [
        'appId'        => 'csaklidwasdhjwid',
        'grantType'    => 'refresh_token',
        'refreshToken' => 'ybb3WJy2CwXHoM6hBcydGlvzMoJkFpkk',
    ];
}
