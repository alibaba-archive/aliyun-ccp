// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetCaptchaModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public Captcha body;

    public static GetCaptchaModel build(java.util.Map<String, ?> map) throws Exception {
        GetCaptchaModel self = new GetCaptchaModel();
        return TeaModel.build(map, self);
    }

}
