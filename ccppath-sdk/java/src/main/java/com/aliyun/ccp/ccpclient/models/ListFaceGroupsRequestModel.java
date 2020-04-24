// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListFaceGroupsRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListImageFaceGroupsRequest body;

    public static ListFaceGroupsRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListFaceGroupsRequestModel self = new ListFaceGroupsRequestModel();
        return TeaModel.build(map, self);
    }

}
