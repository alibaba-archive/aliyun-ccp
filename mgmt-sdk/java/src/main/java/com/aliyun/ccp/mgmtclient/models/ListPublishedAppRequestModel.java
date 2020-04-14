// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class ListPublishedAppRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListAppsRequest body;

    public static ListPublishedAppRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListPublishedAppRequestModel self = new ListPublishedAppRequestModel();
        return TeaModel.build(map, self);
    }

}
