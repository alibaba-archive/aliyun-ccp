// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CompleteFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPCompleteFileRequest body;

    public static CompleteFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CompleteFileRequestModel self = new CompleteFileRequestModel();
        return TeaModel.build(map, self);
    }

}
