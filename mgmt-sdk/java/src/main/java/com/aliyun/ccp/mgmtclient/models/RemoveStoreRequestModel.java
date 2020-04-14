// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class RemoveStoreRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RemoveStoreRequest body;

    public static RemoveStoreRequestModel build(java.util.Map<String, ?> map) throws Exception {
        RemoveStoreRequestModel self = new RemoveStoreRequestModel();
        return TeaModel.build(map, self);
    }

}
