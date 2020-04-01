<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

use Aliyun\CCP\SDK\CCP\LinkInfo;

/**
 * *
 */
class AccountAccessTokenResponse extends Model{
    protected $_required = [
        "accessToken" => true,
        "needLink" => true,
    ];
    protected $_name = [
        "accessToken" => "access_token",
        "avatar" => "avatar",
        "defaultDriveId" => "default_drive_id",
        "existLink" => "exist_link",
        "expireTime" => "expire_time",
        "expiresIn" => "expires_in",
        "needLink" => "need_link",
        "nickName" => "nick_name",
        "refreshToken" => "refresh_token",
        "role" => "role",
        "state" => "state",
        "tokenType" => "token_type",
        "userId" => "user_id",
        "userName" => "user_name",
    ];
    protected $_description = [
        "accessToken" => "用于调用业务接口的accessToken",
        "avatar" => "当前用户头像",
        "defaultDriveId" => "Default Drive ID",
        "existLink" => "当前用户已存在的登录方式",
        "expireTime" => "accessToken过期时间，ISO时间",
        "expiresIn" => "accessToken过期时间，单位秒",
        "needLink" => "是否需要绑定",
        "nickName" => "当前用户昵称",
        "refreshToken" => "用于刷新accessToken",
        "role" => "当前用户角色",
        "state" => "临时权限，用于登录成功后设置密码",
        "tokenType" => "accessToken类型，Bearer",
        "userId" => "当前用户ID",
        "userName" => "当前用户名",
    ];
    protected $_example = [
        "accessToken" => "cnskjajkahwdhwialsnd",
        "avatar" => "cherry",
        "defaultDriveId" => "100",
        "existLink" => "",
        "expireTime" => "2019-09-01T06:57:48.813Z",
        "expiresIn" => 3600,
        "needLink" => "false",
        "nickName" => "cherry",
        "refreshToken" => "cnskjajkahwdhwialsnd",
        "role" => "user",
        "state" => "klafhjas-asdasd-asd-as-d-asd-asd-asdasd",
        "tokenType" => "Bearer",
        "userId" => "DING-xxxxx",
        "userName" => "cherry",
    ];
    protected $_items = [
        "existLink" => "{"$ref":"#/definitions/LinkInfo"}",
    ];
    protected $_format = [
        "expiresIn" => "int64",
    ];
    public $accessToken;
    public $avatar;
    public $defaultDriveId;
    public $existLink;
    public $expireTime;
    public $expiresIn;
    public $needLink;
    public $nickName;
    public $refreshToken;
    public $role;
    public $state;
    public $tokenType;
    public $userId;
    public $userName;
}
