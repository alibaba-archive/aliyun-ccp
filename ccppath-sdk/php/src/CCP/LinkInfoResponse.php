<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class LinkInfoResponse extends Model
{
    public $authenticationType;
    public $createdAt;
    public $domainId;
    public $identity;
    public $lastLoginTime;
    public $status;
    public $userId;
    protected $_required = [
        'authenticationType' => true,
        'createdAt'          => true,
        'domainId'           => true,
        'identity'           => true,
        'lastLoginTime'      => true,
        'status'             => true,
        'userId'             => true,
    ];
    protected $_name = [
        'authenticationType' => 'authentication_type',
        'createdAt'          => 'created_at',
        'domainId'           => 'domain_id',
        'identity'           => 'identity',
        'lastLoginTime'      => 'last_login_time',
        'status'             => 'status',
        'userId'             => 'user_id',
    ];
    protected $_description = [
        'authenticationType' => '认证类型',
        'createdAt'          => '创建时间',
        'domainId'           => 'Domain ID',
        'identity'           => '唯一身份标识',
        'lastLoginTime'      => '最后登录时间',
        'status'             => '状态',
        'userId'             => '用户ID',
    ];
    protected $_example = [
        'authenticationType' => 'mobile',
        'createdAt'          => 1556163159820,
        'domainId'           => '5000',
        'identity'           => '15208345000',
        'lastLoginTime'      => 1556163159820,
        'status'             => 'normal',
        'userId'             => '00016a587b62b50003deea299a4f5b50',
    ];
    protected $_format = [
        'createdAt'     => 'int64',
        'lastLoginTime' => 'int64',
    ];
}
