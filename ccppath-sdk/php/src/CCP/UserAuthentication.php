<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class UserAuthentication extends Model
{
    public $AuthenticationType;
    public $CreatedAt;
    public $Detail;
    public $DomainID;
    public $Identity;
    public $LastLoginTime;
    public $Status;
    public $UserID;
    protected $_required = [
        'AuthenticationType' => true,
        'CreatedAt'          => true,
        'Detail'             => true,
        'DomainID'           => true,
        'Identity'           => true,
        'LastLoginTime'      => true,
        'Status'             => true,
        'UserID'             => true,
    ];
    protected $_name = [
        'AuthenticationType' => 'AuthenticationType',
        'CreatedAt'          => 'CreatedAt',
        'Detail'             => 'Detail',
        'DomainID'           => 'DomainID',
        'Identity'           => 'Identity',
        'LastLoginTime'      => 'LastLoginTime',
        'Status'             => 'Status',
        'UserID'             => 'UserID',
    ];
    protected $_description = [
        'AuthenticationType' => '认证类型',
        'CreatedAt'          => '创建时间',
        'Detail'             => '详情',
        'DomainID'           => 'Domain ID',
        'Identity'           => '唯一身份标识',
        'LastLoginTime'      => '最后登录时间',
        'Status'             => '状态',
        'UserID'             => '用户ID',
    ];
    protected $_example = [
        'AuthenticationType' => 'mobile',
        'CreatedAt'          => 1556163159820,
        'Detail'             => '{name:abc}',
        'DomainID'           => '5000',
        'Identity'           => '15208345000',
        'LastLoginTime'      => 1556163159820,
        'Status'             => 'normal',
        'UserID'             => '00016a587b62b50003deea299a4f5b50',
    ];
    protected $_format = [
        'CreatedAt'     => 'int64',
        'LastLoginTime' => 'int64',
    ];
}
