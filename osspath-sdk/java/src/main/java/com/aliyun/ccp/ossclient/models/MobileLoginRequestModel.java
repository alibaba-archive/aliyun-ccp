// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class MobileLoginRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public MobileLoginRequest body;

    public static MobileLoginRequestModel build(java.util.Map<String, ?> map) throws Exception {
        MobileLoginRequestModel self = new MobileLoginRequestModel();
        return TeaModel.build(map, self);
    }

}
