<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\OSSClient\OSSClient;

use AlibabaCloud\Tea\Model;

class UploadPartInfo extends Model
{
    /**
     * @description etag
     *
     * @example 0CC175B9C0F1B6A831C399E269772661
     *
     * @var string
     */
    public $etag;
    /**
     * @description PartNumber
     *
     * @example 1
     *
     * @var int
     */
    public $partNumber;
    /**
     * @description PartSize：
     *
     * @example 1024
     *
     * @var int
     */
    public $partSize;
    /**
     * @description upload_url
     *
     * @example https://ccp.data.aliyuncs.com/xxx/xxx?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx&partNumber=1&uploadId=0CC175B9C0F1B6A831C399E269772661
     *
     * @var string
     */
    public $uploadUrl;
    protected $_name = [
        'etag'       => 'etag',
        'partNumber' => 'part_number',
        'partSize'   => 'part_size',
        'uploadUrl'  => 'upload_url',
    ];

    public function validate()
    {
        Model::validateField($this->partNumber, 'pattern', '[0-9]+');
    }

    public function toMap()
    {
        $res                = [];
        $res['etag']        = $this->etag;
        $res['part_number'] = $this->partNumber;
        $res['part_size']   = $this->partSize;
        $res['upload_url']  = $this->uploadUrl;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadPartInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['etag'])) {
            $model->etag = $map['etag'];
        }
        if (isset($map['part_number'])) {
            $model->partNumber = $map['part_number'];
        }
        if (isset($map['part_size'])) {
            $model->partSize = $map['part_size'];
        }
        if (isset($map['upload_url'])) {
            $model->uploadUrl = $map['upload_url'];
        }

        return $model;
    }
}
