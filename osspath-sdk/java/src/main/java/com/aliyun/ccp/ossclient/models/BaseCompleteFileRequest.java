// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class BaseCompleteFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("upload_id")
    public String uploadId;

    public static BaseCompleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        BaseCompleteFileRequest self = new BaseCompleteFileRequest();
        return TeaModel.build(map, self);
    }

}
