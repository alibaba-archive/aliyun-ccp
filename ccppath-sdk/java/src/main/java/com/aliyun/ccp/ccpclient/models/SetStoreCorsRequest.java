// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class SetStoreCorsRequest extends TeaModel {
    @NameInMap("header")
    public SetStoreCorsRequestHeader header;

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

    public static class SetStoreCorsRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static SetStoreCorsRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            SetStoreCorsRequestHeader self = new SetStoreCorsRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
