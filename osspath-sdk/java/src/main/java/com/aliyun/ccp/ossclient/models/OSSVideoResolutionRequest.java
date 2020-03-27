// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 获取视频分辨率列表
 */
public class OSSVideoResolutionRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-Z-]+")
    public String shareId;

    public static OSSVideoResolutionRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoResolutionRequest self = new OSSVideoResolutionRequest();
        return TeaModel.build(map, self);
    }

}
