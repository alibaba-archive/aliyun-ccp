<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 列举uploadID对应的已上传分片.
 */
class CCPListUploadedPartRequest extends Model
{
    public $driveId;
    public $fileId;
    public $limit;
    public $partNumberMarker;
    public $uploadId;
    protected $_required = [
        'driveId' => true,
        'fileId'  => true,
        'limit'   => true,
    ];
    protected $_name = [
        'driveId'          => 'drive_id',
        'fileId'           => 'file_id',
        'limit'            => 'limit',
        'partNumberMarker' => 'part_number_marker',
        'uploadId'         => 'upload_id',
    ];
    protected $_description = [
        'driveId'          => 'drive_id',
        'fileId'           => 'file_id',
        'limit'            => 'limit',
        'partNumberMarker' => 'part_number_marker',
        'uploadId'         => 'upload_id',
    ];
    protected $_example = [
        'driveId'          => '1',
        'fileId'           => '5d5b846942cf94fa72324c14a4bda34e81da635d',
        'limit'            => 1,
        'partNumberMarker' => 1,
        'uploadId'         => '00668396C0814D818D90F0A92B04B355',
    ];
    protected $_pattern = [
        'driveId'          => '[0-9]+',
        'fileId'           => '[a-z0-9.-_]{1,50}',
        'limit'            => '[0-9]+',
        'partNumberMarker' => '[0-9]+',
    ];
    protected $_maxLength = [
        'fileId' => 50,
    ];
    protected $_minLength = [
        'fileId' => 40,
    ];
    protected $_default = [
        'limit' => 1000,
    ];
    protected $_format = [
        'limit'            => 'int64',
        'partNumberMarker' => 'int64',
    ];
    protected $_maximum = [
        'limit' => 1000,
    ];
    protected $_minimum = [
        'limit'            => 1,
        'partNumberMarker' => 1,
    ];
}
