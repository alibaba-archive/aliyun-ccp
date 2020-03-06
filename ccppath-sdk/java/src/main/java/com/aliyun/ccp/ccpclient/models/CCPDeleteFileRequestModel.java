// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPDeleteFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPDeleteFileRequest body;

    public static CCPDeleteFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPDeleteFileRequestModel self = new CCPDeleteFileRequestModel();
        return TeaModel.build(map, self);
    }

}
