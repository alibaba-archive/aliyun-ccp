// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPBatchRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPBatchRequest body;

    public static CCPBatchRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPBatchRequestModel self = new CCPBatchRequestModel();
        return TeaModel.build(map, self);
    }

}
