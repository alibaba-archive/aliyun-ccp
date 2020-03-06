// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListMyDriveRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListMyDriveRequest body;

    public static ListMyDriveRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListMyDriveRequestModel self = new ListMyDriveRequestModel();
        return TeaModel.build(map, self);
    }

}
