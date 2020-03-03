// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListStoreRequest extends TeaModel {
    @NameInMap("header")
    public ListStoreRequestHeader header;

    @NameInMap("domain_id")
    public String domainId;

    public static ListStoreRequest build(java.util.Map<String, ?> map) throws Exception {
        ListStoreRequest self = new ListStoreRequest();
        return TeaModel.build(map, self);
    }

    public static class ListStoreRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static ListStoreRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            ListStoreRequestHeader self = new ListStoreRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
