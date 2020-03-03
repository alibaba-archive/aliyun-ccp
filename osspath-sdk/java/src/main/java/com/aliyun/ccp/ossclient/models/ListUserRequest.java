// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListUserRequest extends TeaModel {
    @NameInMap("header")
    public ListUserRequestHeader header;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    public static ListUserRequest build(java.util.Map<String, ?> map) throws Exception {
        ListUserRequest self = new ListUserRequest();
        return TeaModel.build(map, self);
    }

    public static class ListUserRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static ListUserRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            ListUserRequestHeader self = new ListUserRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
