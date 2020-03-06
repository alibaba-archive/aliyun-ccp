// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetDefaultDriveModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDriveResponse body;

    public static GetDefaultDriveModel build(java.util.Map<String, ?> map) throws Exception {
        GetDefaultDriveModel self = new GetDefaultDriveModel();
        return TeaModel.build(map, self);
    }

}
