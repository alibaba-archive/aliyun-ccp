// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSListUploadedPartRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("limit")
    @Validation(required = true, pattern = "[0-9]+")
    public Long limit;

    @NameInMap("part_number_marker")
    @Validation(pattern = "[0-9]+")
    public Long partNumberMarker;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-z-]+")
    public String shareId;

    @NameInMap("upload_id")
    public String uploadId;

}
