// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CopyFileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSCopyFileResponse body;

    public static CopyFileModel build(java.util.Map<String, ?> map) throws Exception {
        CopyFileModel self = new CopyFileModel();
        return TeaModel.build(map, self);
    }

}
