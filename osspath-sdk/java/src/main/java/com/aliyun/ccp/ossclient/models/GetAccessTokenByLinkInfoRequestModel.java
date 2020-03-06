// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetAccessTokenByLinkInfoRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAccessTokenByLinkInfoRequest body;

    public static GetAccessTokenByLinkInfoRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetAccessTokenByLinkInfoRequestModel self = new GetAccessTokenByLinkInfoRequestModel();
        return TeaModel.build(map, self);
    }

}
