// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DeleteDriveRequest extends TeaModel {
    @NameInMap("header")
    public DeleteDriveRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true)
    public String driveId;

    public static DeleteDriveRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDriveRequest self = new DeleteDriveRequest();
        return TeaModel.build(map, self);
    }

    public static class DeleteDriveRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static DeleteDriveRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DeleteDriveRequestHeader self = new DeleteDriveRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
