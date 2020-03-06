// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class UpdateShareRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateShareRequest body;

    public static UpdateShareRequestModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateShareRequestModel self = new UpdateShareRequestModel();
        return TeaModel.build(map, self);
    }

}
