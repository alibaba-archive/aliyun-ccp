// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetShareRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetShareRequest body;

    public static GetShareRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetShareRequestModel self = new GetShareRequestModel();
        return TeaModel.build(map, self);
    }

}
