// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class AddStoreRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddStoreRequest body;

    public static AddStoreRequestModel build(java.util.Map<String, ?> map) throws Exception {
        AddStoreRequestModel self = new AddStoreRequestModel();
        return TeaModel.build(map, self);
    }

}
