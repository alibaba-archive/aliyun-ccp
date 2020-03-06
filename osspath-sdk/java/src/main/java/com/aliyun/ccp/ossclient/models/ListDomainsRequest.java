// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * list domain request
 */
public class ListDomainsRequest extends TeaModel {
    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    public static ListDomainsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDomainsRequest self = new ListDomainsRequest();
        return TeaModel.build(map, self);
    }

}
