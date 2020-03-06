// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPListUploadedPartRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPListUploadedPartRequest body;

    public static CCPListUploadedPartRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CCPListUploadedPartRequestModel self = new CCPListUploadedPartRequestModel();
        return TeaModel.build(map, self);
    }

}
