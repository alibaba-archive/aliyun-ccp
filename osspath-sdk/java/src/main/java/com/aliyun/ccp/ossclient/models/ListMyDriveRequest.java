// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListMyDriveRequest extends TeaModel {
    @NameInMap("header")
    public ListMyDriveRequestHeader header;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    public static ListMyDriveRequest build(java.util.Map<String, ?> map) throws Exception {
        ListMyDriveRequest self = new ListMyDriveRequest();
        return TeaModel.build(map, self);
    }

    public static class ListMyDriveRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static ListMyDriveRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            ListMyDriveRequestHeader self = new ListMyDriveRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
