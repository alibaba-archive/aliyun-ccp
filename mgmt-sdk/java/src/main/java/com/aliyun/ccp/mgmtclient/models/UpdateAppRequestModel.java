// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class UpdateAppRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateAppRequest body;

    public static UpdateAppRequestModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateAppRequestModel self = new UpdateAppRequestModel();
        return TeaModel.build(map, self);
    }

}
