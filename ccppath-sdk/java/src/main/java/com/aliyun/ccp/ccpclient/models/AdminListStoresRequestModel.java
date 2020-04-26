// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class AdminListStoresRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AdminListStoresRequest body;

    public static AdminListStoresRequestModel build(java.util.Map<String, ?> map) throws Exception {
        AdminListStoresRequestModel self = new AdminListStoresRequestModel();
        return TeaModel.build(map, self);
    }

}
