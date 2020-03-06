// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPCreateFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPCreateFileRequest body;

    public static CCPCreateFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPCreateFileRequestModel self = new CCPCreateFileRequestModel();
        return TeaModel.build(map, self);
    }

}
