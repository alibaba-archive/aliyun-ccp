<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 获取download url response.
 */
class OSSGetDownloadUrlResponse extends Model
{
    public $expiration;
    public $method;
    public $url;
    protected $_name = [
        'expiration' => 'expiration',
        'method'     => 'method',
        'url'        => 'url',
    ];
    protected $_description = [
        'expiration' => 'expiration',
        'method'     => 'method',
        'url'        => 'url',
    ];
    protected $_example = [
        'expiration' => '2006-01-02T15:04:05.999Z07:00',
        'method'     => 'GET',
        'url'        => 'https://ccp.data.aliyuncs.com/hz22%2F5d79219b0aa9a7c995a94a96993ba3205cd91c5a%2F5d79219bf3261a5d38744da0834ed489b677a27a?Expires=xxxOSSAccessKeyId=xxx&Signature=xxx&response-content-disposition=attachment%3Bfilename%3DtBiZAoJPC2c8b13450eda4292b7f5f8010618e078.txt',
    ];
}
