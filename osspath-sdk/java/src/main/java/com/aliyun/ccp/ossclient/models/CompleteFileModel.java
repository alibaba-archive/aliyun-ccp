// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CompleteFileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSCompleteFileResponse body;

    public static CompleteFileModel build(java.util.Map<String, ?> map) throws Exception {
        CompleteFileModel self = new CompleteFileModel();
        return TeaModel.build(map, self);
    }

}
