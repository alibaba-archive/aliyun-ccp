<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * 转码接口response.
 */
class OSSVideoDefinitionResponse extends Model
{
    /**
     * @description definition_list
     *
     * @example
     *
     * @var array
     */
    public $definitionList;
    protected $_name = [
        'definitionList' => 'definition_list',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OSSVideoDefinitionResponse
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

        return $model;
    }
}
