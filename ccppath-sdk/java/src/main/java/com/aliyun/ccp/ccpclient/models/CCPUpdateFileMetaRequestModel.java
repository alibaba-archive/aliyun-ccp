// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPUpdateFileMetaRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPUpdateFileMetaRequest body;

    public static CCPUpdateFileMetaRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPUpdateFileMetaRequestModel self = new CCPUpdateFileMetaRequestModel();
        return TeaModel.build(map, self);
    }

}
