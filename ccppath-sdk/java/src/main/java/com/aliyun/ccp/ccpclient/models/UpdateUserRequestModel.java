// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateUserRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateUserRequest body;

    public static UpdateUserRequestModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserRequestModel self = new UpdateUserRequestModel();
        return TeaModel.build(map, self);
    }

}
