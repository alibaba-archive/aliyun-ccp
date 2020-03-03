// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetUserAccessTokenRequest extends TeaModel {
    @NameInMap("header")
    public GetUserAccessTokenRequestHeader header;

    @NameInMap("role")
    public String role;

    @NameInMap("user_id")
    @Validation(required = true)
    public String userId;

    public static GetUserAccessTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserAccessTokenRequest self = new GetUserAccessTokenRequest();
        return TeaModel.build(map, self);
    }

    public static class GetUserAccessTokenRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetUserAccessTokenRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetUserAccessTokenRequestHeader self = new GetUserAccessTokenRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
