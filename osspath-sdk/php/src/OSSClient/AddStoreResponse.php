<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class AddStoreResponse extends Model
{
    /**
     * @description 全球加速域名
     *
     * @example https://oss-cn-shenzhen.aliyuncs.com/
     *
     * @var string
     */
    public $accelerateEndpoint;
    /**
     * @description 存储公共前缀
     *
     * @example ccp-data
     *
     * @var string
     */
    public $basePath;
    /**
     * @description bucket名称
     *
     * @example data-sz-bucket
     *
     * @var string
     */
    public $bucket;
    /**
     * @description 用户自定义绑定存储地址
     *
     * @example https://oss-cn-shenzhen.aliyuncs.com/
     *
     * @var string
     */
    public $customizedEndpoint;
    /**
     * @description domain ID
     *
     * @example sz100
     *
     * @var string
     */
    public $domainId;
    /**
     * @description 存储访问地址
     *
     * @example https://oss-cn-shenzhen.aliyuncs.com/
     *
     * @var string
     */
    public $endpoint;
    /**
     * @description 内网存储地址
     *
     * @example https://oss-cn-shenzhen.aliyuncs.com/
     *
     * @var string
     */
    public $internalEndpoint;
    /**
     * @description 存储归属，system表示系统提供，custom表示使用自己的存储
     *
     * @example system
     *
     * @var string
     */
    public $ownership;
    /**
     * @description Policy授权,system类型store会将bucket权限授予当前云账号
     *
     * @var string
     */
    public $policy;
    /**
     * @description 访问Bucket的角色ARN
     *
     * @example acs:oss:*:*:*
     *
     * @var string
     */
    public $roleArn;
    /**
     * @description store ID
     *
     * @example cdjaksbwuiqbxuiassd
     *
     * @var string
     */
    public $storeId;
    /**
     * @description 存储类型，当前只支持oss
     *
     * @example oss
     *
     * @var string
     */
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

    public function validate()
    {
        Model::validateField($this->bucket, 'required', true);
        Model::validateField($this->domainId, 'required', true);
        Model::validateField($this->endpoint, 'required', true);
        Model::validateField($this->ownership, 'required', true);
        Model::validateField($this->policy, 'required', true);
        Model::validateField($this->storeId, 'required', true);
        Model::validateField($this->type, 'required', true);
    }

    public function toMap()
    {
        $res                        = [];
        $res['accelerate_endpoint'] = $this->accelerateEndpoint;
        $res['base_path']           = $this->basePath;
        $res['bucket']              = $this->bucket;
        $res['customized_endpoint'] = $this->customizedEndpoint;
        $res['domain_id']           = $this->domainId;
        $res['endpoint']            = $this->endpoint;
        $res['internal_endpoint']   = $this->internalEndpoint;
        $res['ownership']           = $this->ownership;
        $res['policy']              = $this->policy;
        $res['role_arn']            = $this->roleArn;
        $res['store_id']            = $this->storeId;
        $res['type']                = $this->type;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddStoreResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accelerate_endpoint'])) {
            $model->accelerateEndpoint = $map['accelerate_endpoint'];
        }
        if (isset($map['base_path'])) {
            $model->basePath = $map['base_path'];
        }
        if (isset($map['bucket'])) {
            $model->bucket = $map['bucket'];
        }
        if (isset($map['customized_endpoint'])) {
            $model->customizedEndpoint = $map['customized_endpoint'];
        }
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['endpoint'])) {
            $model->endpoint = $map['endpoint'];
        }
        if (isset($map['internal_endpoint'])) {
            $model->internalEndpoint = $map['internal_endpoint'];
        }
        if (isset($map['ownership'])) {
            $model->ownership = $map['ownership'];
        }
        if (isset($map['policy'])) {
            $model->policy = $map['policy'];
        }
        if (isset($map['role_arn'])) {
            $model->roleArn = $map['role_arn'];
        }
        if (isset($map['store_id'])) {
            $model->storeId = $map['store_id'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
