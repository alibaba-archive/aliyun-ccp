// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class BaseMoveFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("new_name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1000}")
    public String newName;

    @NameInMap("overwrite")
    public boolean overwrite;

}

