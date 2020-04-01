<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 获取文件元数据response.
 */
class OSSGetFileResponse extends Model
{
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
    public $filePath;
    public $name;
    public $parentFilePath;
    public $shareId;
    public $size;
    public $status;
    public $thumbnail;
    public $trashedAt;
    public $type;
    public $updatedAt;
    public $uploadId;
    public $url;
    protected $_name = [
        'contentHash'     => 'content_hash',
        'contentHashName' => 'content_hash_name',
        'contentType'     => 'content_type',
        'crc64Hash'       => 'crc64_hash',
        'createdAt'       => 'created_at',
        'description'     => 'description',
        'domainId'        => 'domain_id',
        'downloadUrl'     => 'download_url',
        'driveId'         => 'drive_id',
        'fileExtension'   => 'file_extension',
        'filePath'        => 'file_path',
        'name'            => 'name',
        'parentFilePath'  => 'parent_file_path',
        'shareId'         => 'share_id',
        'size'            => 'size',
        'status'          => 'status',
        'thumbnail'       => 'thumbnail',
        'trashedAt'       => 'trashed_at',
        'type'            => 'type',
        'updatedAt'       => 'updated_at',
        'uploadId'        => 'upload_id',
        'url'             => 'url',
    ];
    protected $_description = [
        'contentHash'     => 'Content Hash',
        'contentHashName' => 'content_hash_name',
        'contentType'     => 'content_type',
        'crc64Hash'       => 'crc64_hash',
        'createdAt'       => 'created_at',
        'description'     => 'description',
        'domainId'        => 'domain_id',
        'downloadUrl'     => 'download_url',
        'driveId'         => 'drive_id',
        'fileExtension'   => 'file_extension',
        'filePath'        => 'file_path',
        'name'            => 'name',
        'parentFilePath'  => 'parent_file_id',
        'shareId'         => 'share_id',
        'size'            => 'Size',
        'status'          => 'status',
        'thumbnail'       => 'thumbnail',
        'trashedAt'       => 'trashed_at',
        'type'            => 'type',
        'updatedAt'       => 'updated_at',
        'uploadId'        => 'upload_id',
        'url'             => 'url',
    ];
    protected $_example = [
        'contentHash'     => 'EA4942AA8761213890A5C386F88E6464D2C31CA3',
        'contentHashName' => 'sha1',
        'contentType'     => 'application/json',
        'createdAt'       => '2019-08-20T06:51:27.292Z',
        'description'     => 'file description',
        'domainId'        => 'test001',
        'downloadUrl'     => 'https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx',
        'driveId'         => '1',
        'fileExtension'   => 'jpg',
        'filePath'        => '/a.jpg',
        'name'            => 'ccp.jpg',
        'parentFilePath'  => '/',
        'shareId'         => '5d5b846942cf94fa72324c14a4bda34e81da635d',
        'size'            => 1024,
        'status'          => 'available',
        'thumbnail'       => 'https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx',
        'type'            => 'file',
        'uploadId'        => 'C9DCFE5A82644AC7A02DB74C30C934A6',
        'url'             => 'https://ccp.data.aliyuncs.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx',
    ];
    protected $_enum = [
        'contentHashName' => 'sha1',
        'status'          => 'uploading, available',
        'type'            => 'file, folder',
    ];
    protected $_pattern = [
        'domainId'       => '[a-z0-9A-Z]+',
        'driveId'        => '[0-9]+',
        'name'           => '[a-zA-Z0-9.-]{1,1024}',
        'parentFilePath' => '[a-z0-9]{1, 50}',
        'shareId'        => '[0-9]+',
    ];
    protected $_maxLength = [
        'parentFilePath' => 50,
    ];
    protected $_minLength = [
        'parentFilePath' => 40,
    ];
    protected $_format = [
        'size'      => 'int64',
        'trashedAt' => 'date-time',
        'updatedAt' => 'date-time',
    ];
    protected $_maximum = [
        'size' => 53687091200,
    ];
    protected $_minimum = [
        'size' => 0,
    ];
}
