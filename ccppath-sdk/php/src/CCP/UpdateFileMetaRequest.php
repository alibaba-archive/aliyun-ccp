<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 更新文件元数据.
 */
class UpdateFileMetaRequest extends Model
{
    /**
     * @description description
     * type: string
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
     * @description file_id
     *
     * @var string
     */
    public $fileId;
    /**
     * @description hidden
     * type: boolean
     * @var bool
     */
    public $hidden;
    /**
     * @description meta
     *
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
     * @var string
     */
    public $shareId;
    /**
     * @description starred
     * type: boolean
     * @var bool
     */
    public $starred;
    /**
     * @description tags
     *
     * @var object
     */
    public $tags;
    protected $_name = [
        'description' => 'description',
        'driveId'     => 'drive_id',
        'fileId'      => 'file_id',
        'hidden'      => 'hidden',
        'meta'        => 'meta',
        'name'        => 'name',
        'shareId'     => 'share_id',
        'starred'     => 'starred',
        'tags'        => 'tags',
    ];
    protected $_default = [
        'hidden'  => 'false',
        'starred' => 'false',
    ];

    public function validate()
    {
        Model::validateMaxLength('description', $this->description, 1000);
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('fileId', $this->fileId, true);
        Model::validateRequired('name', $this->name, true);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9.-_]{1,50}');
        Model::validatePattern('name', $this->name, '[a-zA-Z0-9.-]{1,1000}');
        Model::validateMinLength('fileId', $this->fileId, 40);
    }

    public function toMap()
    {
        $res                = [];
        $res['description'] = $this->description;
        $res['drive_id']    = $this->driveId;
        $res['file_id']     = $this->fileId;
        $res['hidden']      = $this->hidden;
        $res['meta']        = $this->meta;
        $res['name']        = $this->name;
        $res['share_id']    = $this->shareId;
        $res['starred']     = $this->starred;
        $res['tags']        = $this->tags;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFileMetaRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['file_id'])) {
            $model->fileId = $map['file_id'];
        }
        if (isset($map['hidden'])) {
            $model->hidden = $map['hidden'];
        }
        if (isset($map['meta'])) {
            $model->meta = $map['meta'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }
        if (isset($map['starred'])) {
            $model->starred = $map['starred'];
        }
        if (isset($map['tags'])) {
            $model->tags = $map['tags'];
        }

        return $model;
    }
}
