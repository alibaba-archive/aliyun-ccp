// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class LinkRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AccountLinkRequest body;

    public static LinkRequestModel build(java.util.Map<String, ?> map) throws Exception {
        LinkRequestModel self = new LinkRequestModel();
        return TeaModel.build(map, self);
    }

}
