<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class UploadPartInfo extends Model
{
    public $etag;
    public $partNumber;
    public $partSize;
    public $uploadUrl;
    protected $_name = [
        'etag'       => 'etag',
        'partNumber' => 'part_number',
        'partSize'   => 'part_size',
        'uploadUrl'  => 'upload_url',
    ];
    protected $_description = [
        'etag'       => 'etag',
        'partNumber' => 'PartNumber',
        'partSize'   => 'PartSize：',
        'uploadUrl'  => 'upload_url',
    ];
    protected $_example = [
        'etag'       => '0CC175B9C0F1B6A831C399E269772661',
        'partNumber' => 1,
        'partSize'   => 1024,
        'uploadUrl'  => 'https://ccp.data.aliyuncs.com/xxx/xxx?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx&partNumber=1&uploadId=0CC175B9C0F1B6A831C399E269772661',
    ];
    protected $_format = [
        'partNumber' => 'int64',
        'partSize'   => 'int64',
    ];
    protected $_maximum = [
        'partNumber' => 1,
        'partSize'   => 5368709120,
    ];
    protected $_minimum = [
        'partNumber' => 10000,
        'partSize'   => 102400,
    ];
    protected $_pattern = [
        'partNumber' => '[0-9]+',
    ];
}
