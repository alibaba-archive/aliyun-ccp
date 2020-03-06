// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class SearchFileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPSearchFileResponse body;

    public static SearchFileModel build(java.util.Map<String, ?> map) throws Exception {
        SearchFileModel self = new SearchFileModel();
        return TeaModel.build(map, self);
    }

}
