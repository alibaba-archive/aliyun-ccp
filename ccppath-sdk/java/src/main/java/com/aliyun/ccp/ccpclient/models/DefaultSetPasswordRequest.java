// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
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

    public static DefaultSetPasswordRequest build(java.util.Map<String, ?> map) throws Exception {
        DefaultSetPasswordRequest self = new DefaultSetPasswordRequest();
        return TeaModel.build(map, self);
    }

}
