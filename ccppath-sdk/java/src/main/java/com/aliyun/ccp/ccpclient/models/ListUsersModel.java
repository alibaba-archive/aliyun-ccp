// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListUsersModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListUserResponse body;

    public static ListUsersModel build(java.util.Map<String, ?> map) throws Exception {
        ListUsersModel self = new ListUsersModel();
        return TeaModel.build(map, self);
    }

}
