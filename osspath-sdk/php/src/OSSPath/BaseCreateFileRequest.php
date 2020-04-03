<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\OSSPath;

use AlibabaCloud\Tea\Model;

/**
 * create file request.
 */
class BaseCreateFileRequest extends Model
{
    /**
     * @description ContentMd5
     *
     * @example E10ADC3949BA59ABBE56E057F20F883E
     *
     * @var string
     */
    public $contentMd5;
    /**
     * @description ContentType
     *
     * @example application/json
     *
     * @var string
     */
    public $contentType;
    /**
     * @description Name
     *
     * @example ccp.jpg
     *
     * @var string
     */
    public $name;
    /**
     * @description part_info_list
     *
     * @var array
     */
    public $partInfoList;
    /**
     * @description Size
     *
     * @var int
     */
    public $size;
    /**
     * @description Type
     *
     * @example file
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'contentMd5'   => 'content_md5',
        'contentType'  => 'content_type',
        'name'         => 'name',
        'partInfoList' => 'part_info_list',
        'size'         => 'size',
        'type'         => 'type',
    ];

    public function validate()
    {
        Model::validateRequired('contentMd5', $this->contentMd5, true);
        Model::validateRequired('contentType', $this->contentType, true);
        Model::validateRequired('name', $this->name, true);
        Model::validateRequired('size', $this->size, true);
        Model::validateRequired('type', $this->type, true);
    }

    public function toMap()
    {
        $res                   = [];
        $res['content_md5']    = $this->contentMd5;
        $res['content_type']   = $this->contentType;
        $res['name']           = $this->name;
        $res['part_info_list'] = [];
        if (null !== $this->partInfoList && \is_array($this->partInfoList)) {
            $n = 0;
            foreach ($this->partInfoList as $item) {
                $res['part_info_list'][$n++] = null !== $item ? $item->toMap() : $item;
            }
        }
        $res['size'] = $this->size;
        $res['type'] = $this->type;

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BaseCreateFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content_md5'])) {
            $model->contentMd5 = $map['content_md5'];
        }
        if (isset($map['content_type'])) {
            $model->contentType = $map['content_type'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['part_info_list'])) {
            if (!empty($map['part_info_list'])) {
                $model->partInfoList = [];
                $n                   = 0;
                foreach ($map['part_info_list'] as $item) {
                    $model->partInfoList[$n++] = null !== $item ? UploadPartInfo::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
