// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSGetFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSGetFileRequest body;

    public static OSSGetFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSGetFileRequestModel self = new OSSGetFileRequestModel();
        return TeaModel.build(map, self);
    }

}
