// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSGetDownloadUrlRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("expire_sec")
    @Validation(pattern = "", maxLength = 0)
    public Long expireSec;

    @NameInMap("file_name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1024}", maxLength = 0)
    public String fileName;

    @NameInMap("file_path")
    @Validation(pattern = "[a-z0-9.-_]{1,50}", maxLength = 0)
    public String filePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-z-]+", maxLength = 0)
    public String shareId;

}

