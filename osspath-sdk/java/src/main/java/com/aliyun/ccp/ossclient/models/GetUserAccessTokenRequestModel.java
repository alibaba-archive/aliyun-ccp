// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetUserAccessTokenRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserAccessTokenRequest body;

    public static GetUserAccessTokenRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetUserAccessTokenRequestModel self = new GetUserAccessTokenRequestModel();
        return TeaModel.build(map, self);
    }

}
