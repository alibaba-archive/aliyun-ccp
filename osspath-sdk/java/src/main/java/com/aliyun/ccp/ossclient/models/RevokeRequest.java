// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class RevokeRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("refresh_token")
    @Validation(required = true)
    public String refreshToken;

    public static RevokeRequest build(java.util.Map<String, ?> map) throws Exception {
        RevokeRequest self = new RevokeRequest();
        return TeaModel.build(map, self);
    }

}
