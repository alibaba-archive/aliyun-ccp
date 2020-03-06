// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListStorefileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListStoreFileResponse body;

    public static ListStorefileModel build(java.util.Map<String, ?> map) throws Exception {
        ListStorefileModel self = new ListStorefileModel();
        return TeaModel.build(map, self);
    }

}
