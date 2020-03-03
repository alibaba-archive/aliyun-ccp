// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DeleteUserRequest extends TeaModel {
    @NameInMap("header")
    public DeleteUserRequestHeader header;

    @NameInMap("user_id")
    @Validation(required = true)
    public String userId;

    public static DeleteUserRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteUserRequest self = new DeleteUserRequest();
        return TeaModel.build(map, self);
    }

    public static class DeleteUserRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static DeleteUserRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            DeleteUserRequestHeader self = new DeleteUserRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
