// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class CreateDomainRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateDomainRequest body;

    public static CreateDomainRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CreateDomainRequestModel self = new CreateDomainRequestModel();
        return TeaModel.build(map, self);
    }

}
