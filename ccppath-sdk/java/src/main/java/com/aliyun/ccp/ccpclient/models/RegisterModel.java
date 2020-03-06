// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class RegisterModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AccountAccessTokenResponse body;

    public static RegisterModel build(java.util.Map<String, ?> map) throws Exception {
        RegisterModel self = new RegisterModel();
        return TeaModel.build(map, self);
    }

}
