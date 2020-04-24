// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class BatchOperationRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPBatchRequest body;

    public static BatchOperationRequestModel build(java.util.Map<String, ?> map) throws Exception {
        BatchOperationRequestModel self = new BatchOperationRequestModel();
        return TeaModel.build(map, self);
    }

}
