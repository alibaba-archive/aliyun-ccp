// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPGetUploadUrlRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetUploadUrlRequest body;

    public static CCPGetUploadUrlRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPGetUploadUrlRequestModel self = new CCPGetUploadUrlRequestModel();
        return TeaModel.build(map, self);
    }

}
