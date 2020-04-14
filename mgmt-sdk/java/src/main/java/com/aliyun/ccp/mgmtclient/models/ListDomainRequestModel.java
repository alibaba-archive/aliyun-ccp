// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class ListDomainRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListDomainsRequest body;

    public static ListDomainRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListDomainRequestModel self = new ListDomainRequestModel();
        return TeaModel.build(map, self);
    }

}
