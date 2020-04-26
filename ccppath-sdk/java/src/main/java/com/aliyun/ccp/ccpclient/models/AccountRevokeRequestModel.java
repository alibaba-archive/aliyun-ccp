// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class AccountRevokeRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RevokeRequest body;

    public static AccountRevokeRequestModel build(java.util.Map<String, ?> map) throws Exception {
        AccountRevokeRequestModel self = new AccountRevokeRequestModel();
        return TeaModel.build(map, self);
    }

}
