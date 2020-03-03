// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListShareResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("items")
    public java.util.List<BaseShareResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static ListShareResponse build(java.util.Map<String, ?> map) throws Exception {
        ListShareResponse self = new ListShareResponse();
        return TeaModel.build(map, self);
    }

}
