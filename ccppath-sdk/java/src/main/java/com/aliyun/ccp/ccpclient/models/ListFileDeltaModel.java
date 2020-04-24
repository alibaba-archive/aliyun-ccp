// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListFileDeltaModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListFileDeltaResponse body;

    public static ListFileDeltaModel build(java.util.Map<String, ?> map) throws Exception {
        ListFileDeltaModel self = new ListFileDeltaModel();
        return TeaModel.build(map, self);
    }

}
