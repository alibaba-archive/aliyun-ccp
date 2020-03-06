// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetDriveModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDriveResponse body;

    public static GetDriveModel build(java.util.Map<String, ?> map) throws Exception {
        GetDriveModel self = new GetDriveModel();
        return TeaModel.build(map, self);
    }

}
