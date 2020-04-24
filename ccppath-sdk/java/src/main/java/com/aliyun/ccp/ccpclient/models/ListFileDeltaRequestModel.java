// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListFileDeltaRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListFileDeltaRequest body;

    public static ListFileDeltaRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListFileDeltaRequestModel self = new ListFileDeltaRequestModel();
        return TeaModel.build(map, self);
    }

}
