// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DeleteUserRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteUserRequest body;

    public static DeleteUserRequestModel build(java.util.Map<String, ?> map) throws Exception {
        DeleteUserRequestModel self = new DeleteUserRequestModel();
        return TeaModel.build(map, self);
    }

}
