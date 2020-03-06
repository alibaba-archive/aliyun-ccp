// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ConfirmLinkRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ConfirmLinkRequest body;

    public static ConfirmLinkRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ConfirmLinkRequestModel self = new ConfirmLinkRequestModel();
        return TeaModel.build(map, self);
    }

}
