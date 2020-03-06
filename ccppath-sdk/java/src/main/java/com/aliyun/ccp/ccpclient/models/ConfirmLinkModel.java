// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ConfirmLinkModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AccountAccessTokenResponse body;

    public static ConfirmLinkModel build(java.util.Map<String, ?> map) throws Exception {
        ConfirmLinkModel self = new ConfirmLinkModel();
        return TeaModel.build(map, self);
    }

}
