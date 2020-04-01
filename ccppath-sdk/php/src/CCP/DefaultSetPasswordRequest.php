<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class DefaultSetPasswordRequest extends Model
{
    public $appId;
    public $newPassword;
    public $state;
    protected $_required = [
        'appId'       => true,
        'newPassword' => true,
        'state'       => true,
    ];
    protected $_name = [
        'appId'       => 'app_id',
        'newPassword' => 'new_password',
        'state'       => 'state',
    ];
    protected $_description = [
        'appId'       => 'App ID, 当前访问的App',
        'newPassword' => '新密码，必须包含数字和字母，长度8-32个字符',
        'state'       => '临时操作权限码',
    ];
    protected $_example = [
        'appId'       => 'csaklidwasdhjwid',
        'newPassword' => '123456,abc',
        'state'       => 'abc',
    ];
}
