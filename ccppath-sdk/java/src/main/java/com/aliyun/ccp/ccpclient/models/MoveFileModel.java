// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class MoveFileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPMoveFileResponse body;

    public static MoveFileModel build(java.util.Map<String, ?> map) throws Exception {
        MoveFileModel self = new MoveFileModel();
        return TeaModel.build(map, self);
    }

}
