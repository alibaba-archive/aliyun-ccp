// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateDriveModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateDriveResponse body;

    public static UpdateDriveModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateDriveModel self = new UpdateDriveModel();
        return TeaModel.build(map, self);
    }

}
