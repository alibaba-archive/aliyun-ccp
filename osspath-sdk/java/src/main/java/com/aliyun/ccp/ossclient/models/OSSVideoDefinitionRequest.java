// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 获取视频分辨率列表
 */
public class OSSVideoDefinitionRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("protection_scheme")
    public String protectionScheme;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-Z-]+")
    public String shareId;

    public static OSSVideoDefinitionRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoDefinitionRequest self = new OSSVideoDefinitionRequest();
        return TeaModel.build(map, self);
    }

}
