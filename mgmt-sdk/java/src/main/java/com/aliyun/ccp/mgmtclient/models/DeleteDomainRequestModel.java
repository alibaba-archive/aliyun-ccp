// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class DeleteDomainRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteDomainRequest body;

    public static DeleteDomainRequestModel build(java.util.Map<String, ?> map) throws Exception {
        DeleteDomainRequestModel self = new DeleteDomainRequestModel();
        return TeaModel.build(map, self);
    }

}
