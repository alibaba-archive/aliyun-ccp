// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetDownloadUrlRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("expire_sec")
    public Long expireSec;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("file_name")
    @Validation(required = true, pattern = "[a-zA-Z0-9.-]{1,1024}")
    public String fileName;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("share_id")
    public String shareId;

}

