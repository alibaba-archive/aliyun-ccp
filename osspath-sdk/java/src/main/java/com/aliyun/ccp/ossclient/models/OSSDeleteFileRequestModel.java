// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSDeleteFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSDeleteFileRequest body;

    public static OSSDeleteFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSDeleteFileRequestModel self = new OSSDeleteFileRequestModel();
        return TeaModel.build(map, self);
    }

}
