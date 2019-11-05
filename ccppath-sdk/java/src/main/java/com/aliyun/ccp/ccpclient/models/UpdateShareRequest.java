// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateShareRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("expiration")
    public String expiration;

    @NameInMap("permissions")
    public String[] permissions;

    @NameInMap("share_id")
    @Validation(required = true)
    public String shareId;

    @NameInMap("share_name")
    public String shareName;

    @NameInMap("status")
    public String status;

}

