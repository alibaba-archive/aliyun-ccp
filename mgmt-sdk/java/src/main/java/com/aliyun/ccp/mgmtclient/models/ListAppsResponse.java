// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class ListAppsResponse extends TeaModel {
    @NameInMap("items")
    @Validation(required = true)
    public java.util.List<GetAppResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static ListAppsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAppsResponse self = new ListAppsResponse();
        return TeaModel.build(map, self);
    }

}
