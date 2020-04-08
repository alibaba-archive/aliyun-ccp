// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class UpdateDomainRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateDomainRequest body;

    public static UpdateDomainRequestModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateDomainRequestModel self = new UpdateDomainRequestModel();
        return TeaModel.build(map, self);
    }

}
