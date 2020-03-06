// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetAsyncTaskInfoModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetAsyncTaskResponse body;

    public static GetAsyncTaskInfoModel build(java.util.Map<String, ?> map) throws Exception {
        GetAsyncTaskInfoModel self = new GetAsyncTaskInfoModel();
        return TeaModel.build(map, self);
    }

}
