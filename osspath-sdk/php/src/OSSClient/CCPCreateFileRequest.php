<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

/**
 * 创建文件.
 */
class CCPCreateFileRequest extends Model
{
    /**
     * @description ContentMd5
     *
     * @example E10ADC3949BA59ABBE56E057F20F883E
     *
     * @var string
     */
    public $contentMd5;
    /**
     * @description ContentType
     *
     * @example application/json
     *
     * @var string
     */
    public $contentType;
    /**
     * @description Name
     *
     * @example ccp.jpg
     *
     * @var string
     */
    public $name;
    /**
     * @description part_info_list
     *
     * @var array
     */
    public $partInfoList;
    /**
     * @description Size
     *
     * @var int
     */
    public $size;
    /**
     * @description Type
     *
     * @example file
     *
     * @var string
     */
    public $type;
    /**
     * @description auto_rename
     *
     * @var bool
     */
    public $autoRename;
    /**
     * @description content_hash
     *
     * @example 7C4A8D09CA3762AF61E59520943DC26494F8941B
     *
     * @var string
     */
    public $contentHash;
    /**
     * @description content_hash_name
     *
     * @example sha1
     *
     * @var string
     */
    public $contentHashName;
    /**
     * @description description
     *
     * @example file description
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
     * @description encrypt_mode
     *
     * @var string
     */
    public $encryptMode;
    /**
     * @description file_id
     *
     * @var string
     */
    public $fileId;
    /**
     * @description hidden
     *
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
     * @description last_updated_at
     *
     * @example 2019-08-20T06:51:27.292Z
     *
     * @var string
     */
    public $lastUpdatedAt;
    /**
     * @var string
     */
    public $meta;
    /**
     * @description parent_file_id
     *
     * @example root
     *
     * @var string
     */
    public $parentFileId;
    /**
     * @description pre_hash
     *
     * @example E10ADC3949BA59ABBE56E057F20F883E
     *
     * @var string
     */
    public $preHash;
    /**
     * @description streams_info
     *
     * @var object
     */
    public $streamsInfo;
    /**
     * @description user_meta
     *
     * @example user_meta
     *
     * @var string
     */
    public $userMeta;
    protected $_name = [
        'contentMd5'      => 'content_md5',
        'contentType'     => 'content_type',
        'name'            => 'name',
        'partInfoList'    => 'part_info_list',
        'size'            => 'size',
        'type'            => 'type',
        'autoRename'      => 'auto_rename',
        'contentHash'     => 'content_hash',
        'contentHashName' => 'content_hash_name',
        'description'     => 'description',
        'driveId'         => 'drive_id',
        'encryptMode'     => 'encrypt_mode',
        'fileId'          => 'file_id',
        'hidden'          => 'hidden',
        'labels'          => 'labels',
        'lastUpdatedAt'   => 'last_updated_at',
        'meta'            => 'meta',
        'parentFileId'    => 'parent_file_id',
        'preHash'         => 'pre_hash',
        'streamsInfo'     => 'streams_info',
        'userMeta'        => 'user_meta',
    ];
    protected $_default = [
        'autoRename' => 'false',
    ];

    public function validate()
    {
        Model::validateField($this->description, 'maxLength', 0);
        Model::validateField($this->parentFileId, 'maxLength', 50);
        Model::validateField($this->description, 'minLength', 1024);
        Model::validateField($this->parentFileId, 'minLength', 40);
        Model::validateField($this->driveId, 'pattern', '[0-9]+');
        Model::validateField($this->parentFileId, 'pattern', '[a-z0-9]{1,50}');
    }

    public function toMap()
    {
        $res                   = [];
        $res['content_md5']    = $this->contentMd5;
        $res['content_type']   = $this->contentType;
        $res['name']           = $this->name;
        $res['part_info_list'] = [];
        if (null !== $this->partInfoList && \is_array($this->partInfoList)) {
            $n = 0;
            foreach ($this->partInfoList as $item) {
                $res['part_info_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['size']              = $this->size;
        $res['type']              = $this->type;
        $res['auto_rename']       = $this->autoRename;
        $res['content_hash']      = $this->contentHash;
        $res['content_hash_name'] = $this->contentHashName;
        $res['description']       = $this->description;
        $res['drive_id']          = $this->driveId;
        $res['encrypt_mode']      = $this->encryptMode;
        $res['file_id']           = $this->fileId;
        $res['hidden']            = $this->hidden;
        $res['labels']            = [];
        if (null !== $this->labels) {
            $res['labels'] = $this->labels;
        }
        $res['last_updated_at'] = $this->lastUpdatedAt;
        $res['meta']            = $this->meta;
        $res['parent_file_id']  = $this->parentFileId;
        $res['pre_hash']        = $this->preHash;
        $res['streams_info']    = $this->streamsInfo;
        $res['user_meta']       = $this->userMeta;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPCreateFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content_md5'])) {
            $model->contentMd5 = $map['content_md5'];
        }
        if (isset($map['content_type'])) {
            $model->contentType = $map['content_type'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
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
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['auto_rename'])) {
            $model->autoRename = $map['auto_rename'];
        }
        if (isset($map['content_hash'])) {
            $model->contentHash = $map['content_hash'];
        }
        if (isset($map['content_hash_name'])) {
            $model->contentHashName = $map['content_hash_name'];
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
        if (isset($map['last_updated_at'])) {
            $model->lastUpdatedAt = $map['last_updated_at'];
        }
        if (isset($map['meta'])) {
            $model->meta = $map['meta'];
        }
        if (isset($map['parent_file_id'])) {
            $model->parentFileId = $map['parent_file_id'];
        }
        if (isset($map['pre_hash'])) {
            $model->preHash = $map['pre_hash'];
        }
        if (isset($map['streams_info'])) {
            $model->streamsInfo = $map['streams_info'];
        }
        if (isset($map['user_meta'])) {
            $model->userMeta = $map['user_meta'];
        }

        return $model;
    }
}
