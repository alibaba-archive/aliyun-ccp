// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSGetSecureUrlRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSGetSecureUrlRequest body;

    public static OSSGetSecureUrlRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSGetSecureUrlRequestModel self = new OSSGetSecureUrlRequestModel();
        return TeaModel.build(map, self);
    }

}
