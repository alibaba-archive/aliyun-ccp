// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetDefaultDriveRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetDefaultDriveRequest body;

    public static GetDefaultDriveRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetDefaultDriveRequestModel self = new GetDefaultDriveRequestModel();
        return TeaModel.build(map, self);
    }

}
