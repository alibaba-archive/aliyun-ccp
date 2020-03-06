// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetDriveRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDriveRequest body;

    public static GetDriveRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetDriveRequestModel self = new GetDriveRequestModel();
        return TeaModel.build(map, self);
    }

}
