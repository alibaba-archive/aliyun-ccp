// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetShareModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetShareResponse body;

    public static GetShareModel build(java.util.Map<String, ?> map) throws Exception {
        GetShareModel self = new GetShareModel();
        return TeaModel.build(map, self);
    }

}
