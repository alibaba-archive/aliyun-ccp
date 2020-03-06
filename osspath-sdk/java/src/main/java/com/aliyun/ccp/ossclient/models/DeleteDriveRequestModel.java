// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class DeleteDriveRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteDriveRequest body;

    public static DeleteDriveRequestModel build(java.util.Map<String, ?> map) throws Exception {
        DeleteDriveRequestModel self = new DeleteDriveRequestModel();
        return TeaModel.build(map, self);
    }

}
