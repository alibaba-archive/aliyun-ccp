<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class StoreItemResponse extends Model
{
    public $accelerateEndpoint;
    public $basePath;
    public $bucket;
    public $customizedEndpoint;
    public $domainId;
    public $endpoint;
    public $internalEndpoint;
    public $ownership;
    public $policy;
    public $roleArn;
    public $storeId;
    public $type;
    protected $_name = [
        'accelerateEndpoint' => 'accelerate_endpoint',
        'basePath'           => 'base_path',
        'bucket'             => 'bucket',
        'customizedEndpoint' => 'customized_endpoint',
        'domainId'           => 'domain_id',
        'endpoint'           => 'endpoint',
        'internalEndpoint'   => 'internal_endpoint',
        'ownership'          => 'ownership',
        'policy'             => 'policy',
        'roleArn'            => 'role_arn',
        'storeId'            => 'store_id',
        'type'               => 'type',
    ];
    protected $_description = [
        'accelerateEndpoint' => '全球加速域名',
        'basePath'           => '存储公共前缀',
        'bucket'             => 'bucket名称',
        'customizedEndpoint' => '用户自定义绑定存储地址',
        'endpoint'           => '存储访问地址',
        'internalEndpoint'   => '内网存储地址',
        'ownership'          => '存储归属，system表示系统提供，custom表示使用自己的存储',
        'policy'             => 'Policy授权,system类型store会将bucket权限授予当前云账号',
        'roleArn'            => '访问Bucket的角色ARN',
        'storeId'            => 'store ID',
        'type'               => '存储类型，当前只支持oss',
    ];
    protected $_example = [
        'accelerateEndpoint' => 'https://oss-cn-shenzhen.aliyuncs.com/',
        'basePath'           => 'ccp-data',
        'bucket'             => 'data-sz-bucket',
        'customizedEndpoint' => 'https://oss-cn-shenzhen.aliyuncs.com/',
        'endpoint'           => 'https://oss-cn-shenzhen.aliyuncs.com/',
        'internalEndpoint'   => 'https://oss-cn-shenzhen.aliyuncs.com/',
        'ownership'          => 'system',
        'roleArn'            => 'acs:oss:*:*:*',
        'storeId'            => 'cdjaksbwuiqbxuiassd',
        'type'               => 'oss',
    ];
    protected $_required = [
        'bucket'    => true,
        'endpoint'  => true,
        'ownership' => true,
        'policy'    => true,
        'storeId'   => true,
        'type'      => true,
    ];
    protected $_enum = [
        'ownership' => 'system, custom',
        'type'      => 'oss',
    ];
}
