// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DownloadRequest extends TeaModel {
    @NameInMap("DriveID")
    @Validation(required = true, pattern = "[0-9]+")
    public String DriveID;

    @NameInMap("FileID")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String FileID;

    @NameInMap("ImageProcess")
    public String ImageProcess;

    @NameInMap("ShareID")
    public String ShareID;

    public static DownloadRequest build(java.util.Map<String, ?> map) throws Exception {
        DownloadRequest self = new DownloadRequest();
        return TeaModel.build(map, self);
    }

}
