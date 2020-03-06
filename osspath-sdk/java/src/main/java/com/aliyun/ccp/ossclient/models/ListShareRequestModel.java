// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListShareRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListShareRequest body;

    public static ListShareRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListShareRequestModel self = new ListShareRequestModel();
        return TeaModel.build(map, self);
    }

}
