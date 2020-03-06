// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 删除文件 response
 */
public class OSSDeleteFileResponse extends TeaModel {
    @NameInMap("async_task_id")
    public String asyncTaskId;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9A-Z]+")
    public String domainId;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("share_id")
    @Validation(pattern = "[a-z0-9A-Z]+")
    public String shareId;

    public static OSSDeleteFileResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSDeleteFileResponse self = new OSSDeleteFileResponse();
        return TeaModel.build(map, self);
    }

}
