// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class AccountAccessTokenResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("access_token")
    @Validation(required = true)
    public String accessToken;

    @NameInMap("avatar")
    public String avatar;

    @NameInMap("default_drive_id")
    public String defaultDriveId;

    @NameInMap("exist_link")
    public LinkInfo[] existLink;

    @NameInMap("expire_time")
    public String expireTime;

    @NameInMap("expires_in")
    public Long expiresIn;

    @NameInMap("need_link")
    @Validation(required = true)
    public boolean needLink;

    @NameInMap("nick_name")
    public String nickName;

    @NameInMap("refresh_token")
    public String refreshToken;

    @NameInMap("role")
    public String role;

    @NameInMap("state")
    public String state;

    @NameInMap("token_type")
    public String tokenType;

    @NameInMap("user_id")
    public String userId;

    @NameInMap("user_name")
    public String userName;

}

