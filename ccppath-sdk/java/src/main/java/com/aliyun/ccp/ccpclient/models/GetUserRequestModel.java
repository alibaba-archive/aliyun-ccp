// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetUserRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserRequest body;

    public static GetUserRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetUserRequestModel self = new GetUserRequestModel();
        return TeaModel.build(map, self);
    }

}
