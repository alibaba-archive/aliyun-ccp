// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateFileRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPUpdateFileMetaRequest body;

    public static UpdateFileRequestModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateFileRequestModel self = new UpdateFileRequestModel();
        return TeaModel.build(map, self);
    }

}
