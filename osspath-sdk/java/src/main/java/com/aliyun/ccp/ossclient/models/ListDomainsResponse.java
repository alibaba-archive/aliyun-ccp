// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListDomainsResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("items")
    public java.util.List<BaseDomainResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static ListDomainsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDomainsResponse self = new ListDomainsResponse();
        return TeaModel.build(map, self);
    }

}
