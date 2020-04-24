// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListDrivesRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListDriveRequest body;

    public static ListDrivesRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListDrivesRequestModel self = new ListDrivesRequestModel();
        return TeaModel.build(map, self);
    }

}
