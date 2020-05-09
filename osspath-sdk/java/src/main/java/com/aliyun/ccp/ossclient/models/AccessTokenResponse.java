// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class AccessTokenResponse extends TeaModel {
    @NameInMap("access_token")
    @Validation(required = true)
    public String accessToken;

    @NameInMap("default_drive_id")
    @Validation(required = true)
    public String defaultDriveId;

    @NameInMap("expire_time")
    @Validation(required = true)
    public String expireTime;

    @NameInMap("expires_in")
    @Validation(required = true)
    public Long expiresIn;

    @NameInMap("refresh_token")
    @Validation(required = true)
    public String refreshToken;

    @NameInMap("role")
    @Validation(required = true)
    public String role;

    @NameInMap("token_type")
    @Validation(required = true)
    public String tokenType;

    @NameInMap("user_id")
    @Validation(required = true)
    public String userId;

    public static AccessTokenResponse build(java.util.Map<String, ?> map) throws Exception {
        AccessTokenResponse self = new AccessTokenResponse();
        return TeaModel.build(map, self);
    }

}
