// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPCreateFileResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9]{1, 50}")
    public String domainId;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}")
    public String fileId;

    @NameInMap("parent_file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}")
    public String parentFileId;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("rapid_upload")
    public boolean rapidUpload;

    @NameInMap("type")
    public String type;

    @NameInMap("upload_id")
    public String uploadId;

    public static CCPCreateFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPCreateFileResponse self = new CCPCreateFileResponse();
        return TeaModel.build(map, self);
    }

}
