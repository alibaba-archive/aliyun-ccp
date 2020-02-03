// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListStoresRequest extends TeaModel {
    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    public static ListStoresRequest build(java.util.Map<String, ?> map) throws Exception {
        ListStoresRequest self = new ListStoresRequest();
        return TeaModel.build(map, self);
    }

}
