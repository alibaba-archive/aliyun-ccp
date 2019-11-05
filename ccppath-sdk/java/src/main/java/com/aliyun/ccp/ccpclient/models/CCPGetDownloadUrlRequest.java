// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPGetDownloadUrlRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("expire_sec")
    @Validation(pattern = "", maxLength = 0)
    public Long expireSec;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9.-_]{1,50}", maxLength = 0)
    public String fileId;

    @NameInMap("file_name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1024}", maxLength = 0)
    public String fileName;

}

