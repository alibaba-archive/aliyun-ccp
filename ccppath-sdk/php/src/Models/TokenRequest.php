<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class TokenRequest extends Model
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
     * @description 只能填refresh_token
     *
     * @example refresh_token
     *
     * @var string
     */
    public $grantType;

    /**
     * @description refresh token, 登录时返回的
     *
     * @example ybb3WJy2CwXHoM6hBcydGlvzMoJkFpkk
     *
     * @var string
     */
    public $refreshToken;
    protected $_name = [
        'appId'        => 'app_id',
        'grantType'    => 'grant_type',
        'refreshToken' => 'refresh_token',
    ];

    public function validate()
    {
        Model::validateRequired('appId', $this->appId, true);
        Model::validateRequired('grantType', $this->grantType, true);
        Model::validateRequired('refreshToken', $this->refreshToken, true);
    }

    public function toMap()
    {
        $res                  = [];
        $res['app_id']        = $this->appId;
        $res['grant_type']    = $this->grantType;
        $res['refresh_token'] = $this->refreshToken;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['app_id'])) {
            $model->appId = $map['app_id'];
        }
        if (isset($map['grant_type'])) {
            $model->grantType = $map['grant_type'];
        }
        if (isset($map['refresh_token'])) {
            $model->refreshToken = $map['refresh_token'];
        }

        return $model;
    }
}
