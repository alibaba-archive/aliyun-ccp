// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class TokenRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public TokenRequest body;

    public static TokenRequestModel build(java.util.Map<String, ?> map) throws Exception {
        TokenRequestModel self = new TokenRequestModel();
        return TeaModel.build(map, self);
    }

}
