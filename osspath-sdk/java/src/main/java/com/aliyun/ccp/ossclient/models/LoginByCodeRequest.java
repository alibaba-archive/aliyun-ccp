// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class LoginByCodeRequest extends TeaModel {
    @NameInMap("access_token")
    public String accessToken;

    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("auth_code")
    public String authCode;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    public static LoginByCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        LoginByCodeRequest self = new LoginByCodeRequest();
        return TeaModel.build(map, self);
    }

}
