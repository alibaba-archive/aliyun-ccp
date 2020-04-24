// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * complete file request
 */
public class BaseCompleteFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("upload_id")
    public String uploadId;

    public static BaseCompleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        BaseCompleteFileRequest self = new BaseCompleteFileRequest();
        return TeaModel.build(map, self);
    }

}
