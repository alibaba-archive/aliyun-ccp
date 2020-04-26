// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * Create file response
 */
public class OSSCreateFileResponse extends TeaModel {
    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9]{1,50}")
    public String domainId;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9]+")
    public String shareId;

    @NameInMap("type")
    public String type;

    @NameInMap("upload_id")
    public String uploadId;

    public static OSSCreateFileResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSCreateFileResponse self = new OSSCreateFileResponse();
        return TeaModel.build(map, self);
    }

}
