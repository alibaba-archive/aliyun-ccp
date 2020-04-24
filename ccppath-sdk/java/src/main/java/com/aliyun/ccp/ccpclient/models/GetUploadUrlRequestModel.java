// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetUploadUrlRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetUploadUrlRequest body;

    public static GetUploadUrlRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetUploadUrlRequestModel self = new GetUploadUrlRequestModel();
        return TeaModel.build(map, self);
    }

}
