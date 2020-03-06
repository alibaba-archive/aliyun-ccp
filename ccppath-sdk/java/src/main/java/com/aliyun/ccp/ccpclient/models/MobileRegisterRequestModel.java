// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class MobileRegisterRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public MobileRegisterRequest body;

    public static MobileRegisterRequestModel build(java.util.Map<String, ?> map) throws Exception {
        MobileRegisterRequestModel self = new MobileRegisterRequestModel();
        return TeaModel.build(map, self);
    }

}
