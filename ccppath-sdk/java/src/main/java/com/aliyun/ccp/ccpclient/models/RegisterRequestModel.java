// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class RegisterRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public MobileRegisterRequest body;

    public static RegisterRequestModel build(java.util.Map<String, ?> map) throws Exception {
        RegisterRequestModel self = new RegisterRequestModel();
        return TeaModel.build(map, self);
    }

}
