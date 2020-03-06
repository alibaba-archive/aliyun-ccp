// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class MobileSendSmsCodeRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public MobileSendSmsCodeRequest body;

    public static MobileSendSmsCodeRequestModel build(java.util.Map<String, ?> map) throws Exception {
        MobileSendSmsCodeRequestModel self = new MobileSendSmsCodeRequestModel();
        return TeaModel.build(map, self);
    }

}
