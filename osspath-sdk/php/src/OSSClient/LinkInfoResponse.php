<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class LinkInfoResponse extends Model
{
    /**
     * @description 认证类型
     *
     * @example mobile
     *
     * @var string
     */
    public $authenticationType;
    /**
     * @description 创建时间
     *
     * @example 1556163159820
     *
     * @var int
     */
    public $createdAt;
    /**
     * @description Domain ID
     *
     * @example 5000
     *
     * @var string
     */
    public $domainId;
    /**
     * @description 唯一身份标识
     *
     * @example 15208345000
     *
     * @var string
     */
    public $identity;
    /**
     * @description 最后登录时间
     *
     * @example 1556163159820
     *
     * @var int
     */
    public $lastLoginTime;
    /**
     * @description 状态
     *
     * @example normal
     *
     * @var string
     */
    public $status;
    /**
     * @description 用户ID
     *
     * @example 00016a587b62b50003deea299a4f5b50
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'authenticationType' => 'authentication_type',
        'createdAt'          => 'created_at',
        'domainId'           => 'domain_id',
        'identity'           => 'identity',
        'lastLoginTime'      => 'last_login_time',
        'status'             => 'status',
        'userId'             => 'user_id',
    ];

    public function validate()
    {
        Model::validateRequired('authenticationType', $this->authenticationType, true);
        Model::validateRequired('createdAt', $this->createdAt, true);
        Model::validateRequired('domainId', $this->domainId, true);
        Model::validateRequired('identity', $this->identity, true);
        Model::validateRequired('lastLoginTime', $this->lastLoginTime, true);
        Model::validateRequired('status', $this->status, true);
        Model::validateRequired('userId', $this->userId, true);
    }

    public function toMap()
    {
        $res                        = [];
        $res['authentication_type'] = $this->authenticationType;
        $res['created_at']          = $this->createdAt;
        $res['domain_id']           = $this->domainId;
        $res['identity']            = $this->identity;
        $res['last_login_time']     = $this->lastLoginTime;
        $res['status']              = $this->status;
        $res['user_id']             = $this->userId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LinkInfoResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authentication_type'])) {
            $model->authenticationType = $map['authentication_type'];
        }
        if (isset($map['created_at'])) {
            $model->createdAt = $map['created_at'];
        }
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['identity'])) {
            $model->identity = $map['identity'];
        }
        if (isset($map['last_login_time'])) {
            $model->lastLoginTime = $map['last_login_time'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['user_id'])) {
            $model->userId = $map['user_id'];
        }

        return $model;
    }
}
