// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 获取文件上传URL
 */
public class BaseGetUploadUrlRequest extends TeaModel {
    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("upload_id")
    @Validation(required = true)
    public String uploadId;

    public static BaseGetUploadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        BaseGetUploadUrlRequest self = new BaseGetUploadUrlRequest();
        return TeaModel.build(map, self);
    }

}
