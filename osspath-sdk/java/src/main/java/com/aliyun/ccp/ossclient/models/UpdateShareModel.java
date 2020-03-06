// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class UpdateShareModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateShareResponse body;

    public static UpdateShareModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateShareModel self = new UpdateShareModel();
        return TeaModel.build(map, self);
    }

}
