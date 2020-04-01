<?php

// This file is auto-generated, don't edit it. Thanks.

namespace Aliyun\CCP\SDK\CCP;

use AlibabaCloud\Tea\Model;

class ImageFaceGroupResponse extends Model
{
    public $createdAt;
    public $faceCount;
    public $groupCoverUrl;
    public $groupId;
    public $groupName;
    public $updatedAt;
    protected $_name = [
        'createdAt'     => 'created_at',
        'faceCount'     => 'face_count',
        'groupCoverUrl' => 'group_cover_url',
        'groupId'       => 'group_id',
        'groupName'     => 'group_name',
        'updatedAt'     => 'updated_at',
    ];
    protected $_description = [
        'createdAt'     => '人脸分组生成时间',
        'faceCount'     => '人脸个数',
        'groupCoverUrl' => '人脸分组封面头像地址',
        'groupId'       => '人脸分组 ID',
        'groupName'     => '人脸分组名称',
        'updatedAt'     => '人脸分组修改时间',
    ];
    protected $_example = [
        'createdAt'     => '2019-02-20T09:35:51.057Z',
        'faceCount'     => 2,
        'groupCoverUrl' => 'http://imm-dev-wmt/facegroup/05.jpg?x-oss-process=xxx',
        'groupId'       => 'abc',
        'groupName'     => 'abc',
        'updatedAt'     => '2019-02-20T09:35:51.057Z',
    ];
    protected $_format = [
        'faceCount' => 'int64',
    ];
}
