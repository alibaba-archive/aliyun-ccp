// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetFileByPathModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetFileByPathResponse body;

    public static GetFileByPathModel build(java.util.Map<String, ?> map) throws Exception {
        GetFileByPathModel self = new GetFileByPathModel();
        return TeaModel.build(map, self);
    }

}
