// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class LoginByCodeRequest extends TeaModel {
    @NameInMap("access_token")
    @Validation(pattern = "", maxLength = 0)
    public String accessToken;

    @NameInMap("app_id")
    @Validation(pattern = "", maxLength = 0)
    public String appId;

    @NameInMap("auth_code")
    @Validation(pattern = "", maxLength = 0)
    public String authCode;

    @NameInMap("type")
    @Validation(pattern = "", maxLength = 0)
    public String type;

}

