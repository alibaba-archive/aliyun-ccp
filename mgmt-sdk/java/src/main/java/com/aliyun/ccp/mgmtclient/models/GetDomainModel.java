// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class GetDomainModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDomainResponse body;

    public static GetDomainModel build(java.util.Map<String, ?> map) throws Exception {
        GetDomainModel self = new GetDomainModel();
        return TeaModel.build(map, self);
    }

}
