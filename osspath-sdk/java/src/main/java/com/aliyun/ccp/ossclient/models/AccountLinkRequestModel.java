// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class AccountLinkRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AccountLinkRequest body;

    public static AccountLinkRequestModel build(java.util.Map<String, ?> map) throws Exception {
        AccountLinkRequestModel self = new AccountLinkRequestModel();
        return TeaModel.build(map, self);
    }

}
