// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * List storage
 */
public class ListStoreResponse extends TeaModel {
    @NameInMap("items")
    public java.util.List<StoreItemResponse> items;

    public static ListStoreResponse build(java.util.Map<String, ?> map) throws Exception {
        ListStoreResponse self = new ListStoreResponse();
        return TeaModel.build(map, self);
    }

}
