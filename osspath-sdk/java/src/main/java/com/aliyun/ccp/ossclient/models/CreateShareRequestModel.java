// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateShareRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateShareRequest body;

    public static CreateShareRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CreateShareRequestModel self = new CreateShareRequestModel();
        return TeaModel.build(map, self);
    }

}
