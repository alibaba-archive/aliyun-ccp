// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPBatchResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("responses")
    public java.util.List<BatchSubResponse> responses;

    public static CCPBatchResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPBatchResponse self = new CCPBatchResponse();
        return TeaModel.build(map, self);
    }

}
