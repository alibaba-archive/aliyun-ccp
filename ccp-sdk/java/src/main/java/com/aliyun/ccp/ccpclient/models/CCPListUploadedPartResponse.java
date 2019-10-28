// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPListUploadedPartResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("file_id")
    public String fileId;

    @NameInMap("next_part_number_marker")
    public String nextPartNumberMarker;

    @NameInMap("upload_id")
    public String uploadId;

    @NameInMap("uploaded_parts")
    public UploadPartInfo[] uploadedParts;

}

