<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCPPath;

use AlibabaCloud\Tea\Model;

/**
 * Base file response.
 */
class BaseCCPFileResponse extends Model
{
    /**
     * @description category
     *
     * @example doc
     *
     * @var string
     */
    public $category;

    /**
     * @description Content Hash
     *
     * @example EA4942AA8761213890A5C386F88E6464D2C31CA3
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
     * @description content_type
     *
     * @example application/json
     *
     * @var string
     */
    public $contentType;

    /**
     * @description crc64_hash
     *
     * @var string
     */
    public $crc64Hash;

    /**
     * @description created_at
     *
     * @example 2019-08-20T06:51:27.292Z
     *
     * @var string
     */
    public $createdAt;

    /**
     * @description description
     *
     * @example file description
     *
     * @var string
     */
    public $description;

    /**
     * @description DomainID
     *
     * @example test001
     *
     * @var string
     */
    public $domainId;

    /**
     * @description download_url
     *
     * @example https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx
     *
     * @var string
     */
    public $downloadUrl;

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
     * @example pin
     *
     * @var string
     */
    public $encryptMode;

    /**
     * @description file_extension
     *
     * @example jpg
     *
     * @var string
     */
    public $fileExtension;

    /**
     * @description file_id
     *
     * @example 5d5b846942cf94fa72324c14a4bda34e81da635d
     *
     * @var string
     */
    public $fileId;

    /**
     * @description Hidden
     * type: boolean
     * @example false
     *
     * @var bool
     */
    public $hidden;

    /**
     * @var ImageMediaResponse
     */
    public $imageMediaMetadata;

    /**
     * @description labels
     *
     * @example label1:1, label2:2
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
     * @description parent_file_id
     *
     * @example root
     *
     * @var string
     */
    public $parentFileId;

    /**
     * @description Size
     *
     * @example 1024
     *
     * @var int
     */
    public $size;

    /**
     * @description starred
     * type: boolean
     * @example false
     *
     * @var bool
     */
    public $starred;

    /**
     * @description status
     *
     * @example available
     *
     * @var string
     */
    public $status;

    /**
     * @description streams url info
     *
     * @var object
     */
    public $streamsUrlInfo;

    /**
     * @description thumbnail
     *
     * @example https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx
     *
     * @var string
     */
    public $thumbnail;

    /**
     * @description trashed_at
     *
     * @var string
     */
    public $trashedAt;

    /**
     * @description type
     *
     * @example file
     *
     * @var string
     */
    public $type;

    /**
     * @description updated_at
     *
     * @var string
     */
    public $updatedAt;

    /**
     * @description upload_id
     *
     * @example C9DCFE5A82644AC7A02DB74C30C934A6
     *
     * @var string
     */
    public $uploadId;

    /**
     * @description url
     *
     * @example https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx
     *
     * @var string
     */
    public $url;

    /**
     * @description user_meta
     *
     * @example user_meta
     *
     * @var string
     */
    public $userMeta;

    /**
     * @var VideoMediaResponse
     */
    public $videoMediaMetadata;
    protected $_name = [
        'category'           => 'category',
        'contentHash'        => 'content_hash',
        'contentHashName'    => 'content_hash_name',
        'contentType'        => 'content_type',
        'crc64Hash'          => 'crc64_hash',
        'createdAt'          => 'created_at',
        'description'        => 'description',
        'domainId'           => 'domain_id',
        'downloadUrl'        => 'download_url',
        'driveId'            => 'drive_id',
        'encryptMode'        => 'encrypt_mode',
        'fileExtension'      => 'file_extension',
        'fileId'             => 'file_id',
        'hidden'             => 'hidden',
        'imageMediaMetadata' => 'image_media_metadata',
        'labels'             => 'labels',
        'meta'               => 'meta',
        'name'               => 'name',
        'parentFileId'       => 'parent_file_id',
        'size'               => 'size',
        'starred'            => 'starred',
        'status'             => 'status',
        'streamsUrlInfo'     => 'streams_url_info',
        'thumbnail'          => 'thumbnail',
        'trashedAt'          => 'trashed_at',
        'type'               => 'type',
        'updatedAt'          => 'updated_at',
        'uploadId'           => 'upload_id',
        'url'                => 'url',
        'userMeta'           => 'user_meta',
        'videoMediaMetadata' => 'video_media_metadata',
    ];

