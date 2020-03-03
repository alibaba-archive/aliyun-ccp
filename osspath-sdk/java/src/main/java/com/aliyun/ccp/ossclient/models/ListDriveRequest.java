// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListDriveRequest extends TeaModel {
    @NameInMap("header")
    public ListDriveRequestHeader header;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("owner")
    public String owner;

    public static ListDriveRequest build(java.util.Map<String, ?> map) throws Exception {
        ListDriveRequest self = new ListDriveRequest();
        return TeaModel.build(map, self);
    }

    public static class ListDriveRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static ListDriveRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            ListDriveRequestHeader self = new ListDriveRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
