// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class MoveFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSMoveFileRequest body;

    public static MoveFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        MoveFileRequestModel self = new MoveFileRequestModel();
        return TeaModel.build(map, self);
    }

}
