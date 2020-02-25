// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListStoreFileResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("items")
    public StoreFile[] items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static ListStoreFileResponse build(java.util.Map<String, ?> map) throws Exception {
        ListStoreFileResponse self = new ListStoreFileResponse();
        return TeaModel.build(map, self);
    }

}
