// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetUserModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserResponse body;

    public static GetUserModel build(java.util.Map<String, ?> map) throws Exception {
        GetUserModel self = new GetUserModel();
        return TeaModel.build(map, self);
    }

}
