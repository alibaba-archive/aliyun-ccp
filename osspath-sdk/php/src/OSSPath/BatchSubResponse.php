<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class BatchSubResponse extends Model
{
    /**
     * @description body 子请求的返回结果，可参考对于子请求文档 json 字符串
     *
     * @example {"drive_id":"101","file_id":"xxxxxx"}
     *
     * @var object
     */
    public $body;

    /**
     * @description id 请求带过来的id, 可以跟 request 进行关联
     *
     * @example "1"
     *
     * @var string
     */
    public $id;

    /**
     * @description status 子请求的返回状态码，可参考对于子请求文档
     *
     * @example 200
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'body'   => 'body',
        'id'     => 'id',
        'status' => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res           = [];
        $res['body']   = $this->body;
        $res['id']     = $this->id;
        $res['status'] = $this->status;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchSubResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            $model->body = $map['body'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
