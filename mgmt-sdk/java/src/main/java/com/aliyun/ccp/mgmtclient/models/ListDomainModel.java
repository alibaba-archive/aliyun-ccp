// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class ListDomainModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListDomainsResponse body;

    public static ListDomainModel build(java.util.Map<String, ?> map) throws Exception {
        ListDomainModel self = new ListDomainModel();
        return TeaModel.build(map, self);
    }

}
