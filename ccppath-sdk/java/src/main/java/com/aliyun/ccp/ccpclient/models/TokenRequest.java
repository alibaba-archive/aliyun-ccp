// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class TokenRequest extends TeaModel {
    @NameInMap("header")
    public TokenRequestHeader header;

    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("grant_type")
    @Validation(required = true)
    public String grantType;

    @NameInMap("refresh_token")
    @Validation(required = true)
    public String refreshToken;

    public static TokenRequest build(java.util.Map<String, ?> map) throws Exception {
        TokenRequest self = new TokenRequest();
        return TeaModel.build(map, self);
    }

    public static class TokenRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static TokenRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            TokenRequestHeader self = new TokenRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
