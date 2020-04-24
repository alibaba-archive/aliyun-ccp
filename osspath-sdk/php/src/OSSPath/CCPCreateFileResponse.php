<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

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
     * @description file_id
     *
     * @example 5d79206586bb5dd69fb34c349282718146c55da7
     *
     * @var string
     */
    public $fileId;

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
        'domainId'     => 'domain_id',
        'driveId'      => 'drive_id',
        'fileId'       => 'file_id',
        'parentFileId' => 'parent_file_id',
        'partInfoList' => 'part_info_list',
        'rapidUpload'  => 'rapid_upload',
        'type'         => 'type',
        'uploadId'     => 'upload_id',
    ];

    public function validate()
    {
        Model::validateMaxLength('domainId', $this->domainId, 50);
        Model::validateMaxLength('fileId', $this->fileId, 50);
        Model::validateMaxLength('parentFileId', $this->parentFileId, 50);
        Model::validateMinLength('domainId', $this->domainId, 40);
        Model::validateMinLength('fileId', $this->fileId, 40);
        Model::validateMinLength('parentFileId', $this->parentFileId, 40);
        Model::validatePattern('domainId', $this->domainId, '[a-z0-9]{1, 50}');
        Model::validatePattern('driveId', $this->driveId, '[0-9]+');
        Model::validatePattern('fileId', $this->fileId, '[a-z0-9]{1, 50}');
        Model::validatePattern('parentFileId', $this->parentFileId, '[a-z0-9]{1, 50}');
    }

    public function toMap()
    {
        $res                   = [];
        $res['domain_id']      = $this->domainId;
        $res['drive_id']       = $this->driveId;
        $res['file_id']        = $this->fileId;
        $res['parent_file_id'] = $this->parentFileId;
        $res['part_info_list'] = [];
        if (null !== $this->partInfoList && \is_array($this->partInfoList)) {
            $n = 0;
            foreach ($this->partInfoList as $item) {
                $res['part_info_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['rapid_upload'] = $this->rapidUpload;
        $res['type']         = $this->type;
        $res['upload_id']    = $this->uploadId;

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
        if (isset($map['file_id'])) {
            $model->fileId = $map['file_id'];
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
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['upload_id'])) {
            $model->uploadId = $map['upload_id'];
        }

        return $model;
    }
}
