// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class LoginByCodeRequest extends TeaModel {
    @NameInMap("header")
    public LoginByCodeRequestHeader header;

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

    public static class LoginByCodeRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static LoginByCodeRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            LoginByCodeRequestHeader self = new LoginByCodeRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
