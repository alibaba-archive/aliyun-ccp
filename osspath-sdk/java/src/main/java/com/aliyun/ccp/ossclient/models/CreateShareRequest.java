// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateShareRequest extends TeaModel {
    @NameInMap("header")
    public CreateShareRequestHeader header;

    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("expiration")
    public String expiration;

    @NameInMap("owner")
    @Validation(required = true)
    public String owner;

    @NameInMap("permissions")
    public java.util.List<String> permissions;

    @NameInMap("share_file_path")
    @Validation(required = true)
    public String shareFilePath;

    @NameInMap("share_name")
    public String shareName;

    @NameInMap("share_policy")
    public java.util.List<SharePermissionPolicy> sharePolicy;

    @NameInMap("status")
    public String status;

    public static CreateShareRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateShareRequest self = new CreateShareRequest();
        return TeaModel.build(map, self);
    }

    public static class CreateShareRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CreateShareRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CreateShareRequestHeader self = new CreateShareRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
