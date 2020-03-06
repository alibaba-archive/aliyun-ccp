// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 删除文件请求
 */
public class CCPDeleteFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("permanently")
    public Boolean permanently;

    public static CCPDeleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPDeleteFileRequest self = new CCPDeleteFileRequest();
        return TeaModel.build(map, self);
    }

}
