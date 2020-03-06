// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class BatchOperationModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPBatchResponse body;

    public static BatchOperationModel build(java.util.Map<String, ?> map) throws Exception {
        BatchOperationModel self = new BatchOperationModel();
        return TeaModel.build(map, self);
    }

}
