// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetImageCountRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetImageCountRequest body;

    public static GetImageCountRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetImageCountRequestModel self = new GetImageCountRequestModel();
        return TeaModel.build(map, self);
    }

}
