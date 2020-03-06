// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListImageFaceGroupsRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListImageFaceGroupsRequest body;

    public static ListImageFaceGroupsRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListImageFaceGroupsRequestModel self = new ListImageFaceGroupsRequestModel();
        return TeaModel.build(map, self);
    }

}
