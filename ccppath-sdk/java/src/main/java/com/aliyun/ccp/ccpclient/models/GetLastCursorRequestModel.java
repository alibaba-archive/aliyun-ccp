// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetLastCursorRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetLastCursorRequest body;

    public static GetLastCursorRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetLastCursorRequestModel self = new GetLastCursorRequestModel();
        return TeaModel.build(map, self);
    }

}
