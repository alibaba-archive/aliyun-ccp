// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DeleteFileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPDeleteFileResponse body;

    public static DeleteFileModel build(java.util.Map<String, ?> map) throws Exception {
        DeleteFileModel self = new DeleteFileModel();
        return TeaModel.build(map, self);
    }

}
