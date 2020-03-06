// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetSecureUrlModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSGetSecureUrlResponse body;

    public static GetSecureUrlModel build(java.util.Map<String, ?> map) throws Exception {
        GetSecureUrlModel self = new GetSecureUrlModel();
        return TeaModel.build(map, self);
    }

}
