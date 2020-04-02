<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class BatchSubRequest extends Model
{
    /**
     * @description body 子请求的请求参数 json 字符串，可参考对于子请求文档, 当指定了body 必须传headers ： "Content-Type" 对应的类型，目前子请求入参是"application/json"
     *
     * @example {"drive_id":"101","file_id":"xxxxxx"}
     *
     * @var object
     */
    public $body;
    /**
     * @description headers 请求头，表示body传入数据的类型
     *
     * @example {"Content-Type":"application/json"}
     *
     * @var object
     */
    public $headers;
    /**
     * @description id 用于request 和 response关联， 不允许重复
     *
     * @example "1"
     *
     * @var string
     */
    public $id;
    /**
     * @description method
     *
     * @example "POST"
     *
     * @var string
     */
    public $method;
    /**
     * @description url 子请求的api path路径， 可参考对于子请求文档
     *
     * @example /file/get
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'body'    => 'body',
        'headers' => 'headers',
        'id'      => 'id',
        'method'  => 'method',
        'url'     => 'url',
    ];

    public function validate()
    {
        Model::validateRequired('id', $this->id, true);
        Model::validateRequired('method', $this->method, true);
        Model::validateRequired('url', $this->url, true);
    }

    public function toMap()
    {
        $res            = [];
        $res['body']    = $this->body;
        $res['headers'] = $this->headers;
        $res['id']      = $this->id;
        $res['method']  = $this->method;
        $res['url']     = $this->url;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchSubRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['body'])) {
            $model->body = $map['body'];
        }
        if (isset($map['headers'])) {
            $model->headers = $map['headers'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['method'])) {
            $model->method = $map['method'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
