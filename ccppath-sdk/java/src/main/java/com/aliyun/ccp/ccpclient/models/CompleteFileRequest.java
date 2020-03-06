// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * complete file request
 */
public class CompleteFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9]{1,50}")
    public String fileId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("upload_id")
    @Validation(required = true)
    public String uploadId;

    public static CompleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CompleteFileRequest self = new CompleteFileRequest();
        return TeaModel.build(map, self);
    }

}
