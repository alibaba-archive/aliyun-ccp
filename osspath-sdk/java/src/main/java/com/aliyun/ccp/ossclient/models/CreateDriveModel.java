// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateDriveModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateDriveResponse body;

    public static CreateDriveModel build(java.util.Map<String, ?> map) throws Exception {
        CreateDriveModel self = new CreateDriveModel();
        return TeaModel.build(map, self);
    }

}
