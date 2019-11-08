// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OSSGetDownloadUrlRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("expire_sec")
    public Long expireSec;

    @NameInMap("file_name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1000}")
    public String fileName;

    @NameInMap("file_path")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String filePath;

    @NameInMap("share_id")
    @Validation(required = true, pattern = "[0-9a-z-]+")
    public String shareId;

}

