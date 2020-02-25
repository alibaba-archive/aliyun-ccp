// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ConfirmLinkRequest extends TeaModel {
    @NameInMap("temporary_token")
    @Validation(required = true)
    public String temporaryToken;

    public static ConfirmLinkRequest build(java.util.Map<String, ?> map) throws Exception {
        ConfirmLinkRequest self = new ConfirmLinkRequest();
        return TeaModel.build(map, self);
    }

}
