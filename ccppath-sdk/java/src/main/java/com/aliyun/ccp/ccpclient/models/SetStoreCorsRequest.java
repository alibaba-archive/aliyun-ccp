// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class SetStoreCorsRequest extends TeaModel {
    @NameInMap("cors_rule")
    @Validation(required = true)
    public CorsRule corsRule;

    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    @NameInMap("store_id")
    @Validation(required = true)
    public String storeId;

    public static SetStoreCorsRequest build(java.util.Map<String, ?> map) throws Exception {
        SetStoreCorsRequest self = new SetStoreCorsRequest();
        return TeaModel.build(map, self);
    }

}
