// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OSSListUploadedPartRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("file_path")
    @Validation(pattern = "", maxLength = 0)
    public String filePath;

    @NameInMap("limit")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public Long limit;

    @NameInMap("part_number_marker")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public Long partNumberMarker;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-z-]+", maxLength = 0)
    public String shareId;

    @NameInMap("upload_id")
    @Validation(pattern = "", maxLength = 0)
    public String uploadId;

}

