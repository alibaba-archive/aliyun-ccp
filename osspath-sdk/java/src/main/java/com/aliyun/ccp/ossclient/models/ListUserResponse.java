// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListUserResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("items")
    public java.util.List<BaseUserResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static ListUserResponse build(java.util.Map<String, ?> map) throws Exception {
        ListUserResponse self = new ListUserResponse();
        return TeaModel.build(map, self);
    }

}
