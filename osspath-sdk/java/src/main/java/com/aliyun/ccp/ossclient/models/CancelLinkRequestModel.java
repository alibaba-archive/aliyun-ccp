// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CancelLinkRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CancelLinkRequest body;

    public static CancelLinkRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CancelLinkRequestModel self = new CancelLinkRequestModel();
        return TeaModel.build(map, self);
    }

}
