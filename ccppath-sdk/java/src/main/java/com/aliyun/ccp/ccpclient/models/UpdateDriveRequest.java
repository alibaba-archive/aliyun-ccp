// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateDriveRequest extends TeaModel {
    @NameInMap("header")
    public UpdateDriveRequestHeader header;

    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    @Validation(required = true)
    public String driveId;

    @NameInMap("drive_name")
    public String driveName;

    @NameInMap("status")
    public String status;

    @NameInMap("total_size")
    public Long totalSize;

    public static UpdateDriveRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateDriveRequest self = new UpdateDriveRequest();
        return TeaModel.build(map, self);
    }

    public static class UpdateDriveRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static UpdateDriveRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            UpdateDriveRequestHeader self = new UpdateDriveRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
