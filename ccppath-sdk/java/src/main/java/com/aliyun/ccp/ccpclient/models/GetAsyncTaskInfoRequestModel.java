// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetAsyncTaskInfoRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetAsyncTaskRequest body;

    public static GetAsyncTaskInfoRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetAsyncTaskInfoRequestModel self = new GetAsyncTaskInfoRequestModel();
        return TeaModel.build(map, self);
    }

}
