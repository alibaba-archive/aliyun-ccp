// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListImageTagsRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListImageTagsRequest body;

    public static ListImageTagsRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListImageTagsRequestModel self = new ListImageTagsRequestModel();
        return TeaModel.build(map, self);
    }

}
