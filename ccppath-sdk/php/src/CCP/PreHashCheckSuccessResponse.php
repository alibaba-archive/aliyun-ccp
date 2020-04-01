<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Pre hash check Response.
 */
class PreHashCheckSuccessResponse extends Model
{
    public $code;
    public $fileName;
    public $message;
    public $parentFileId;
    public $preHash;
    protected $_name = [
        'code'         => 'code',
        'fileName'     => 'file_name',
        'message'      => 'message',
        'parentFileId' => 'parent_file_id',
        'preHash'      => 'pre_hash',
    ];
    protected $_description = [
        'code'         => 'code',
        'fileName'     => 'file_name',
        'message'      => 'message',
        'parentFileId' => 'parent_file_id',
        'preHash'      => 'pre_hash',
    ];
    protected $_required = [
        'parentFileId' => true,
    ];
    protected $_example = [
        'parentFileId' => '5d5b846942cf94fa72324c14a4bda34e81da635d',
    ];
    protected $_maxLength = [
        'parentFileId' => 50,
    ];
    protected $_minLength = [
        'parentFileId' => 40,
    ];
    protected $_pattern = [
        'parentFileId' => '[a-z0-9]{1, 50}',
    ];
}
