// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSGetFileRequest body;

    public static GetFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetFileRequestModel self = new GetFileRequestModel();
        return TeaModel.build(map, self);
    }

}
