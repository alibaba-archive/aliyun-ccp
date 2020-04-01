<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class AddStoreRequest extends Model
{
    public $basePath;
    public $bucket;
    public $domainId;
    public $endpoint;
    public $ownership;
    public $roleArn;
    public $type;
    protected $_name = [
        'basePath'  => 'base_path',
        'bucket'    => 'bucket',
        'domainId'  => 'domain_id',
        'endpoint'  => 'endpoint',
        'ownership' => 'ownership',
        'roleArn'   => 'role_arn',
        'type'      => 'type',
    ];
    protected $_description = [
        'basePath'  => '存储公共前缀',
        'bucket'    => 'bucket名称',
        'domainId'  => 'domain ID',
        'endpoint'  => '存储访问地址',
        'ownership' => '存储归属，system表示系统提供，custom表示使用自己的存储',
        'roleArn'   => '访问Bucket的角色ARN',
        'type'      => '存储类型，当前只支持oss',
    ];
    protected $_example = [
        'basePath'  => 'ccp-data',
        'bucket'    => 'data-sz-bucket',
        'domainId'  => 'sz100',
        'endpoint'  => 'https://oss-cn-shenzhen.aliyuncs.com/',
        'ownership' => 'system',
        'roleArn'   => 'acs:oss:*:*:*',
        'type'      => 'oss',
    ];
    protected $_required = [
        'domainId' => true,
        'endpoint' => true,
        'type'     => true,
    ];
    protected $_default = [
        'ownership' => 'system',
    ];
    protected $_enum = [
        'ownership' => 'system, custom',
        'type'      => 'oss',
    ];
}
