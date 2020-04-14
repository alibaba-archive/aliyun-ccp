// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class UpdateAppModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAppResponse body;

    public static UpdateAppModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateAppModel self = new UpdateAppModel();
        return TeaModel.build(map, self);
    }

}
