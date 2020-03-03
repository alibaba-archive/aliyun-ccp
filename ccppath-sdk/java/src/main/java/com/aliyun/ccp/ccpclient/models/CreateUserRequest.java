// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CreateUserRequest extends TeaModel {
    @NameInMap("header")
    public CreateUserRequestHeader header;

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

    @NameInMap("user_name")
    public String userName;

    public static CreateUserRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateUserRequest self = new CreateUserRequest();
        return TeaModel.build(map, self);
    }

    public static class CreateUserRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CreateUserRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CreateUserRequestHeader self = new CreateUserRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
