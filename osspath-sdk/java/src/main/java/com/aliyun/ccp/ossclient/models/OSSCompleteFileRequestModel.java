// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSCompleteFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSCompleteFileRequest body;

    public static OSSCompleteFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSCompleteFileRequestModel self = new OSSCompleteFileRequestModel();
        return TeaModel.build(map, self);
    }

}
