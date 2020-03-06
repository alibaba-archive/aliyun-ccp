// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSListFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSListFileRequest body;

    public static OSSListFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSListFileRequestModel self = new OSSListFileRequestModel();
        return TeaModel.build(map, self);
    }

}
