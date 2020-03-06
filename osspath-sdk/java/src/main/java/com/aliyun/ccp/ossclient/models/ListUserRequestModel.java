// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListUserRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListUserRequest body;

    public static ListUserRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListUserRequestModel self = new ListUserRequestModel();
        return TeaModel.build(map, self);
    }

}
