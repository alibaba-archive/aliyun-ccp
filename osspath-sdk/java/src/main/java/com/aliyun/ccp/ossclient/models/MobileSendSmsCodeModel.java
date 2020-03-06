// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class MobileSendSmsCodeModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public MobileSendSmsCodeResponse body;

    public static MobileSendSmsCodeModel build(java.util.Map<String, ?> map) throws Exception {
        MobileSendSmsCodeModel self = new MobileSendSmsCodeModel();
        return TeaModel.build(map, self);
    }

}
