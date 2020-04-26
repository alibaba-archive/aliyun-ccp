// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetPublicKeyModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAppPublicKeyResponse body;

    public static GetPublicKeyModel build(java.util.Map<String, ?> map) throws Exception {
        GetPublicKeyModel self = new GetPublicKeyModel();
        return TeaModel.build(map, self);
    }

}
