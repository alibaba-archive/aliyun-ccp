// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateDriveRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateDriveRequest body;

    public static UpdateDriveRequestModel build(java.util.Map<String, ?> map) throws Exception {
        UpdateDriveRequestModel self = new UpdateDriveRequestModel();
        return TeaModel.build(map, self);
    }

}
