// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * batch operation response
 */
public class CCPBatchResponse extends TeaModel {
    @NameInMap("responses")
    public java.util.List<BatchSubResponse> responses;

    public static CCPBatchResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPBatchResponse self = new CCPBatchResponse();
        return TeaModel.build(map, self);
    }

}
