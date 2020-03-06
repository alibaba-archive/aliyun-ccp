// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateUserRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateUserRequest body;

    public static CreateUserRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CreateUserRequestModel self = new CreateUserRequestModel();
        return TeaModel.build(map, self);
    }

}
