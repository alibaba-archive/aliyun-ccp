// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class AdminListStoresRequest extends TeaModel {
    @NameInMap("header")
    public AdminListStoresRequestHeader header;

    public static AdminListStoresRequest build(java.util.Map<String, ?> map) throws Exception {
        AdminListStoresRequest self = new AdminListStoresRequest();
        return TeaModel.build(map, self);
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
