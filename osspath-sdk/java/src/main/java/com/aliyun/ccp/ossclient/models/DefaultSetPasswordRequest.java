// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DefaultSetPasswordRequest extends TeaModel {
    @NameInMap("header")
    public DefaultSetPasswordRequestHeader header;

    @NameInMap("app_id")
    @Validation(required = true)
    public String appId;

    @NameInMap("new_password")
    @Validation(required = true)
    public String newPassword;

    @NameInMap("state")
    @Validation(required = true)
    public String state;

    public static DefaultSetPasswordRequest build(java.util.Map<String, ?> map) throws Exception {
        DefaultSetPasswordRequest self = new DefaultSetPasswordRequest();
        return TeaModel.build(map, self);
    }

    public static class DefaultSetPasswordRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static DefaultSetPasswordRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DefaultSetPasswordRequestHeader self = new DefaultSetPasswordRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
