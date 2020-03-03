// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateUserRequest extends TeaModel {
    @NameInMap("header")
    public UpdateUserRequestHeader header;

    @NameInMap("avatar")
    public String avatar;

    @NameInMap("description")
    public String description;

    @NameInMap("email")
    public String email;

    @NameInMap("nick_name")
    public String nickName;

    @NameInMap("phone")
    public String phone;

    @NameInMap("role")
    public String role;

    @NameInMap("status")
    public String status;

    @NameInMap("user_id")
    @Validation(required = true)
    public String userId;

    public static UpdateUserRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserRequest self = new UpdateUserRequest();
        return TeaModel.build(map, self);
    }

    public static class UpdateUserRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static UpdateUserRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            UpdateUserRequestHeader self = new UpdateUserRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
