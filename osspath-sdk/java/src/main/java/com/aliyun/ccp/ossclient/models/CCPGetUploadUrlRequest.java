// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPGetUploadUrlRequest extends TeaModel {
    @NameInMap("content_md5")
    public String contentMd5;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("upload_id")
    public String uploadId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1,50}")
    public String fileId;

}

