// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class AuthConfig extends TeaModel {
    @NameInMap("app_id")
    public String appId;

    @NameInMap("app_secret")
    public String appSecret;

    @NameInMap("enable")
    public Boolean enable;

    @NameInMap("endpoint")
    public String endpoint;

    @NameInMap("enterprise_id")
    public String enterpriseId;

    public static AuthConfig build(java.util.Map<String, ?> map) throws Exception {
        AuthConfig self = new AuthConfig();
        return TeaModel.build(map, self);
    }

}
