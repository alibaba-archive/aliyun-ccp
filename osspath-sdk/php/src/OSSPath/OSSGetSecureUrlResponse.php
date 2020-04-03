<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * 获取secure url response.
 */
class OSSGetSecureUrlResponse extends Model
{
    /**
     * @description expiration
     *
     * @example 2006-01-02T15:04:05.999Z07:00
     *
     * @var string
     */
    public $expiration;
    /**
     * @description url
     *
     * @example https://ccp.data.aliyuncs.com/hz22%2F5d79219b0aa9a7c995a94a96993ba3205cd91c5a%2F5d79219bf3261a5d38744da0834ed489b677a27a?Expires=xxxOSSAccessKeyId=xxx&Signature=xxx&response-content-disposition=attachment%3Bfilename%3DtBiZAoJPC2c8b13450eda4292b7f5f8010618e078.txt
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'expiration' => 'expiration',
        'url'        => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res               = [];
        $res['expiration'] = $this->expiration;
        $res['url']        = $this->url;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSGetSecureUrlResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expiration'])) {
            $model->expiration = $map['expiration'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
