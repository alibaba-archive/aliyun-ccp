// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class VerifyCodeRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public VerifyCodeRequest body;

    public static VerifyCodeRequestModel build(java.util.Map<String, ?> map) throws Exception {
        VerifyCodeRequestModel self = new VerifyCodeRequestModel();
        return TeaModel.build(map, self);
    }

}
