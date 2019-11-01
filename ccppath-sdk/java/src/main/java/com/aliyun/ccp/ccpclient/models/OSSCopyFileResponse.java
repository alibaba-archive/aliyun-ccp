// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OSSCopyFileResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("async_task_id")
    @Validation(pattern = "", maxLength = 0)
    public String asyncTaskId;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9A-Z-]+", maxLength = 0)
    public String domainId;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("file_path")
    @Validation(pattern = "", maxLength = 0)
    public String filePath;

    @NameInMap("share_id")
    @Validation(pattern = "[a-z0-9A-Z]+", maxLength = 0)
    public String shareId;

}

