<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

class AppAccessStrategy extends Model
{
    /**
     * @var string
     */
    public $effect;

    /**
     * @var array
     */
    public $exceptAppIdList;
    protected $_name = [
        'effect'          => 'effect',
        'exceptAppIdList' => 'except_app_id_list',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res                       = [];
        $res['effect']             = $this->effect;
        $res['except_app_id_list'] = [];
        if (null !== $this->exceptAppIdList) {
            $res['except_app_id_list'] = $this->exceptAppIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppAccessStrategy
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['effect'])) {
            $model->effect = $map['effect'];
        }
        if (isset($map['except_app_id_list'])) {
            if (!empty($map['except_app_id_list'])) {
                $model->exceptAppIdList = [];
                $model->exceptAppIdList = $map['except_app_id_list'];
            }
        }

        return $model;
    }
}
