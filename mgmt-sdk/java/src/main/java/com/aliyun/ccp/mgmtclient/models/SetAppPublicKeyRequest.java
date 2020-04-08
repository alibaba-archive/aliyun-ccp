// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class SetAppPublicKeyRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("public_key")
    @Validation(required = true)
    public String publicKey;

    public static SetAppPublicKeyRequest build(java.util.Map<String, ?> map) throws Exception {
        SetAppPublicKeyRequest self = new SetAppPublicKeyRequest();
        return TeaModel.build(map, self);
    }

}
