// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListDriveRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListDriveRequest body;

    public static ListDriveRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListDriveRequestModel self = new ListDriveRequestModel();
        return TeaModel.build(map, self);
    }

}
