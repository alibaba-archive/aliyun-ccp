// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class GetAppRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAppRequest body;

    public static GetAppRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetAppRequestModel self = new GetAppRequestModel();
        return TeaModel.build(map, self);
    }

}
