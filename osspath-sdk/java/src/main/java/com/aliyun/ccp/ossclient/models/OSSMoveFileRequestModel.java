// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSMoveFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSMoveFileRequest body;

    public static OSSMoveFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSMoveFileRequestModel self = new OSSMoveFileRequestModel();
        return TeaModel.build(map, self);
    }

}
