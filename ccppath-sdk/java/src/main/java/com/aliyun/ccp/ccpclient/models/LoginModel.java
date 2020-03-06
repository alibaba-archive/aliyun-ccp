// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class LoginModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AccountAccessTokenResponse body;

    public static LoginModel build(java.util.Map<String, ?> map) throws Exception {
        LoginModel self = new LoginModel();
        return TeaModel.build(map, self);
    }

}
