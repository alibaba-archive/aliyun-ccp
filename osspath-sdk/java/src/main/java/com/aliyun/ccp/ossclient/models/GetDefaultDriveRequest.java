// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetDefaultDriveRequest extends TeaModel {
    @NameInMap("header")
    public GetDefaultDriveRequestHeader header;

    @NameInMap("user_id")
    public String userId;

    public static GetDefaultDriveRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDefaultDriveRequest self = new GetDefaultDriveRequest();
        return TeaModel.build(map, self);
    }

    public static class GetDefaultDriveRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetDefaultDriveRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetDefaultDriveRequestHeader self = new GetDefaultDriveRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
