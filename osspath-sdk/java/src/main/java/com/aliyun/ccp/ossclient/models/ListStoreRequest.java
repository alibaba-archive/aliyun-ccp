// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * list storage file
 */
public class ListStoreRequest extends TeaModel {
    @NameInMap("domain_id")
    public String domainId;

    public static ListStoreRequest build(java.util.Map<String, ?> map) throws Exception {
        ListStoreRequest self = new ListStoreRequest();
        return TeaModel.build(map, self);
    }

}
