// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPGetFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetFileRequest body;

    public static CCPGetFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPGetFileRequestModel self = new CCPGetFileRequestModel();
        return TeaModel.build(map, self);
    }

}
