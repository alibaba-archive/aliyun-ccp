// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class CreateAppRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateAppRequest body;

    public static CreateAppRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CreateAppRequestModel self = new CreateAppRequestModel();
        return TeaModel.build(map, self);
    }

}
