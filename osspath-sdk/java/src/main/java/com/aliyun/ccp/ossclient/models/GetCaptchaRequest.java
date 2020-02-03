// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetCaptchaRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    public static GetCaptchaRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCaptchaRequest self = new GetCaptchaRequest();
        return TeaModel.build(map, self);
    }

}
