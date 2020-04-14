// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class SetPublicKeyModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAppPublicKeyResponse body;

    public static SetPublicKeyModel build(java.util.Map<String, ?> map) throws Exception {
        SetPublicKeyModel self = new SetPublicKeyModel();
        return TeaModel.build(map, self);
    }

}
