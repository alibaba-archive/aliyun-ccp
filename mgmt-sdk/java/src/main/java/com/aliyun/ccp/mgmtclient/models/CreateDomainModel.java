// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class CreateDomainModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateDomainResponse body;

    public static CreateDomainModel build(java.util.Map<String, ?> map) throws Exception {
        CreateDomainModel self = new CreateDomainModel();
        return TeaModel.build(map, self);
    }

}
