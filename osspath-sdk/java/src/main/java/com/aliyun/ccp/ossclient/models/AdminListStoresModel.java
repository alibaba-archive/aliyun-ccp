// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class AdminListStoresModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListStoresResponse body;

    public static AdminListStoresModel build(java.util.Map<String, ?> map) throws Exception {
        AdminListStoresModel self = new AdminListStoresModel();
        return TeaModel.build(map, self);
    }

}
