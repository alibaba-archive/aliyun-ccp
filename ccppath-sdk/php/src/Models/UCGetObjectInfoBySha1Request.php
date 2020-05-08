<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * UCGetObjectInfoBySha1Request.
 */
class UCGetObjectInfoBySha1Request extends Model
{
    /**
     * @var string
     */
    public $sha1;
    protected $_name = [
        'sha1' => 'sha1',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res         = [];
        $res['sha1'] = $this->sha1;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UCGetObjectInfoBySha1Request
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sha1'])) {
            $model->sha1 = $map['sha1'];
        }

        return $model;
    }
}
