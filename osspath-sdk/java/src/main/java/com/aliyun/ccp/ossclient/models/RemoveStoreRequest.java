// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class RemoveStoreRequest extends TeaModel {
    @NameInMap("header")
    public RemoveStoreRequestHeader header;

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

    public static class RemoveStoreRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static RemoveStoreRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            RemoveStoreRequestHeader self = new RemoveStoreRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
