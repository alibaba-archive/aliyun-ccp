// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListTagsModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListImageTagsResponse body;

    public static ListTagsModel build(java.util.Map<String, ?> map) throws Exception {
        ListTagsModel self = new ListTagsModel();
        return TeaModel.build(map, self);
    }

}
