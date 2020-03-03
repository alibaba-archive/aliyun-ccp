// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListStoresRequest extends TeaModel {
    @NameInMap("header")
    public ListStoresRequestHeader header;

    @NameInMap("domain_id")
    @Validation(required = true)
    public String domainId;

    public static ListStoresRequest build(java.util.Map<String, ?> map) throws Exception {
        ListStoresRequest self = new ListStoresRequest();
        return TeaModel.build(map, self);
    }

    public static class ListStoresRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static ListStoresRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            ListStoresRequestHeader self = new ListStoresRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class AdminListStoresRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static AdminListStoresRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            AdminListStoresRequestHeader self = new AdminListStoresRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
