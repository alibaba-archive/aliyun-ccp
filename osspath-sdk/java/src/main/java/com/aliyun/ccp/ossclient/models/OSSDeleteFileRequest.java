// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSDeleteFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,1000}")
    public String filePath;

    @NameInMap("permanently")
    public boolean permanently;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-z-]+")
    public String shareId;

    public static OSSDeleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSDeleteFileRequest self = new OSSDeleteFileRequest();
        return TeaModel.build(map, self);
    }

}
