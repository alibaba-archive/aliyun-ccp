// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetFileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetFileResponse body;

    public static GetFileModel build(java.util.Map<String, ?> map) throws Exception {
        GetFileModel self = new GetFileModel();
        return TeaModel.build(map, self);
    }

}
