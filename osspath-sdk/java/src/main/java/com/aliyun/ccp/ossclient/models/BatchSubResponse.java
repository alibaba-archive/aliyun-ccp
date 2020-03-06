// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class BatchSubResponse extends TeaModel {
    @NameInMap("body")
    public java.util.Map<String, Object> body;

    @NameInMap("id")
    public String id;

    @NameInMap("status")
    public Long status;

    public static BatchSubResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchSubResponse self = new BatchSubResponse();
        return TeaModel.build(map, self);
    }

}
