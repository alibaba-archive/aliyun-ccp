// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetDriveRequest extends TeaModel {
    @NameInMap("header")
    public GetDriveRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true)
    public String driveId;

    public static GetDriveRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDriveRequest self = new GetDriveRequest();
        return TeaModel.build(map, self);
    }

    public static class GetDriveRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static GetDriveRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            GetDriveRequestHeader self = new GetDriveRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
