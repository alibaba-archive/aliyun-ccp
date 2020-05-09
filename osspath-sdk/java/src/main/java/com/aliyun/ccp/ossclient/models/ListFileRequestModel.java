// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSListFileRequest body;

    public static ListFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListFileRequestModel self = new ListFileRequestModel();
        return TeaModel.build(map, self);
    }

}
