<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * list share request.
 */
class ListShareRequest extends Model
{
    public $creator;
    public $driveId;
    public $limit;
    public $marker;
    public $owner;
    public $shareFilePath;
    protected $_name = [
        'creator'       => 'creator',
        'driveId'       => 'drive_id',
        'limit'         => 'limit',
        'marker'        => 'marker',
        'owner'         => 'owner',
        'shareFilePath' => 'share_file_path',
    ];
    protected $_description = [
        'creator'       => 'creator',
        'limit'         => 'limit',
        'marker'        => 'marker',
        'owner'         => 'Owner',
        'shareFilePath' => 'share_file_path',
    ];
    protected $_example = [
        'creator'       => 'tom',
        'driveId'       => '1',
        'limit'         => 50,
        'owner'         => 'jack',
        'shareFilePath' => '/a/b/',
    ];
    protected $_pattern = [
        'driveId' => '[0-9]+',
    ];
    protected $_required = [
        'limit' => true,
    ];
    protected $_format = [
        'limit' => 'int32',
    ];
    protected $_maximum = [
        'limit' => 100,
    ];
    protected $_minimum = [
        'limit' => 1,
    ];
}
