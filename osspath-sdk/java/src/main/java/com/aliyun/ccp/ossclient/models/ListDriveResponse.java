// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * list drive response
 */
public class ListDriveResponse extends TeaModel {
    @NameInMap("items")
    public java.util.List<BaseDriveResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static ListDriveResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDriveResponse self = new ListDriveResponse();
        return TeaModel.build(map, self);
    }

}
