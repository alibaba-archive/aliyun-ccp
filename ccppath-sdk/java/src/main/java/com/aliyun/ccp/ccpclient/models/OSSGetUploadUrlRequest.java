// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OSSGetUploadUrlRequest extends TeaModel {
    @NameInMap("content_md5")
    @Validation(pattern = "", maxLength = 0)
    public String contentMd5;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("part_info_list")
    @Validation(pattern = "", maxLength = 0)
    public UploadPartInfo[] partInfoList;

    @NameInMap("upload_id")
    @Validation(pattern = "", maxLength = 0)
    public String uploadId;

    @NameInMap("file_path")
    @Validation(pattern = "", maxLength = 0)
    public String filePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String shareId;

}

