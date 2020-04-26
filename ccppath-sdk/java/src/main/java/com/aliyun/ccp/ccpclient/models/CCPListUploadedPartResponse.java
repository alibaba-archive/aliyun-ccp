// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 获取签名 response
 */
public class CCPListUploadedPartResponse extends TeaModel {
    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1,50}")
    public String fileId;

    @NameInMap("next_part_number_marker")
    public String nextPartNumberMarker;

    @NameInMap("upload_id")
    public String uploadId;

    @NameInMap("uploaded_parts")
    public java.util.List<UploadPartInfo> uploadedParts;

    public static CCPListUploadedPartResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPListUploadedPartResponse self = new CCPListUploadedPartResponse();
        return TeaModel.build(map, self);
    }

}
