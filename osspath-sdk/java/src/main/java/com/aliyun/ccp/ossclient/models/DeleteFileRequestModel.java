// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DeleteFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSDeleteFileRequest body;

    public static DeleteFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        DeleteFileRequestModel self = new DeleteFileRequestModel();
        return TeaModel.build(map, self);
    }

}
