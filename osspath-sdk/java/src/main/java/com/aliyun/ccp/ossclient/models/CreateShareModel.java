// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateShareModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateShareResponse body;

    public static CreateShareModel build(java.util.Map<String, ?> map) throws Exception {
        CreateShareModel self = new CreateShareModel();
        return TeaModel.build(map, self);
    }

}
