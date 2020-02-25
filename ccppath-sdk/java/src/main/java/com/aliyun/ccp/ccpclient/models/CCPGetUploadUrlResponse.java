// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPGetUploadUrlResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("create_at")
    public String createAt;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9A-Z]+")
    public String domainId;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}")
    public String fileId;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("upload_id")
    public String uploadId;

    public static CCPGetUploadUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPGetUploadUrlResponse self = new CCPGetUploadUrlResponse();
        return TeaModel.build(map, self);
    }

}
