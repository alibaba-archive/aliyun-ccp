// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class AccountAccessTokenResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("access_token")
    @Validation(pattern = "", maxLength = 0)
    public String accessToken;

    @NameInMap("avatar")
    @Validation(pattern = "", maxLength = 0)
    public String avatar;

    @NameInMap("default_drive_id")
    @Validation(pattern = "", maxLength = 0)
    public String defaultDriveId;

    @NameInMap("exist_link")
    @Validation(pattern = "", maxLength = 0)
    public LinkInfo[] existLink;

    @NameInMap("expire_time")
    @Validation(pattern = "", maxLength = 0)
    public String expireTime;

    @NameInMap("expires_in")
    @Validation(pattern = "", maxLength = 0)
    public Long expiresIn;

    @NameInMap("need_link")
    @Validation(pattern = "", maxLength = 0)
    public boolean needLink;

    @NameInMap("nick_name")
    @Validation(pattern = "", maxLength = 0)
    public String nickName;

    @NameInMap("refresh_token")
    @Validation(pattern = "", maxLength = 0)
    public String refreshToken;

    @NameInMap("role")
    @Validation(pattern = "", maxLength = 0)
    public String role;

    @NameInMap("state")
    @Validation(pattern = "", maxLength = 0)
    public String state;

    @NameInMap("token_type")
    @Validation(pattern = "", maxLength = 0)
    public String tokenType;

    @NameInMap("user_id")
    @Validation(pattern = "", maxLength = 0)
    public String userId;

    @NameInMap("user_name")
    @Validation(pattern = "", maxLength = 0)
    public String userName;

}

