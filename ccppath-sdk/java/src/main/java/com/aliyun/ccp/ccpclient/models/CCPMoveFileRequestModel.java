// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPMoveFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPMoveFileRequest body;

    public static CCPMoveFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPMoveFileRequestModel self = new CCPMoveFileRequestModel();
        return TeaModel.build(map, self);
    }

}
