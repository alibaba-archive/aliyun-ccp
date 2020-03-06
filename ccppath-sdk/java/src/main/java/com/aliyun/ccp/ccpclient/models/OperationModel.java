// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class OperationModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPBatchResponse body;

    public static OperationModel build(java.util.Map<String, ?> map) throws Exception {
        OperationModel self = new OperationModel();
        return TeaModel.build(map, self);
    }

}
