// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSCreateFileRequest body;

    public static CreateFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CreateFileRequestModel self = new CreateFileRequestModel();
        return TeaModel.build(map, self);
    }

}
