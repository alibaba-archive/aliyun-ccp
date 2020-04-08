// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class GetAppPublicKeyRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    public static GetAppPublicKeyRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAppPublicKeyRequest self = new GetAppPublicKeyRequest();
        return TeaModel.build(map, self);
    }

}
