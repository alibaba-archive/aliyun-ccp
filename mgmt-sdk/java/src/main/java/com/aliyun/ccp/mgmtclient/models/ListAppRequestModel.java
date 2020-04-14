// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class ListAppRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListAppsRequest body;

    public static ListAppRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListAppRequestModel self = new ListAppRequestModel();
        return TeaModel.build(map, self);
    }

}
