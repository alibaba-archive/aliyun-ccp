// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSVideoResolutionRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoResolutionRequest body;

    public static OSSVideoResolutionRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoResolutionRequestModel self = new OSSVideoResolutionRequestModel();
        return TeaModel.build(map, self);
    }

}
