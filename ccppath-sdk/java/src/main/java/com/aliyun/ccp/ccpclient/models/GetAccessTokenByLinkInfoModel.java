// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetAccessTokenByLinkInfoModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AccountAccessTokenResponse body;

    public static GetAccessTokenByLinkInfoModel build(java.util.Map<String, ?> map) throws Exception {
        GetAccessTokenByLinkInfoModel self = new GetAccessTokenByLinkInfoModel();
        return TeaModel.build(map, self);
    }

}
