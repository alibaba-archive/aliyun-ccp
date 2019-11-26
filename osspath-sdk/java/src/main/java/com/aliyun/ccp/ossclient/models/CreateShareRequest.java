// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateShareRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("expiration")
    public String expiration;

    @NameInMap("owner")
    @Validation(required = true)
    public String owner;

    @NameInMap("permissions")
    public String[] permissions;

    @NameInMap("share_file_path")
    @Validation(required = true)
    public String shareFilePath;

    @NameInMap("share_name")
    public String shareName;

    @NameInMap("status")
    public String status;

}
