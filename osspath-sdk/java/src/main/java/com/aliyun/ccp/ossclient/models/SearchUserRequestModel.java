// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class SearchUserRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchUserRequest body;

    public static SearchUserRequestModel build(java.util.Map<String, ?> map) throws Exception {
        SearchUserRequestModel self = new SearchUserRequestModel();
        return TeaModel.build(map, self);
    }

}
