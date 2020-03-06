// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPListFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPListFileRequest body;

    public static CCPListFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPListFileRequestModel self = new CCPListFileRequestModel();
        return TeaModel.build(map, self);
    }

}
