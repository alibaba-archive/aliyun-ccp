// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetCaptchaRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCaptchaRequest body;

    public static GetCaptchaRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetCaptchaRequestModel self = new GetCaptchaRequestModel();
        return TeaModel.build(map, self);
    }

}
