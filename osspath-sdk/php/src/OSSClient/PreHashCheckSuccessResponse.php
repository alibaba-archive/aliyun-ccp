<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * Pre hash check Response.
 */
class PreHashCheckSuccessResponse extends Model
{
    /**
     * @description code
     *
     * @var string
     */
    public $code;
    /**
     * @description file_name
     *
     * @var string
     */
    public $fileName;
    /**
     * @description message
     *
     * @var string
     */
    public $message;
    /**
     * @description parent_file_id
     *
     * @example 5d5b846942cf94fa72324c14a4bda34e81da635d
     *
     * @var string
     */
    public $parentFileId;
    /**
     * @description pre_hash
     *
     * @var string
     */
    public $preHash;
    protected $_name = [
        'code'         => 'code',
        'fileName'     => 'file_name',
        'message'      => 'message',
        'parentFileId' => 'parent_file_id',
        'preHash'      => 'pre_hash',
    ];

    public function validate()
    {
        Model::validateField($this->parentFileId, 'required', true);
        Model::validateField($this->parentFileId, 'maxLength', 50);
        Model::validateField($this->parentFileId, 'minLength', 40);
        Model::validateField($this->parentFileId, 'pattern', '[a-z0-9]{1, 50}');
    }

    public function toMap()
    {
        $res                   = [];
        $res['code']           = $this->code;
        $res['file_name']      = $this->fileName;
        $res['message']        = $this->message;
        $res['parent_file_id'] = $this->parentFileId;
        $res['pre_hash']       = $this->preHash;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PreHashCheckSuccessResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['file_name'])) {
            $model->fileName = $map['file_name'];
        }
        if (isset($map['message'])) {
            $model->message = $map['message'];
        }
        if (isset($map['parent_file_id'])) {
            $model->parentFileId = $map['parent_file_id'];
        }
        if (isset($map['pre_hash'])) {
            $model->preHash = $map['pre_hash'];
        }

        return $model;
    }
}
