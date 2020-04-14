// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class CreateAppModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAppResponse body;

    public static CreateAppModel build(java.util.Map<String, ?> map) throws Exception {
        CreateAppModel self = new CreateAppModel();
        return TeaModel.build(map, self);
    }

}
