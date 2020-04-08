// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class ListStoresResponse extends TeaModel {
    @NameInMap("items")
    @Validation(required = true)
    public java.util.List<Store> items;

    public static ListStoresResponse build(java.util.Map<String, ?> map) throws Exception {
        ListStoresResponse self = new ListStoresResponse();
        return TeaModel.build(map, self);
    }

}
