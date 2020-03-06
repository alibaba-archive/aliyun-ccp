// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class SearchUserModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListUserResponse body;

    public static SearchUserModel build(java.util.Map<String, ?> map) throws Exception {
        SearchUserModel self = new SearchUserModel();
        return TeaModel.build(map, self);
    }

}
