// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class LoginRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public MobileLoginRequest body;

    public static LoginRequestModel build(java.util.Map<String, ?> map) throws Exception {
        LoginRequestModel self = new LoginRequestModel();
        return TeaModel.build(map, self);
    }

}
