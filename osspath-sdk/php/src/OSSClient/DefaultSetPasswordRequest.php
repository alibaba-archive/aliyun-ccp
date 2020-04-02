<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class DefaultSetPasswordRequest extends Model
{
    /**
     * @description App ID, 当前访问的App
     *
     * @example csaklidwasdhjwid
     *
     * @var string
     */
    public $appId;
    /**
     * @description 新密码，必须包含数字和字母，长度8-32个字符
     *
     * @example 123456,abc
     *
     * @var string
     */
    public $newPassword;
    /**
     * @description 临时操作权限码
     *
     * @example abc
     *
     * @var string
     */
    public $state;
    protected $_name = [
        'appId'       => 'app_id',
        'newPassword' => 'new_password',
        'state'       => 'state',
    ];

    public function validate()
    {
        Model::validateRequired('appId', $this->appId, true);
        Model::validateRequired('newPassword', $this->newPassword, true);
        Model::validateRequired('state', $this->state, true);
    }

    public function toMap()
    {
        $res                 = [];
        $res['app_id']       = $this->appId;
        $res['new_password'] = $this->newPassword;
        $res['state']        = $this->state;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DefaultSetPasswordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['app_id'])) {
            $model->appId = $map['app_id'];
        }
        if (isset($map['new_password'])) {
            $model->newPassword = $map['new_password'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }

        return $model;
    }
}
