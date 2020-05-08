<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * get last file op cursor response.
 */
class GetLastCursorResponse extends Model
{
    /**
     * @var string
     */
    public $cursor;
    protected $_name = [
        'cursor' => 'cursor',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res           = [];
        $res['cursor'] = $this->cursor;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLastCursorResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }

        return $model;
    }
}
