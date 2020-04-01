<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 转码接口response.
 */
class OSSVideoTranscodeResponse extends Model
{
    /**
     * @description definition_list
     *
     * @example
     *
     * @var array
     */
    public $definitionList;
    /**
     * @description hls_time
     *
     * @example 10
     *
     * @var int
     */
    public $hlsTime;
    protected $_name = [
        'definitionList' => 'definition_list',
        'hlsTime'        => 'hls_time',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                    = [];
        $res['definition_list'] = [];
        if (null !== $this->definitionList) {
            $res['definition_list'] = $this->definitionList;
        }
        $res['hls_time'] = $this->hlsTime;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSVideoTranscodeResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['definition_list'])) {
            if (!empty($map['definition_list'])) {
                $model->definitionList = [];
                $model->definitionList = $map['definition_list'];
            }
        }
        if (isset($map['hls_time'])) {
            $model->hlsTime = $map['hls_time'];
        }

        return $model;
    }
}
