// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetLinkInfoByUserIdRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetLinkInfoByUserIDRequest body;

    public static GetLinkInfoByUserIdRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetLinkInfoByUserIdRequestModel self = new GetLinkInfoByUserIdRequestModel();
        return TeaModel.build(map, self);
    }

}
