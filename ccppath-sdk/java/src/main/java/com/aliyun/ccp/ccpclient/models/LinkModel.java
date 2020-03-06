// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class LinkModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AccountAccessTokenResponse body;

    public static LinkModel build(java.util.Map<String, ?> map) throws Exception {
        LinkModel self = new LinkModel();
        return TeaModel.build(map, self);
    }

}
