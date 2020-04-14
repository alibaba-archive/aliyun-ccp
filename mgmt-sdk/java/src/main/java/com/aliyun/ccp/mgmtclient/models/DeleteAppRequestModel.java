// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.mgmtclient.models;

import com.aliyun.tea.*;

public class DeleteAppRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteAppRequest body;

    public static DeleteAppRequestModel build(java.util.Map<String, ?> map) throws Exception {
        DeleteAppRequestModel self = new DeleteAppRequestModel();
        return TeaModel.build(map, self);
    }

}
