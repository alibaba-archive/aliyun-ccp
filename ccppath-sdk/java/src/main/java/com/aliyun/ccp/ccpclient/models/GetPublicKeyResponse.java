// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class GetPublicKeyResponse extends TeaModel {
    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("key_pair_id")
    public String keyPairId;

    @NameInMap("public_key")
    @Validation(required = true)
    public String publicKey;

    public static GetPublicKeyResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPublicKeyResponse self = new GetPublicKeyResponse();
        return TeaModel.build(map, self);
    }

}
