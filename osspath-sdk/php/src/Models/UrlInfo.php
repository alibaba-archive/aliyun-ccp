<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

class UrlInfo extends Model
{
    /**
     * @description download_url
     *
     * @example https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx
     *
     * @var string
     */
    public $downloadUrl;

    /**
     * @description thumbnail
     *
     * @example https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx
     *
     * @var string
     */
    public $thumbnail;

    /**
     * @description url
     *
     * @example https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'downloadUrl' => 'download_url',
        'thumbnail'   => 'thumbnail',
        'url'         => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                 = [];
        $res['download_url'] = $this->downloadUrl;
        $res['thumbnail']    = $this->thumbnail;
        $res['url']          = $this->url;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UrlInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['download_url'])) {
            $model->downloadUrl = $map['download_url'];
        }
        if (isset($map['thumbnail'])) {
            $model->thumbnail = $map['thumbnail'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
