// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class UpdateUserModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateUserResponse body;

    public static UpdateUserModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserModel self = new UpdateUserModel();
        return TeaModel.build(map, self);
    }

}
