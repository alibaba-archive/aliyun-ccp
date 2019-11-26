// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class TokenRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("grant_type")
    @Validation(required = true)
    public String grantType;

    @NameInMap("refresh_token")
    @Validation(required = true)
    public String refreshToken;

}
