// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class GetPublicKeyRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAppPublicKeyRequest body;

    public static GetPublicKeyRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetPublicKeyRequestModel self = new GetPublicKeyRequestModel();
        return TeaModel.build(map, self);
    }

}
