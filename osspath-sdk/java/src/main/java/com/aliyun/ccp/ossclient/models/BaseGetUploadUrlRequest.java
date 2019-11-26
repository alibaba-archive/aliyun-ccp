// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class BaseGetUploadUrlRequest extends TeaModel {
    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("upload_id")
    @Validation(required = true)
    public String uploadId;

}
