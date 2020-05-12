// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListStorefileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListStoreFileRequest body;

    public static ListStorefileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListStorefileRequestModel self = new ListStorefileRequestModel();
        return TeaModel.build(map, self);
    }

}
