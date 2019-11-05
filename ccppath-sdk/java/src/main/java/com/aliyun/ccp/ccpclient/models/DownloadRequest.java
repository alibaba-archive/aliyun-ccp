// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DownloadRequest extends TeaModel {
    @NameInMap("DriveID")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String DriveID;

    @NameInMap("FileID")
    @Validation(pattern = "[a-z0-9.-_]{1,50}", maxLength = 0)
    public String FileID;

    @NameInMap("ImageProcess")
    @Validation(pattern = "", maxLength = 0)
    public String ImageProcess;

    @NameInMap("ShareID")
    @Validation(pattern = "", maxLength = 0)
    public String ShareID;

}

