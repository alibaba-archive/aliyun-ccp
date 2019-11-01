// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CreateShareRequest extends TeaModel {
    @NameInMap("description")
    @Validation(pattern = "", maxLength = 0)
    public String description;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("expiration")
    @Validation(pattern = "", maxLength = 0)
    public String expiration;

    @NameInMap("owner")
    @Validation(pattern = "", maxLength = 0)
    public String owner;

    @NameInMap("permissions")
    @Validation(pattern = "", maxLength = 0)
    public String[] permissions;

    @NameInMap("share_file_path")
    @Validation(pattern = "", maxLength = 0)
    public String shareFilePath;

    @NameInMap("share_name")
    @Validation(pattern = "", maxLength = 0)
    public String shareName;

    @NameInMap("status")
    @Validation(pattern = "", maxLength = 0)
    public String status;

}

