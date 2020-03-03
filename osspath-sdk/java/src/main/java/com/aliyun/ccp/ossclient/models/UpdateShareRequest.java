// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class UpdateShareRequest extends TeaModel {
    @NameInMap("header")
    public UpdateShareRequestHeader header;

    @NameInMap("description")
    public String description;

    @NameInMap("expiration")
    public String expiration;

    @NameInMap("permissions")
    public java.util.List<String> permissions;

    @NameInMap("share_id")
    @Validation(required = true)
    public String shareId;

    @NameInMap("share_name")
    public String shareName;

    @NameInMap("share_policy")
    public java.util.List<SharePermissionPolicy> sharePolicy;

    @NameInMap("status")
    public String status;

    public static UpdateShareRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateShareRequest self = new UpdateShareRequest();
        return TeaModel.build(map, self);
    }

    public static class UpdateShareRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static UpdateShareRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            UpdateShareRequestHeader self = new UpdateShareRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
