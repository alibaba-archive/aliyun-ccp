// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class SetPasswordRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DefaultSetPasswordRequest body;

    public static SetPasswordRequestModel build(java.util.Map<String, ?> map) throws Exception {
        SetPasswordRequestModel self = new SetPasswordRequestModel();
        return TeaModel.build(map, self);
    }

}
