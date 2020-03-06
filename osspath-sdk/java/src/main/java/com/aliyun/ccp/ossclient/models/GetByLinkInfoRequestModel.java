// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetByLinkInfoRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetByLinkInfoRequest body;

    public static GetByLinkInfoRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetByLinkInfoRequestModel self = new GetByLinkInfoRequestModel();
        return TeaModel.build(map, self);
    }

}
