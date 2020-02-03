// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class AccessTokenResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("access_token")
    @Validation(required = true)
    public String accessToken;

    @NameInMap("expire_time")
    public String expireTime;

    @NameInMap("refresh_token")
    public String refreshToken;

    @NameInMap("role")
    public String role;

    @NameInMap("token_type")
    public String tokenType;

    @NameInMap("user_id")
    public String userId;

    public static AccessTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        AccessTokenResponse self = new AccessTokenResponse();
        return TeaModel.build(map, self);
    }

}
