// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListTagsRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListImageTagsRequest body;

    public static ListTagsRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListTagsRequestModel self = new ListTagsRequestModel();
        return TeaModel.build(map, self);
    }

}
