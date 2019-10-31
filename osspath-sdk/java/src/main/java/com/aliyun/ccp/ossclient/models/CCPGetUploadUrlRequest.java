// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPGetUploadUrlRequest extends TeaModel {
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

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}", maxLength = 0)
    public String fileId;

}

