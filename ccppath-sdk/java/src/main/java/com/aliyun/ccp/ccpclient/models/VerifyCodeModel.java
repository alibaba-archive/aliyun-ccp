// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class VerifyCodeModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public VerifyCodeResponse body;

    public static VerifyCodeModel build(java.util.Map<String, ?> map) throws Exception {
        VerifyCodeModel self = new VerifyCodeModel();
        return TeaModel.build(map, self);
    }

}
