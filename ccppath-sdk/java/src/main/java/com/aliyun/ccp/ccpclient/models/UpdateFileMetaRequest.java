// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateFileMetaRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("hidden")
    public boolean hidden;

    @NameInMap("meta")
    public String meta;

    @NameInMap("name")
    @Validation(required = true, pattern = "[a-zA-Z0-9.-]{1,1000}")
    public String name;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("starred")
    public boolean starred;

    @NameInMap("tags")
    public java.util.Map<String, Object> tags;

}

