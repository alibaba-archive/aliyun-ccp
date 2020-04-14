// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class AddStoreModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddStoreResponse body;

    public static AddStoreModel build(java.util.Map<String, ?> map) throws Exception {
        AddStoreModel self = new AddStoreModel();
        return TeaModel.build(map, self);
    }

}
