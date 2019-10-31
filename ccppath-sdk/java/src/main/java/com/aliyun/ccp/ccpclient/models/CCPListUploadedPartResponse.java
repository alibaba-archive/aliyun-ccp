// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPListUploadedPartResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}", maxLength = 0)
    public String fileId;

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

