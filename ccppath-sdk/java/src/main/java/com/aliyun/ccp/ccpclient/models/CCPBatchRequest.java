// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPBatchRequest extends TeaModel {
    @NameInMap("requests")
    @Validation(required = true)
    public BatchSubRequest[] requests;

    @NameInMap("resource")
    @Validation(required = true)
    public String resource;

    public static CCPBatchRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPBatchRequest self = new CCPBatchRequest();
        return TeaModel.build(map, self);
    }

}
