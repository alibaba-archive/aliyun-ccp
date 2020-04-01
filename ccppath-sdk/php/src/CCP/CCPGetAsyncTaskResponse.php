<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

/**
 * Get AsyncTask Response.
 */
class CCPGetAsyncTaskResponse extends Model
{
    public $asyncTaskId;
    public $message;
    public $state;
    protected $_name = [
        'asyncTaskId' => 'async_task_id',
        'message'     => 'message',
        'state'       => 'state',
    ];
    protected $_description = [
        'asyncTaskId' => 'async_task_id
type:string',
        'message' => 'message',
        'state'   => 'state',
    ];
    protected $_example = [
        'asyncTaskId' => '000e89fb-cf8f-11e9-8ab4-b6e980803a3b',
        'message'     => 'task is running',
        'state'       => 'success',
    ];
    protected $_enum = [
        'state' => 'Running, Failed, Succeed',
    ];
}
