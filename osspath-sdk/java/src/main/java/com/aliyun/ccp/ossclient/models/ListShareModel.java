// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListShareModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListShareResponse body;

    public static ListShareModel build(java.util.Map<String, ?> map) throws Exception {
        ListShareModel self = new ListShareModel();
        return TeaModel.build(map, self);
    }

}
