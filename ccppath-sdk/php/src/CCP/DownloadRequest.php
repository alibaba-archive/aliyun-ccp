<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * 下载文件请求body.
 */
class DownloadRequest extends Model
{
    public $DriveID;
    public $FileID;
    public $ImageProcess;
    public $ShareID;
    protected $_required = [
        'DriveID' => true,
        'FileID'  => true,
    ];
    protected $_name = [
        'DriveID'      => 'DriveID',
        'FileID'       => 'FileID',
        'ImageProcess' => 'ImageProcess',
        'ShareID'      => 'ShareID',
    ];
    protected $_description = [
        'DriveID'      => 'drive_id',
        'FileID'       => 'file_id',
        'ImageProcess' => 'image_process',
    ];
    protected $_example = [
        'DriveID'      => '1',
        'ImageProcess' => 'image/resize,w_200',
    ];
    protected $_pattern = [
        'DriveID' => '[0-9]+',
        'FileID'  => '[a-z0-9.-_]{1,50}',
    ];
    protected $_maxLength = [
        'FileID' => 50,
    ];
    protected $_minLength = [
        'FileID' => 40,
    ];
}
