// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DefaultSetPasswordRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("new_password")
    @Validation(required = true)
    public String newPassword;

    @NameInMap("state")
    @Validation(required = true)
    public String state;

}

