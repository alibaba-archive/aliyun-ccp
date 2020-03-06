// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSGetUploadUrlRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSGetUploadUrlRequest body;

    public static OSSGetUploadUrlRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSGetUploadUrlRequestModel self = new OSSGetUploadUrlRequestModel();
        return TeaModel.build(map, self);
    }

}
