// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OSSGetUploadUrlRequest extends TeaModel {
    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("upload_id")
    public String uploadId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9]+")
    public String shareId;

    public static OSSGetUploadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSGetUploadUrlRequest self = new OSSGetUploadUrlRequest();
        return TeaModel.build(map, self);
    }

}
