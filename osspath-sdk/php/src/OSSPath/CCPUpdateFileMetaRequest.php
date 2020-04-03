<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * 更新文件元数据.
 */
class CCPUpdateFileMetaRequest extends Model
{
    /**
     * @var string
     */
    public $customIndexKey;
    /**
     * @description description
     * type: string
     * @example description
     *
     * @var string
     */
    public $description;
    /**
     * @description drive_id
     *
     * @example 1
     *
     * @var string
     */
    public $driveId;
    /**
     * @var string
     */
    public $encryptMode;
    /**
     * @description file_id
     *
     * @example 5d5b846942cf94fa72324c14a4bda34e81da635d
     *
     * @var string
     */
    public $fileId;
    /**
     * @description hidden
     * type: boolean
     * @example false
     *
     * @var bool
     */
    public $hidden;
    /**
     * @description labels
     *
     * @example label1, label2
     *
     * @var array
     */
    public $labels;
    /**
     * @var string
     */
    public $meta;
    /**
     * @description name
     *
     * @example ccp.jpg
     *
     * @var string
     */
    public $name;
    /**
     * @description starred
     * type: boolean
     * @example false
     *
     * @var bool
     */
    public $starred;
    /**
     * @description user_meta
     *
     * @example user_meta
     *
     * @var string
     */
    public $userMeta;
    protected $_name = [
        'customIndexKey' => 'custom_index_key',
        'description'    => 'description',
        'driveId'        => 'drive_id',
        'encryptMode'    => 'encrypt_mode',
        'fileId'         => 'file_id',
        'hidden'         => 'hidden',
        'labels'         => 'labels',
        'meta'           => 'meta',
        'name'           => 'name',
        'starred'        => 'starred',
        'userMeta'       => 'user_meta',
    ];
    protected $_default = [
        'hidden'  => 'false',
        'starred' => 'false',
    ];

    public function validate()
    {
        Model::validateMaxLength('description', $this->description, 1024);
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateMaxLength('name', $this->name, 1024);
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('fileId', $this->fileId, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9.-_]{1,50}');
        Model::validateMinLength('fileId', $this->fileId, 40);
        Model::validateMinLength('name', $this->name, 1);
    }

    public function toMap()
    {
        $res                     = [];
        $res['custom_index_key'] = $this->customIndexKey;
        $res['description']      = $this->description;
        $res['drive_id']         = $this->driveId;
        $res['encrypt_mode']     = $this->encryptMode;
        $res['file_id']          = $this->fileId;
        $res['hidden']           = $this->hidden;
        $res['labels']           = [];
        if (null !== $this->labels) {
            $res['labels'] = $this->labels;
        }
        $res['meta']      = $this->meta;
        $res['name']      = $this->name;
        $res['starred']   = $this->starred;
        $res['user_meta'] = $this->userMeta;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPUpdateFileMetaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['custom_index_key'])) {
            $model->customIndexKey = $map['custom_index_key'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['encrypt_mode'])) {
            $model->encryptMode = $map['encrypt_mode'];
        }
        if (isset($map['file_id'])) {
            $model->fileId = $map['file_id'];
        }
        if (isset($map['hidden'])) {
            $model->hidden = $map['hidden'];
        }
        if (isset($map['labels'])) {
            if (!empty($map['labels'])) {
                $model->labels = [];
                $model->labels = $map['labels'];
            }
        }
        if (isset($map['meta'])) {
            $model->meta = $map['meta'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['starred'])) {
            $model->starred = $map['starred'];
        }
        if (isset($map['user_meta'])) {
            $model->userMeta = $map['user_meta'];
        }

        return $model;
    }
}
