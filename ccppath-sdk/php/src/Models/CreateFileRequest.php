<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * create file request.
 */
class CreateFileRequest extends Model
{
    /**
     * @description ContentHash
     *
     * @var string
     */
    public $contentHash;

    /**
     * @description ContentHashName
     *
     * @example sha1
     *
     * @var string
     */
    public $contentHashName;

    /**
     * @description ContentMd5
     *
     * @var string
     */
    public $contentMd5;

    /**
     * @description ContentType
     *
     * @var string
     */
    public $contentType;

    /**
     * @description Description
     *
     * @var string
     */
    public $description;

    /**
     * @description DriveID
     *
     * @example 1
     *
     * @var string
     */
    public $driveId;

    /**
     * @description Hidden
     *
     * @var bool
     */
    public $hidden;

    /**
     * @description Meta
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
     * @description parent_file_id
     *
     * @var string
     */
    public $parentFileId;

    /**
     * @description ParentFilePath
     *
     * @var string
     */
    public $parentFilePath;

    /**
     * @description part_info_list
     *
     * @var array
     */
    public $partInfoList;

    /**
     * @description pre_hash
     *
     * @var string
     */
    public $preHash;

    /**
     * @description ShareID
     *
     * @var string
     */
    public $shareId;

    /**
     * @description Size
     *
     * @var int
     */
    public $size;

    /**
     * @description tags
     *
     * @var object
     */
    public $tags;

    /**
     * @description Type
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'contentHash'     => 'content_hash',
        'contentHashName' => 'content_hash_name',
        'contentMd5'      => 'content_md5',
        'contentType'     => 'content_type',
        'description'     => 'description',
        'driveId'         => 'drive_id',
        'hidden'          => 'hidden',
        'meta'            => 'meta',
        'name'            => 'name',
        'parentFileId'    => 'parent_file_id',
        'parentFilePath'  => 'parent_file_path',
        'partInfoList'    => 'part_info_list',
        'preHash'         => 'pre_hash',
        'shareId'         => 'share_id',
        'size'            => 'size',
        'tags'            => 'tags',
        'type'            => 'type',
    ];

    public function validate()
    {
        Model::validateMaxLength('contentMd5', $this->contentMd5, 32);
        Model::validateMaxLength('description', $this->description, 0);
        Model::validateMaxLength('parentFileId', $this->parentFileId, 50);
        Model::validateRequired('contentType', $this->contentType, true);
        Model::validateRequired('driveId', $this->driveId, true);
        Model::validateRequired('name', $this->name, true);
        Model::validateRequired('parentFileId', $this->parentFileId, true);
        Model::validateRequired('size', $this->size, true);
        Model::validateRequired('type', $this->type, true);
        Model::validateMinLength('description', $this->description, 1024);
        Model::validateMinLength('parentFileId', $this->parentFileId, 40);
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('parentFileId', $this->parentFileId, '[a-z0-9]{1,50}');
        Model::validateMaximum('size', $this->size, 53687091200);
        Model::validateMinimum('size', $this->size, 0);
    }

    public function toMap()
    {
        $res                      = [];
        $res['content_hash']      = $this->contentHash;
        $res['content_hash_name'] = $this->contentHashName;
        $res['content_md5']       = $this->contentMd5;
        $res['content_type']      = $this->contentType;
        $res['description']       = $this->description;
        $res['drive_id']          = $this->driveId;
        $res['hidden']            = $this->hidden;
        $res['meta']              = $this->meta;
        $res['name']              = $this->name;
        $res['parent_file_id']    = $this->parentFileId;
        $res['parent_file_path']  = $this->parentFilePath;
        $res['part_info_list']    = [];
        if (null !== $this->partInfoList && \is_array($this->partInfoList)) {
            $n = 0;
            foreach ($this->partInfoList as $item) {
                $res['part_info_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['pre_hash'] = $this->preHash;
        $res['share_id'] = $this->shareId;
        $res['size']     = $this->size;
        $res['tags']     = $this->tags;
        $res['type']     = $this->type;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content_hash'])) {
            $model->contentHash = $map['content_hash'];
        }
        if (isset($map['content_hash_name'])) {
            $model->contentHashName = $map['content_hash_name'];
        }
        if (isset($map['content_md5'])) {
            $model->contentMd5 = $map['content_md5'];
        }
        if (isset($map['content_type'])) {
            $model->contentType = $map['content_type'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
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
        if (isset($map['parent_file_id'])) {
            $model->parentFileId = $map['parent_file_id'];
        }
        if (isset($map['parent_file_path'])) {
            $model->parentFilePath = $map['parent_file_path'];
        }
        if (isset($map['part_info_list'])) {
            if (!empty($map['part_info_list'])) {
                $model->partInfoList = [];
                $n                   = 0;
                foreach ($map['part_info_list'] as $item) {
                    $model->partInfoList[$n++] = null !== $item ? UploadPartInfo::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['pre_hash'])) {
            $model->preHash = $map['pre_hash'];
        }
        if (isset($map['share_id'])) {
            $model->shareId = $map['share_id'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['tags'])) {
            $model->tags = $map['tags'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
