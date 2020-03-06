// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPCompleteFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPCompleteFileRequest body;

    public static CCPCompleteFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPCompleteFileRequestModel self = new CCPCompleteFileRequestModel();
        return TeaModel.build(map, self);
    }

}
