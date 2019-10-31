// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSListUploadedPartResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("file_path")
    @Validation(pattern = "", maxLength = 0)
    public String filePath;

    @NameInMap("next_part_number_marker")
    @Validation(pattern = "", maxLength = 0)
    public String nextPartNumberMarker;

    @NameInMap("upload_id")
    @Validation(pattern = "", maxLength = 0)
    public String uploadId;

    @NameInMap("uploaded_parts")
    @Validation(pattern = "", maxLength = 0)
    public UploadPartInfo[] uploadedParts;

}

