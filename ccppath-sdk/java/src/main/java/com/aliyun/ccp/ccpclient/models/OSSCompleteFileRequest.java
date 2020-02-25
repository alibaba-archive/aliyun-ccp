// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OSSCompleteFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("upload_id")
    public String uploadId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("share_id")
    public String shareId;

    public static OSSCompleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSCompleteFileRequest self = new OSSCompleteFileRequest();
        return TeaModel.build(map, self);
    }

}
