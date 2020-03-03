// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListStoresResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("items")
    @Validation(required = true)
    public java.util.List<Store> items;

    public static ListStoresResponse build(java.util.Map<String, ?> map) throws Exception {
        ListStoresResponse self = new ListStoresResponse();
        return TeaModel.build(map, self);
    }

}
