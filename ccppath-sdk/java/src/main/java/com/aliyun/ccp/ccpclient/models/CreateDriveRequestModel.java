// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CreateDriveRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateDriveRequest body;

    public static CreateDriveRequestModel build(java.util.Map<String, ?> map) throws Exception {
        CreateDriveRequestModel self = new CreateDriveRequestModel();
        return TeaModel.build(map, self);
    }

}
