// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class UpdateDomainModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateDomainResponse body;

    public static UpdateDomainModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateDomainModel self = new UpdateDomainModel();
        return TeaModel.build(map, self);
    }

}
