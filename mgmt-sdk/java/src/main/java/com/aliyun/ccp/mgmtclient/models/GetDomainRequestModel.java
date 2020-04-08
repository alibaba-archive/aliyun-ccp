// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class GetDomainRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDomainRequest body;

    public static GetDomainRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetDomainRequestModel self = new GetDomainRequestModel();
        return TeaModel.build(map, self);
    }

}
