// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * List storage file
 */
public class ListStoreFileResponse extends TeaModel {
    @NameInMap("items")
    public java.util.List<StoreFile> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static ListStoreFileResponse build(java.util.Map<String, ?> map) throws Exception {
        ListStoreFileResponse self = new ListStoreFileResponse();
        return TeaModel.build(map, self);
    }

}
