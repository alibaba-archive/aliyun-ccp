// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPSearchFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPSearchFileRequest body;

    public static CCPSearchFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPSearchFileRequestModel self = new CCPSearchFileRequestModel();
        return TeaModel.build(map, self);
    }

}
