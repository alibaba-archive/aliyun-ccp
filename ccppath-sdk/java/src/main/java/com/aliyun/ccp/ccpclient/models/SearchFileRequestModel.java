// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class SearchFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPSearchFileRequest body;

    public static SearchFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        SearchFileRequestModel self = new SearchFileRequestModel();
        return TeaModel.build(map, self);
    }

}
