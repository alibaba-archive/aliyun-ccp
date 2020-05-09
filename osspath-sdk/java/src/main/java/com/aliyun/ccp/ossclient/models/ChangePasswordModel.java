// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ChangePasswordModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AccountAccessTokenResponse body;

    public static ChangePasswordModel build(java.util.Map<String, ?> map) throws Exception {
        ChangePasswordModel self = new ChangePasswordModel();
        return TeaModel.build(map, self);
    }

}
