// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateUserModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateUserResponse body;

    public static CreateUserModel build(java.util.Map<String, ?> map) throws Exception {
        CreateUserModel self = new CreateUserModel();
        return TeaModel.build(map, self);
    }

}
