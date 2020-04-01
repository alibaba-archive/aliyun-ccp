<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class DownloadFileQuery extends Model
{
    public $DriveID;
    public $FileID;
    public $ImageProcess;
    protected $_required = [
        'DriveID' => true,
        'FileID'  => true,
    ];
    protected $_name = [
        'DriveID'      => 'DriveID',
        'FileID'       => 'FileID',
        'ImageProcess' => 'ImageProcess',
    ];
    protected $_description = [
        'DriveID'      => 'drive id',
        'FileID'       => 'file id',
        'ImageProcess' => 'image process',
    ];
    protected $_example = [
        'DriveID'      => '1',
        'FileID'       => '5d79206586bb5dd69fb34c349282718146c55da7',
        'ImageProcess' => 'image/resize,w_200',
    ];
}
