// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class SearchUserRequest extends TeaModel {
    @NameInMap("header")
    public SearchUserRequestHeader header;

    @NameInMap("email")
    public String email;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("nick_name")
    public String nickName;

    @NameInMap("phone")
    public String phone;

    @NameInMap("role")
    public String role;

    @NameInMap("status")
    public String status;

    @NameInMap("user_name")
    public String userName;

    public static SearchUserRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchUserRequest self = new SearchUserRequest();
        return TeaModel.build(map, self);
    }

    public static class SearchUserRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static SearchUserRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            SearchUserRequestHeader self = new SearchUserRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
