// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DownloadFileRequest extends TeaModel {
    @NameInMap("DriveID")
    @Validation(required = true)
    public String DriveID;

    @NameInMap("FileID")
    @Validation(required = true)
    public String FileID;

    @NameInMap("ImageProcess")
    public String ImageProcess;

    public static DownloadFileRequest build(java.util.Map<String, ?> map) throws Exception {
        DownloadFileRequest self = new DownloadFileRequest();
        return TeaModel.build(map, self);
    }

}
