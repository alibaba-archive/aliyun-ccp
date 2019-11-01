// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPDeleteFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9.-_]{1, 50}", maxLength = 0)
    public String fileId;

    @NameInMap("permanently")
    @Validation(pattern = "", maxLength = 0)
    public boolean permanently;

}

