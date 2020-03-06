// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * Base user response
 */
public class BaseUserResponse extends TeaModel {
    @NameInMap("avatar")
    public String avatar;

    @NameInMap("created_at")
    public Long createdAt;

    @NameInMap("default_drive_id")
    public String defaultDriveId;

    @NameInMap("description")
    public String description;

    @NameInMap("domain_id")
    public String domainId;

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

    @NameInMap("updated_at")
    public Long updatedAt;

    @NameInMap("user_id")
    public String userId;

    @NameInMap("user_name")
    public String userName;

    public static BaseUserResponse build(java.util.Map<String, ?> map) throws Exception {
        BaseUserResponse self = new BaseUserResponse();
        return TeaModel.build(map, self);
    }

}
