<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class RuntimeOptions extends Model
{
    /**
     * @description whether to try again
     *
     * @var bool
     */
    public $autoretry;
    /**
     * @description ignore SSL validation
     *
     * @var bool
     */
    public $ignoreSSL;
    /**
     * @description maximum number of retries
     *
     * @var int
     */
    public $maxAttempts;
    /**
     * @description backoff policy
     *
     * @var string
     */
    public $backoffPolicy;
    /**
     * @description backoff period
     *
     * @var int
     */
    public $backoffPeriod;
    /**
     * @description read timeout
     *
     * @var int
     */
    public $readTimeout;
    /**
     * @description connect timeout
     *
     * @var int
     */
    public $connectTimeout;
    /**
     * @description http proxy url
     *
     * @var string
     */
    public $httpProxy;
    /**
     * @description https Proxy url
     *
     * @var string
     */
    public $httpsProxy;
    /**
     * @description agent blacklist
     *
     * @var string
     */
    public $noProxy;
    /**
     * @description maximum number of connections
     *
     * @var int
     */
    public $maxIdleConns;
    /**
     * @description local addr
     *
     * @var string
     */
    public $localAddr;
    /**
     * @description SOCKS5 proxy
     *
     * @var string
     */
    public $socks5Proxy;
    /**
     * @description SOCKS5 netWork
     *
     * @var string
     */
    public $socks5NetWork;
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

    public function validate()
    {
    }

    public function toMap()
    {
        $res                   = [];
        $res['autoretry']      = $this->autoretry;
        $res['ignoreSSL']      = $this->ignoreSSL;
        $res['maxAttempts']    = $this->maxAttempts;
        $res['backoffPolicy']  = $this->backoffPolicy;
        $res['backoffPeriod']  = $this->backoffPeriod;
        $res['readTimeout']    = $this->readTimeout;
        $res['connectTimeout'] = $this->connectTimeout;
        $res['httpProxy']      = $this->httpProxy;
        $res['httpsProxy']     = $this->httpsProxy;
        $res['noProxy']        = $this->noProxy;
        $res['maxIdleConns']   = $this->maxIdleConns;
        $res['localAddr']      = $this->localAddr;
        $res['socks5Proxy']    = $this->socks5Proxy;
        $res['socks5NetWork']  = $this->socks5NetWork;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RuntimeOptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['autoretry'])) {
            $model->autoretry = $map['autoretry'];
        }
        if (isset($map['ignoreSSL'])) {
            $model->ignoreSSL = $map['ignoreSSL'];
        }
        if (isset($map['maxAttempts'])) {
            $model->maxAttempts = $map['maxAttempts'];
        }
        if (isset($map['backoffPolicy'])) {
            $model->backoffPolicy = $map['backoffPolicy'];
        }
        if (isset($map['backoffPeriod'])) {
            $model->backoffPeriod = $map['backoffPeriod'];
        }
        if (isset($map['readTimeout'])) {
            $model->readTimeout = $map['readTimeout'];
        }
        if (isset($map['connectTimeout'])) {
            $model->connectTimeout = $map['connectTimeout'];
        }
        if (isset($map['httpProxy'])) {
            $model->httpProxy = $map['httpProxy'];
        }
        if (isset($map['httpsProxy'])) {
            $model->httpsProxy = $map['httpsProxy'];
        }
        if (isset($map['noProxy'])) {
            $model->noProxy = $map['noProxy'];
        }
        if (isset($map['maxIdleConns'])) {
            $model->maxIdleConns = $map['maxIdleConns'];
        }
        if (isset($map['localAddr'])) {
            $model->localAddr = $map['localAddr'];
        }
        if (isset($map['socks5Proxy'])) {
            $model->socks5Proxy = $map['socks5Proxy'];
        }
        if (isset($map['socks5NetWork'])) {
            $model->socks5NetWork = $map['socks5NetWork'];
        }

        return $model;
    }
}
