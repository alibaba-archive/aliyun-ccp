<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 更新文件元数据 response
 */
class CCPUpdateFileMetaResponse extends Model{
    protected $_name = [
        "category" => "category",
        "contentHash" => "content_hash",
        "contentHashName" => "content_hash_name",
        "contentType" => "content_type",
        "crc64Hash" => "crc64_hash",
        "createdAt" => "created_at",
        "description" => "description",
        "domainId" => "domain_id",
        "downloadUrl" => "download_url",
        "driveId" => "drive_id",
        "fileExtension" => "file_extension",
        "fileId" => "file_id",
        "hidden" => "hidden",
        "imageMediaMetadata" => "image_media_metadata",
        "labels" => "labels",
        "meta" => "meta",
        "name" => "name",
        "parentFileId" => "parent_file_id",
        "size" => "size",
        "starred" => "starred",
        "status" => "status",
        "thumbnail" => "thumbnail",
        "trashedAt" => "trashed_at",
        "type" => "type",
        "updatedAt" => "updated_at",
        "uploadId" => "upload_id",
        "url" => "url",
    ];
    protected $_description = [
        "category" => "category",
        "contentHash" => "Content Hash",
        "contentHashName" => "content_hash_name",
        "contentType" => "content_type",
        "crc64Hash" => "crc64_hash",
        "createdAt" => "created_at",
        "description" => "description",
        "domainId" => "DomainID",
        "downloadUrl" => "download_url",
        "driveId" => "drive_id",
        "fileExtension" => "file_extension",
        "fileId" => "file_id",
        "hidden" => "Hidden
type: boolean",
        "labels" => "labels",
        "meta" => "meta",
        "name" => "name",
        "parentFileId" => "parent_file_id",
        "size" => "Size",
        "starred" => "starred
type: boolean",
        "status" => "status",
        "thumbnail" => "thumbnail",
        "trashedAt" => "trashed_at",
        "type" => "type",
        "updatedAt" => "updated_at",
        "uploadId" => "upload_id",
        "url" => "url",
    ];
    protected $_enum = [
        "category" => "doc, image, audio, video",
        "contentHashName" => "sha1",
        "hidden" => "false, true",
        "status" => "uploading, available",
        "type" => "file, folder",
    ];
    protected $_example = [
        "category" => "doc",
        "contentHash" => "EA4942AA8761213890A5C386F88E6464D2C31CA3",
        "contentHashName" => "sha1",
        "contentType" => "application/json",
        "createdAt" => "2019-08-20T06:51:27.292Z",
        "description" => "file description",
        "domainId" => "test001",
        "downloadUrl" => "https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx",
        "driveId" => "1",
        "fileExtension" => "jpg",
        "fileId" => "5d5b846942cf94fa72324c14a4bda34e81da635d",
        "hidden" => "false",
        "labels" => "label1:1, label2:2",
        "meta" => "file meta",
        "name" => "ccp.jpg",
        "parentFileId" => "root",
        "size" => 1024,
        "starred" => "false",
        "status" => "available",
        "thumbnail" => "https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx",
        "type" => "file",
        "uploadId" => "C9DCFE5A82644AC7A02DB74C30C934A6",
        "url" => "https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx",
    ];
    protected $_pattern = [
        "domainId" => "[a-z0-9A-Z]+",
        "driveId" => "[0-9]+",
        "fileId" => "[a-z0-9]{1, 50}",
        "name" => "[a-zA-Z0-9.-]{1,1024}",
        "parentFileId" => "[a-z0-9]{1, 50}",
    ];
    protected $_maxLength = [
        "fileId" => 50,
        "parentFileId" => 50,
    ];
    protected $_minLength = [
        "fileId" => 40,
        "parentFileId" => 40,
    ];
    protected $_$ref = [
        "imageMediaMetadata" => "#/definitions/ImageMediaResponse",
    ];
    protected $_items = [
        "labels" => "{"type":"string"}",
    ];
    protected $_format = [
        "size" => "int64",
        "trashedAt" => "date-time",
        "updatedAt" => "date-time",
    ];
    protected $_maximum = [
        "size" => 53687091200,
    ];
    protected $_minimum = [
        "size" => 0,
    ];
    public $category;
    public $contentHash;
    public $contentHashName;
    public $contentType;
    public $crc64Hash;
    public $createdAt;
    public $description;
    public $domainId;
    public $downloadUrl;
    public $driveId;
    public $fileExtension;
    public $fileId;
    public $hidden;
    public $imageMediaMetadata;
    public $labels;
    public $meta;
    public $name;
    public $parentFileId;
    public $size;
    public $starred;
    public $status;
    public $thumbnail;
    public $trashedAt;
    public $type;
    public $updatedAt;
    public $uploadId;
    public $url;
}
