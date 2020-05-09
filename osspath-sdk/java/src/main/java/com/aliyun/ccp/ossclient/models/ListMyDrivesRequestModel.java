// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListMyDrivesRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListMyDriveRequest body;

    public static ListMyDrivesRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListMyDrivesRequestModel self = new ListMyDrivesRequestModel();
        return TeaModel.build(map, self);
    }

}
