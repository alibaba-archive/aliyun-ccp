// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListUsersRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListUserRequest body;

    public static ListUsersRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListUsersRequestModel self = new ListUsersRequestModel();
        return TeaModel.build(map, self);
    }

}
