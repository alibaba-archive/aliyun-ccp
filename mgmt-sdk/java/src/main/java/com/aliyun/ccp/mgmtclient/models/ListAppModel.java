// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class ListAppModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListAppsResponse body;

    public static ListAppModel build(java.util.Map<String, ?> map) throws Exception {
        ListAppModel self = new ListAppModel();
        return TeaModel.build(map, self);
    }

}
