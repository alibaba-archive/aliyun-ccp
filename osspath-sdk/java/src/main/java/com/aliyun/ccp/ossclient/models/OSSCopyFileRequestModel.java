// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSCopyFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSCopyFileRequest body;

    public static OSSCopyFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSCopyFileRequestModel self = new OSSCopyFileRequestModel();
        return TeaModel.build(map, self);
    }

}
