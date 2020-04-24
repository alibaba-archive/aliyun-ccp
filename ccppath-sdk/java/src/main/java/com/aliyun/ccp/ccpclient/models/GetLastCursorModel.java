// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetLastCursorModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetLastCursorResponse body;

    public static GetLastCursorModel build(java.util.Map<String, ?> map) throws Exception {
        GetLastCursorModel self = new GetLastCursorModel();
        return TeaModel.build(map, self);
    }

}
