// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DefaultSetPasswordRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DefaultSetPasswordRequest body;

    public static DefaultSetPasswordRequestModel build(java.util.Map<String, ?> map) throws Exception {
        DefaultSetPasswordRequestModel self = new DefaultSetPasswordRequestModel();
        return TeaModel.build(map, self);
    }

}
