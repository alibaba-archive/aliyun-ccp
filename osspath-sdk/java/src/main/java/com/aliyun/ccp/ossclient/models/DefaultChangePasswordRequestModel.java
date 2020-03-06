// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DefaultChangePasswordRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DefaultChangePasswordRequest body;

    public static DefaultChangePasswordRequestModel build(java.util.Map<String, ?> map) throws Exception {
        DefaultChangePasswordRequestModel self = new DefaultChangePasswordRequestModel();
        return TeaModel.build(map, self);
    }

}
