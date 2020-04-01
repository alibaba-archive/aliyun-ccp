<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class RuntimeOptions extends Model
{
    public $autoretry;
    public $ignoreSSL;
    public $maxAttempts;
    public $backoffPolicy;
    public $backoffPeriod;
    public $readTimeout;
    public $connectTimeout;
    public $httpProxy;
    public $httpsProxy;
    public $noProxy;
    public $maxIdleConns;
    public $localAddr;
    public $socks5Proxy;
    public $socks5NetWork;
    protected $_description = [
        'autoretry'      => 'whether to try again',
        'ignoreSSL'      => 'ignore SSL validation',
        'maxAttempts'    => 'maximum number of retries',
        'backoffPolicy'  => 'backoff policy',
        'backoffPeriod'  => 'backoff period',
        'readTimeout'    => 'read timeout',
        'connectTimeout' => 'connect timeout',
        'httpProxy'      => 'http proxy url',
        'httpsProxy'     => 'https Proxy url',
        'noProxy'        => 'agent blacklist',
        'maxIdleConns'   => 'maximum number of connections',
        'localAddr'      => 'local addr',
        'socks5Proxy'    => 'SOCKS5 proxy',
        'socks5NetWork'  => 'SOCKS5 netWork',
    ];
    protected $_name = [
        'autoretry'      => 'autoretry',
        'ignoreSSL'      => 'ignoreSSL',
        'maxAttempts'    => 'maxAttempts',
        'backoffPolicy'  => 'backoffPolicy',
        'backoffPeriod'  => 'backoffPeriod',
        'readTimeout'    => 'readTimeout',
        'connectTimeout' => 'connectTimeout',
        'httpProxy'      => 'httpProxy',
        'httpsProxy'     => 'httpsProxy',
        'noProxy'        => 'noProxy',
        'maxIdleConns'   => 'maxIdleConns',
        'localAddr'      => 'localAddr',
        'socks5Proxy'    => 'socks5Proxy',
        'socks5NetWork'  => 'socks5NetWork',
    ];
}
