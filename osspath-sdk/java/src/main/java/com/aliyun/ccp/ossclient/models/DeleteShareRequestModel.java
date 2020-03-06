// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DeleteShareRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteShareRequest body;

    public static DeleteShareRequestModel build(java.util.Map<String, ?> map) throws Exception {
        DeleteShareRequestModel self = new DeleteShareRequestModel();
        return TeaModel.build(map, self);
    }

}
