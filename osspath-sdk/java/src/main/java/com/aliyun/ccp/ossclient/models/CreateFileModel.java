// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateFileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSCreateFileResponse body;

    public static CreateFileModel build(java.util.Map<String, ?> map) throws Exception {
        CreateFileModel self = new CreateFileModel();
        return TeaModel.build(map, self);
    }

}
