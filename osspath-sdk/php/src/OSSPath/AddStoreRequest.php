<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class AddStoreRequest extends Model
{
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
     * @description 存储归属，system表示系统提供，custom表示使用自己的存储
     *
     * @example system
     *
     * @var string
     */
    public $ownership;
    /**
     * @description 访问Bucket的角色ARN
     *
     * @example acs:oss:*:*:*
     *
     * @var string
     */
    public $roleArn;
    /**
     * @description 存储类型，当前只支持oss
     *
     * @example oss
     *
     * @var string
     */
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
    protected $_default = [
        'ownership' => 'system',
    ];

    public function validate()
    {
        Model::validateRequired('domainId', $this->domainId, true);
        Model::validateRequired('endpoint', $this->endpoint, true);
        Model::validateRequired('type', $this->type, true);
    }

    public function toMap()
    {
        $res              = [];
        $res['base_path'] = $this->basePath;
        $res['bucket']    = $this->bucket;
        $res['domain_id'] = $this->domainId;
        $res['endpoint']  = $this->endpoint;
        $res['ownership'] = $this->ownership;
        $res['role_arn']  = $this->roleArn;
        $res['type']      = $this->type;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddStoreRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['base_path'])) {
            $model->basePath = $map['base_path'];
        }
        if (isset($map['bucket'])) {
            $model->bucket = $map['bucket'];
        }
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['endpoint'])) {
            $model->endpoint = $map['endpoint'];
        }
        if (isset($map['ownership'])) {
            $model->ownership = $map['ownership'];
        }
        if (isset($map['role_arn'])) {
            $model->roleArn = $map['role_arn'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
