<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class OSSGetFileRequestModel extends Model
{
    /**
     * @description headers
     *
     * @var array
     */
    public $headers;
    /**
     * @description body
     *
     * @var OSSGetFileRequest
     */
    public $body;
    protected $_name = [
        'headers' => 'headers',
        'body'    => 'body',
    ];

    public function validate()
    {
        Model::validateRequired('body', $this->body, true);
    }

    public function toMap()
    {
        $res            = [];
        $res['headers'] = $this->headers;
        $res['body']    = null !== $this->body ? $this->body->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSGetFileRequestModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['headers'])) {
            $model->headers = $map['headers'];
        }
        if (isset($map['body'])) {
            $model->body = OSSGetFileRequest::fromMap($map['body']);
        }

        return $model;
    }
}
