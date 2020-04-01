<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 列举uploadID对应的已上传分片.
 */
class OSSListUploadedPartRequest extends Model
{
    public $driveId;
    public $filePath;
    public $limit;
    public $partNumberMarker;
    public $shareId;
    public $uploadId;
    protected $_name = [
        'driveId'          => 'drive_id',
        'filePath'         => 'file_path',
        'limit'            => 'limit',
        'partNumberMarker' => 'part_number_marker',
        'shareId'          => 'share_id',
        'uploadId'         => 'upload_id',
    ];
    protected $_description = [
        'driveId'          => 'drive_id',
        'filePath'         => 'file_path',
        'limit'            => 'limit',
        'partNumberMarker' => 'part_number_marker',
        'shareId'          => 'share_id',
        'uploadId'         => 'upload_id',
    ];
    protected $_example = [
        'driveId'          => '1',
        'filePath'         => '/a/b/c.jpg',
        'limit'            => 1,
        'partNumberMarker' => 1,
        'shareId'          => '3d336314-63c8-4d96-bce0-17aefb6833b6',
        'uploadId'         => '00668396C0814D818D90F0A92B04B355',
    ];
    protected $_pattern = [
        'driveId'          => '[0-9]+',
        'limit'            => '[0-9]+',
        'partNumberMarker' => '[0-9]+',
        'shareId'          => '[0-9a-zA-z-]+',
    ];
    protected $_required = [
        'filePath' => true,
        'limit'    => true,
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
