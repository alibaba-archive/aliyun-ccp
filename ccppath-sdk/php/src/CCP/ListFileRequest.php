<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * list file request.
 */
class ListFileRequest extends Model
{
    public $all;
    public $driveId;
    public $imageThumbnailProcess;
    public $imageUrlProcess;
    public $limit;
    public $marker;
    public $parentFileId;
    public $parentFilePath;
    public $shareId;
    public $status;
    protected $_name = [
        'all'                   => 'all',
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
        'parentFileId'          => 'parent_file_id',
        'parentFilePath'        => 'parent_file_path',
        'shareId'               => 'share_id',
        'status'                => 'status',
    ];
    protected $_description = [
        'all'                   => 'all',
        'driveId'               => 'drive_id',
        'imageThumbnailProcess' => 'image_thumbnail_process',
        'imageUrlProcess'       => 'image_url_process',
        'limit'                 => 'limit',
        'marker'                => 'marker',
        'parentFileId'          => 'ParentFileID',
        'status'                => 'status',
    ];
    protected $_enum = [
        'all'    => 'false,  true',
        'status' => 'uploading,  available',
    ];
    protected $_required = [
        'driveId'      => true,
        'parentFileId' => true,
    ];
    protected $_example = [
        'driveId' => '1',
    ];
    protected $_pattern = [
        'driveId'      => '[0-9]+',
        'limit'        => '[0-9]{1,3}',
        'parentFileId' => '[a-z0-9.-_]{1,50}',
    ];
    protected $_default = [
        'limit' => 50,
    ];
    protected $_format = [
        'limit' => 'int64',
    ];
    protected $_maximum = [
        'limit' => 100,
    ];
    protected $_minimum = [
        'limit' => 0,
    ];
    protected $_maxLength = [
        'parentFileId' => 50,
    ];
    protected $_minLength = [
        'parentFileId' => 40,
    ];
}
