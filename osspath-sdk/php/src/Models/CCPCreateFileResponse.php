<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\Models;

use AlibabaCloud\Tea\Model;

/**
 * Create file response.
 */
class CCPCreateFileResponse extends Model
{
    /**
     * @description domain_id
     *
     * @example domain
     *
     * @var string
     */
    public $domainId;

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
     * @description exist
     * type: boolean
     * @example false
     *
     * @var bool
     */
    public $exist;

    /**
     * @description file_id
     *
     * @example 5d79206586bb5dd69fb34c349282718146c55da7
     *
     * @var string
     */
    public $fileId;

    /**
     * @description file_name
     *
     * @example test.txt
     *
     * @var string
     */
    public $fileName;

    /**
     * @description parent_file_id
     *
     * @example root
     *
     * @var string
     */
    public $parentFileId;

    /**
     * @description part_info_list
     *
     * @example [
     *
     * @var array
     */
    public $partInfoList;

    /**
     * @description rapid_upload
     * type: boolean
     * @example false
     *
     * @var bool
     */
    public $rapidUpload;

    /**
     * @description status
     *
     * @example available
     *
     * @var string
     */
    public $status;

    /**
     * @description streams_upload_info
     *
     * @var object
     */
    public $streamsUploadInfo;

    /**
     * @description type
     *
     * @example file
     *
     * @var string
     */
    public $type;

    /**
     * @description upload_id
     *
     * @example C9DCFE5A82644AC7A02DB74C30C934A6
     *
     * @var string
     */
    public $uploadId;
    protected $_name = [
        'domainId'          => 'domain_id',
        'driveId'           => 'drive_id',
        'encryptMode'       => 'encrypt_mode',
        'exist'             => 'exist',
        'fileId'            => 'file_id',
        'fileName'          => 'file_name',
        'parentFileId'      => 'parent_file_id',
        'partInfoList'      => 'part_info_list',
        'rapidUpload'       => 'rapid_upload',
        'status'            => 'status',
        'streamsUploadInfo' => 'streams_upload_info',
        'type'              => 'type',
        'uploadId'          => 'upload_id',
    ];

    public function validate()
    {
        Model::validateMaxLength('domainId', $this->domainId, 50);
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateMaxLength('fileName', $this->fileName, 255);
        Model::validateMaxLength('parentFileId', $this->parentFileId, 50);
        Model::validateMinLength('domainId', $this->domainId, 40);
        Model::validateMinLength('fileId', $this->fileId, 40);
        Model::validateMinLength('fileName', $this->fileName, 1);
        Model::validateMinLength('parentFileId', $this->parentFileId, 40);
        Model::validatePattern('domainId', $this->domainId, '[a-z0-9]{1,50}');
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9]{1,50}');
        Model::validatePattern('parentFileId', $this->parentFileId, '[a-z0-9]{1,50}');
    }

    public function toMap()
    {
        $res                   = [];
        $res['domain_id']      = $this->domainId;
        $res['drive_id']       = $this->driveId;
        $res['encrypt_mode']   = $this->encryptMode;
        $res['exist']          = $this->exist;
        $res['file_id']        = $this->fileId;
        $res['file_name']      = $this->fileName;
        $res['parent_file_id'] = $this->parentFileId;
        $res['part_info_list'] = [];
        if (null !== $this->partInfoList && \is_array($this->partInfoList)) {
            $n = 0;
            foreach ($this->partInfoList as $item) {
                $res['part_info_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['rapid_upload']        = $this->rapidUpload;
        $res['status']              = $this->status;
        $res['streams_upload_info'] = $this->streamsUploadInfo;
        $res['type']                = $this->type;
        $res['upload_id']           = $this->uploadId;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CCPCreateFileResponse
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['domain_id'])) {
            $model->domainId = $map['domain_id'];
        }
        if (isset($map['drive_id'])) {
            $model->driveId = $map['drive_id'];
        }
        if (isset($map['encrypt_mode'])) {
            $model->encryptMode = $map['encrypt_mode'];
        }
        if (isset($map['exist'])) {
            $model->exist = $map['exist'];
        }
        if (isset($map['file_id'])) {
            $model->fileId = $map['file_id'];
        }
        if (isset($map['file_name'])) {
            $model->fileName = $map['file_name'];
        }
        if (isset($map['parent_file_id'])) {
            $model->parentFileId = $map['parent_file_id'];
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
        if (isset($map['rapid_upload'])) {
            $model->rapidUpload = $map['rapid_upload'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['streams_upload_info'])) {
            $model->streamsUploadInfo = $map['streams_upload_info'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['upload_id'])) {
            $model->uploadId = $map['upload_id'];
        }

        return $model;
    }
}
