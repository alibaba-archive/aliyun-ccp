// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetUserAccessTokenModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AccessTokenResponse body;

    public static GetUserAccessTokenModel build(java.util.Map<String, ?> map) throws Exception {
        GetUserAccessTokenModel self = new GetUserAccessTokenModel();
        return TeaModel.build(map, self);
    }

}