    public function validate()
    {
        Model::validatePattern('domainId', $this->domainId, '[a-z0-9A-Z]+');
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9]{1,50}');
        Model::validatePattern('name', $this->name, '[a-zA-Z0-9.-]{1,1000}');
        Model::validatePattern('parentFileId', $this->parentFileId, '[a-z0-9]{1,50}');
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateMaxLength('parentFileId', $this->parentFileId, 50);
        Model::validateMinLength('fileId', $this->fileId, 40);
        Model::validateMinLength('parentFileId', $this->parentFileId, 40);
        Model::validateRequired('name', $this->name, true);
    }

    public function toMap()
    {
        $res                         = [];
        $res['category']             = $this->category;
        $res['content_hash']         = $this->contentHash;
        $res['content_hash_name']    = $this->contentHashName;
        $res['content_type']         = $this->contentType;
        $res['crc64_hash']           = $this->crc64Hash;
        $res['created_at']           = $this->createdAt;
        $res['description']          = $this->description;
        $res['domain_id']            = $this->domainId;
        $res['download_url']         = $this->downloadUrl;
        $res['drive_id']             = $this->driveId;
        $res['encrypt_mode']         = $this->encryptMode;
        $res['file_extension']       = $this->fileExtension;
        $res['file_id']              = $this->fileId;
        $res['hidden']               = $this->hidden;
        $res['image_media_metadata'] = null !== $this->imageMediaMetadata ? $this->imageMediaMetadata->toMap() : null;
        $res['labels']               = [];
        if (null !== $this->labels) {
            $res['labels'] = $this->labels;
        }
        $res['meta']                 = $this->meta;
        $res['name']                 = $this->name;
        $res['parent_file_id']       = $this->parentFileId;
        $res['size']                 = $this->size;
        $res['starred']              = $this->starred;
        $res['status']               = $this->status;
        $res['streams_url_info']     = $this->streamsUrlInfo;
        $res['thumbnail']            = $this->thumbnail;
        $res['trashed_at']           = $this->trashedAt;
        $res['type']                 = $this->type;
        $res['updated_at']           = $this->updatedAt;
        $res['upload_id']            = $this->uploadId;
        $res['url']                  = $this->url;
        $res['user_meta']            = $this->userMeta;
        $res['video_media_metadata'] = null !== $this->videoMediaMetadata ? $this->videoMediaMetadata->toMap() : null;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BaseCCPFileResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['content_hash'])) {
            $model->contentHash = $map['content_hash'];
        }
        if (isset($map['content_hash_name'])) {
            $model->contentHashName = $map['content_hash_name'];
        }
        if (isset($map['content_type'])) {
            $model->contentType = $map['content_type'];
        }
        if (isset($map['crc64_hash'])) {
            $model->crc64Hash = $map['crc64_hash'];
        }
        if (isset($map['created_at'])) {
            $model->createdAt = $map['created_at'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['download_url'])) {
            $model->downloadUrl = $map['download_url'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['encrypt_mode'])) {
            $model->encryptMode = $map['encrypt_mode'];
        }
        if (isset($map['file_extension'])) {
            $model->fileExtension = $map['file_extension'];
        }
        if (isset($map['file_id'])) {
            $model->fileId = $map['file_id'];
        }
        if (isset($map['hidden'])) {
            $model->hidden = $map['hidden'];
        }
        if (isset($map['image_media_metadata'])) {
            $model->imageMediaMetadata = ImageMediaResponse::fromMap($map['image_media_metadata']);
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
        if (isset($map['parent_file_id'])) {
            $model->parentFileId = $map['parent_file_id'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['starred'])) {
            $model->starred = $map['starred'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['streams_url_info'])) {
            $model->streamsUrlInfo = $map['streams_url_info'];
        }
        if (isset($map['thumbnail'])) {
            $model->thumbnail = $map['thumbnail'];
        }
        if (isset($map['trashed_at'])) {
            $model->trashedAt = $map['trashed_at'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['updated_at'])) {
            $model->updatedAt = $map['updated_at'];
        }
        if (isset($map['upload_id'])) {
            $model->uploadId = $map['upload_id'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['user_meta'])) {
            $model->userMeta = $map['user_meta'];
        }
        if (isset($map['video_media_metadata'])) {
            $model->videoMediaMetadata = VideoMediaResponse::fromMap($map['video_media_metadata']);
        }

        return $model;
    }
}
