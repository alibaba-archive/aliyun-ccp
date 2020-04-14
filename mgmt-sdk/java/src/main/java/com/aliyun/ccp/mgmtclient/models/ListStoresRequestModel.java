// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class ListStoresRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListStoresRequest body;

    public static ListStoresRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListStoresRequestModel self = new ListStoresRequestModel();
        return TeaModel.build(map, self);
    }

}
