// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSCreateFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSCreateFileRequest body;

    public static OSSCreateFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSCreateFileRequestModel self = new OSSCreateFileRequestModel();
        return TeaModel.build(map, self);
    }

}
