// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class CancelLinkRequest extends TeaModel {
    @NameInMap("temporary_token")
    @Validation(required = true)
    public String temporaryToken;

    public static CancelLinkRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelLinkRequest self = new CancelLinkRequest();
        return TeaModel.build(map, self);
    }

}
