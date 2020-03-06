// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetUploadUrlModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSGetUploadUrlResponse body;

    public static GetUploadUrlModel build(java.util.Map<String, ?> map) throws Exception {
        GetUploadUrlModel self = new GetUploadUrlModel();
        return TeaModel.build(map, self);
    }

}
