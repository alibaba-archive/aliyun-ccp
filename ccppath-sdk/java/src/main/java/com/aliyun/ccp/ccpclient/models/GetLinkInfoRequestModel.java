// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetLinkInfoRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetByLinkInfoRequest body;

    public static GetLinkInfoRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetLinkInfoRequestModel self = new GetLinkInfoRequestModel();
        return TeaModel.build(map, self);
    }

}
