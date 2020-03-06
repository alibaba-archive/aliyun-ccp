// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class RemoveStoreRequest extends TeaModel {
    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    @NameInMap("store_id")
    @Validation(required = true)
    public String storeId;

    public static RemoveStoreRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveStoreRequest self = new RemoveStoreRequest();
        return TeaModel.build(map, self);
    }

}
