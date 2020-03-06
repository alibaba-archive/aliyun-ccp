// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListStoreFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListStoreFileRequest body;

    public static ListStoreFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListStoreFileRequestModel self = new ListStoreFileRequestModel();
        return TeaModel.build(map, self);
    }

}
