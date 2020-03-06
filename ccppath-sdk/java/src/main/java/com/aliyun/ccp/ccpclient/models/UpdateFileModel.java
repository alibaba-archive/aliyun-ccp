// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateFileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPUpdateFileMetaResponse body;

    public static UpdateFileModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateFileModel self = new UpdateFileModel();
        return TeaModel.build(map, self);
    }

}
