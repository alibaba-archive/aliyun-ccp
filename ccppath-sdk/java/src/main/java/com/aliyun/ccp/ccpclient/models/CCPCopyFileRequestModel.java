// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPCopyFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPCopyFileRequest body;

    public static CCPCopyFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPCopyFileRequestModel self = new CCPCopyFileRequestModel();
        return TeaModel.build(map, self);
    }

}
