// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPDeleteFileResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("async_task_id")
    public String asyncTaskId;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9A-Z]+")
    public String domainId;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}")
    public String fileId;

    public static CCPDeleteFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPDeleteFileResponse self = new CCPDeleteFileResponse();
        return TeaModel.build(map, self);
    }

}
